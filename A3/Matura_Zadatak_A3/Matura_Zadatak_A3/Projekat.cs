using System;
using System.IO;
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


namespace Matura_Zadatak_A3
{
    public partial class Projekat : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=192.168.0.20;Initial Catalog=A3;User ID=SA;Password=sp@sic123.");
        public Projekat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh_form();
        }

        private void Refresh_form() 
        {
            try
            {
                conn.Open();
                listViewProjekti.Items.Clear();
                SqlCommand comm = new SqlCommand(@"SELECT *  FROM Projekat;", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    ListViewItem row = new ListViewItem();
                    row.SubItems[0].Text = reader[0].ToString();
                    row.SubItems.Add(reader[1].ToString());
                    row.SubItems.Add(Convert.ToDateTime(reader[2]).ToShortDateString());
                    row.SubItems.Add(reader[3].ToString());
                    row.SubItems.Add(reader[4].ToString());
                    row.SubItems.Add(reader[5].ToString());
                    listViewProjekti.Items.Add(row);    
                }
                reader.Dispose();
                tbSifra.Text = "";
                tbNaziv.Text = "";
                tbDatumPocetka.Text = "";
                tbBudzet.Text = "";
                cbZavrsen.Checked = false;
                tbOpis.Text = "";
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSifra.Text))
            {
                MessageBox.Show("Morate odabrati Projekat", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
            {
                try 
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(@"SELECT projekatID FROM Projekat WHERE  YEAR(datum_pocetka)<YEAR(GETDATE())-5 AND projekat_zavrsen = 'TRUE';", conn);
                    List<string> gotovi_projekti = new List<string>();
                    SqlDataReader reader = comm.ExecuteReader();
                    while(reader.Read())
                    {
                        gotovi_projekti.Add(reader[0].ToString());
                    }
                    reader.Dispose();
                    if (gotovi_projekti.Count != 0)
                    {
                        if (!string.IsNullOrEmpty(tbSifra.Text))
                        {
                            if (gotovi_projekti.Contains(tbSifra.Text))
                            {
                                SqlCommand delete = new SqlCommand(@"DELETE FROM Projekat WHERE projekatID=@projekatID;", conn);
                                delete.Parameters.AddWithValue("@projekatID", tbSifra.Text);
                                delete.ExecuteNonQuery();
                                string path = Directory.GetCurrentDirectory() + "/Log doks/log_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".txt";
                                File.AppendAllText(path, "Sifra: " + tbSifra.Text + "; Naziv: " + tbNaziv.Text + "\n");
                            }

                            else
                            {

                                MessageBox.Show("Kako bi obrisali projekat projekat mora biti zavrsen i straiji od 5 godina!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else 
                        {
                            MessageBox.Show("Kako bi obrisali projekat morate uneti njegovu sifru!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } 
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                    Refresh_form();
                }
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listViewProjekti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProjekti.SelectedItems.Count != 0) 
            {
                tbSifra.Text = listViewProjekti.SelectedItems[0].Text;
                tbNaziv.Text = listViewProjekti.SelectedItems[0].SubItems[1].Text;
                tbDatumPocetka.Text = listViewProjekti.SelectedItems[0].SubItems[2].Text;
                tbBudzet.Text = listViewProjekti.SelectedItems[0].SubItems[3].Text;
                if (listViewProjekti.SelectedItems[0].SubItems[4].Text == "TRUE")
                    cbZavrsen.Checked = true;
                else
                    cbZavrsen.Checked = false;
                tbOpis.Text = listViewProjekti.SelectedItems[0].SubItems[5].Text;
            }
            
        }

        private void toolStripButtonPregled_Click(object sender, EventArgs e)
        {
            Statistika f = new Statistika();
            f.Show();
            this.Hide();
        }


    }
}
