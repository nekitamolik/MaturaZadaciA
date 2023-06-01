using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Matura_Zadatak_A28
{
    public partial class Kupovina : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A28;User ID=SA;Password=sp@sic123.");

        public Kupovina()
        {
            InitializeComponent();
            GV.Columns[0].ReadOnly = true;
            GV.Columns[1].ReadOnly = true;
            GV.Columns[2].ReadOnly = true;
            GV.Columns[3].ReadOnly = true;
            GV.Columns[4].ReadOnly = false;
            GV.Columns[5].ReadOnly = true;
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPorudzbinaID.Text))
            {
                try
                {
                    conn.Open();
                    btnKupi.Enabled = true;
                    rtbRacun.Text = "";

                    SqlCommand comm = new SqlCommand(@"SELECT 'true' FROM Porudzbina WHERE porudzbinaID=@id", conn);
                    comm.Parameters.AddWithValue("@id", tbPorudzbinaID.Text);
                   
                    if (comm.ExecuteScalar() == null)   
                        MessageBox.Show("Neispravna sifra porudzbine!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
                    else 
                    {

                        int br = 1;

                        SqlCommand podaci = new SqlCommand(@"SELECT (SELECT ime+' '+prezime FROM Kupac WHERE kupacID = P.kupacID), 
                                                            datum_porucivanja FROM Porudzbina AS P WHERE porudzbinaID=@id;", conn);
                        podaci.Parameters.AddWithValue("@id", tbPorudzbinaID.Text);
                        SqlDataReader r1 = podaci.ExecuteReader();
                        if (r1.Read()) 
                        {
                            rtbRacun.Text += r1[0].ToString()+"\n";
                            rtbRacun.Text += "Datum porucivanja: " + Convert.ToDateTime(r1[1].ToString()).ToString("dd.MM.yyyy");
                        }
                        r1.Dispose();

                        rtbRacun.Text += "\n\nSadrzaj korpe:\n";

                        SqlCommand racun = new SqlCommand(@"SELECT (SELECT proizvod FROM Proizvod WHERE proizvodID=SP.proizvodID),kolicina,suma 
                                                            FROM Stavke_Porudzbine AS SP WHERE porudzbinaID=@id;", conn);
                        racun.Parameters.AddWithValue("@id", tbPorudzbinaID.Text);
                        SqlDataReader r2 = racun.ExecuteReader();
                        while (r2.Read()) 
                        {
                            rtbRacun.Text += br + ". " + r2[0].ToString() + ", kolicina: " + r2[1].ToString() + ", iznos: " + Math.Round(Convert.ToDouble(r2[2].ToString()),2) + "RSD\n";
                        }
                        r2.Dispose();

                        SqlCommand isporuceno = new SqlCommand(@"SELECT datum_izvrsenja FROM Porudzbina WHERE porudzbinaID=@id;", conn);
                        isporuceno.Parameters.AddWithValue("@id", tbPorudzbinaID.Text);
                        DateTime datum = Convert.ToDateTime(isporuceno.ExecuteScalar());
                        if (datum < DateTime.Now)
                        {
                            rtbRacun.Text += "\nRoba u celosti isporucena: " + datum.ToString("dd.MM.yyyy") + "\nPROMENA NIJE MOGUCA\nMOZETE KREIRATI NOVU PORUDZBENICU";
                            btnKupi.Enabled = false;
                            GV.Columns[4].ReadOnly = true;
                        }
                        isporuceno.Dispose();

                        SqlCommand gvcomm = new SqlCommand(@"SELECT proizvodID,proizvod,
                                                            (SELECT jedinica_mere FROM Jedinica_Mere WHERE jedinica_mereID = P.jedinicaID),
                                                            prodajna_cena
                                                            FROM Proizvod AS P", conn);
                        gvcomm.Parameters.AddWithValue("@id", tbPorudzbinaID.Text);
                        SqlDataReader gvr = gvcomm.ExecuteReader();
                        while (gvr.Read()) 
                        {
                            GV.Rows.Add(gvr[0].ToString(), gvr[1].ToString(), gvr[2].ToString(), gvr[3].ToString(), false, "");
                        }
                        gvr.Dispose();

                        foreach (DataGridViewRow row in GV.Rows)
                            row.Cells[5].Style.BackColor = SystemColors.Control;
                    }
                    comm.Dispose();
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                }
            }

            else
                MessageBox.Show("Unesite odgovarajucu sifru porudzbine!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnKupi_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int[] indexi = new int[100];
                int br = 0;
                for (int i = 0; i < GV.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(GV.Rows[i].Cells[4].Value))
                    {

                        indexi[br] = i;
                        br++;
                    }

                }
                for (int j = 0; j < br; j++)
                {
                    SqlCommand comm = new SqlCommand(@"INSERT INTO Stavke_Porudzbine (porudzbinaID,proizvodID,kolicina,suma) VALUES
	                                                    (@porudzbinaID,@proizvodID,@kolicina,(SELECT prodajna_cena FROM Proizvod WHERE proizvodID=@proizvodID)*@kolicina);", conn);
                    comm.Parameters.AddWithValue("@porudzbinaID", tbPorudzbinaID.Text);
                    comm.Parameters.AddWithValue("@proizvodID", GV.Rows[indexi[j]].Cells[0].Value);
                    comm.Parameters.AddWithValue("@kolicina", GV.Rows[indexi[j]].Cells[5].Value);
                    comm.ExecuteNonQuery();
                }
                MessageBox.Show("Uspesna porudzbina!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Stovariste f = new Stovariste();
            f.Show();
            this.Hide();
        }

        private void GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && !GV.Columns[4].ReadOnly)
            {
                if (!Convert.ToBoolean(GV.Rows[e.RowIndex].Cells[4].Value))
                {
                    GV.Rows[e.RowIndex].Cells[4].Value = true;
                    GV.Rows[e.RowIndex].Cells[5].ReadOnly = false;
                    GV.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.Green;
                }

                else
                {
                    GV.Rows[e.RowIndex].Cells[4].Value = false;
                    GV.Rows[e.RowIndex].Cells[5].ReadOnly = true;
                    GV.Rows[e.RowIndex].Cells[5].Value = "";
                    GV.Rows[e.RowIndex].Cells[5].Style.BackColor = SystemColors.Control;
                }
            }
        }

    }
}
