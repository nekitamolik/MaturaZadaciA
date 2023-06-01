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

namespace Matura_Zadatak_A26
{
    public partial class Uplata : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.20;Initial Catalog=A26;User ID=SA;Password=sp@sic123.");

        public Uplata()
        {
            InitializeComponent();
        }

        private void LV_Refersh() 
        {
            if (cbUgovorID.Text != "Izaberite broj ugovora ...")
            {
                try
                {

                    listViewPregled.Items.Clear();
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand comm = new SqlCommand(@"SELECT iznos,
                                                    (SELECT nacin_placanja FROM Nacin_Placanja WHERE nacin_placanjaID = U.nacin_placanjaID)
                                                    FROM Uplata AS U
                                                    WHERE ugovorID =@id;", conn);
                    comm.Parameters.AddWithValue("@id", cbUgovorID.Text);
                    SqlDataReader reader = comm.ExecuteReader();
                    int br = 1;
                    while (reader.Read())
                    {
                        ListViewItem row = new ListViewItem(br.ToString());
                        row.SubItems.Add(reader[0].ToString());
                        row.SubItems.Add(reader[1].ToString());
                        listViewPregled.Items.Add(row);
                        br++;
                    }
                    reader.Dispose();

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
                MessageBox.Show("Izaberite broj ugovora", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Uplata_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cbUgovorID.Text = "Izaberite broj ugovora ...";
                SqlCommand ugovor = new SqlCommand(@"SELECT ugovorID FROM Rezervacija", conn);
                SqlDataReader reader = ugovor.ExecuteReader();
                while (reader.Read()) 
                {
                    cbUgovorID.Items.Add(reader[0].ToString());
                }
                reader.Dispose();

                cbNP.Text = "Izaberite nacin placanja ...";
                SqlCommand np = new SqlCommand(@"SELECT nacin_placanja FROM Nacin_Placanja", conn);
                SqlDataReader npreader = np.ExecuteReader();
                while (npreader.Read())
                {
                    cbNP.Items.Add(npreader[0].ToString());
                }
                npreader.Dispose();
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

        private void btnUplata_Click(object sender, EventArgs e)
        {
            if (cbUgovorID.Text != "Izaberite broj ugovora ...")
            {
                if (cbNP.Text != "Izaberite nacin placanja ...")
                {
                    if (!string.IsNullOrEmpty(tbIznos.Text))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand comm = new SqlCommand(@"INSERT INTO Uplata (ugovorID,nacin_placanjaID,iznos) VALUES
	                                                            (@ugovorID,(SELECT nacin_placanjaID FROM Nacin_Placanja WHERE nacin_placanja=@np),@iznos)", conn);
                            comm.Parameters.AddWithValue("@ugovorID", cbUgovorID.Text);
                            comm.Parameters.AddWithValue("@np", cbNP.Text);
                            comm.Parameters.AddWithValue("@iznos", Convert.ToDouble(tbIznos.Text));
                            comm.ExecuteNonQuery();
                        }

                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        finally
                        {
                            conn.Close();
                            cbUgovorID_SelectedIndexChanged(cbUgovorID, e);
                        }
                    }
                    else
                        MessageBox.Show("Unesite iznos za uplatu", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                    MessageBox.Show("Izaberite nacin placanja", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Izaberite broj ugovora", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hotel f = new Hotel();
            f.Show();
            this.Hide();
        }

        private void cbUgovorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUgovorID.Text != "Izaberite broj ugovora ...")
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(@"SELECT ugovorID,(SELECT ime+' '+prezime FROM Musterija WHERE musterijaID=R.musterijaID),
                                                    pocetak_usluge, DAY(kraj_usluge)-DAY(pocetak_usluge),ukupno_za_uplatu,rok_za_uplatu,
                                                    ukupno_za_uplatu - (SELECT SUM(iznos) FROM Uplata WHERE ugovorID=R.ugovorID)
                                                    FROM Rezervacija AS R WHERE ugovorID=@id;", conn);
                    comm.Parameters.AddWithValue("@id", cbUgovorID.Text);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        lblUgovor.Text = "Ugovor br: " + reader[0].ToString();
                        lblUgovarac.Text = "Ugovarac: " + reader[1].ToString();
                        lblPocetak.Text = "Pocetak usluge: " + Convert.ToDateTime(reader[2].ToString()).ToString("dd.MM.yyyy");
                        lblBrDana.Text = "Broj dana: " + reader[3].ToString();
                        lblUkupno.Text = "Ukupan iznos: " + reader[4].ToString();
                        lblRok.Text = "Rok za uplatu: " + Convert.ToDateTime(reader[5].ToString()).ToString("dd.MM.yyyy");
                        lblDug.Text = "Dug: " + Math.Round(Convert.ToDouble(reader[6].ToString()), 2);
                    }
                    reader.Dispose();
                    LV_Refersh();
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
                MessageBox.Show("Izaberite broj ugovora", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Uplata_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hotel f = new Hotel();
            f.Show();
            this.Hide();
        }
    }
}
