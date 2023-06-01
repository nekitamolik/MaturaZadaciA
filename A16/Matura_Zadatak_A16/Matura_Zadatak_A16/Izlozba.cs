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

namespace Matura_Zadatak_A16
{
    public partial class Izlozba : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A16;User ID=SA;Password=sp@sic123.");

        public Izlozba()
        {
            InitializeComponent();
            graph.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand pas = new SqlCommand(@"SELECT pasid, ime FROM Pas", conn);
                SqlDataReader rpas = pas.ExecuteReader();
                while (rpas.Read())
                {
                    cbPas.Items.Add(rpas[0].ToString() + "-" + rpas[1].ToString());
                }
                rpas.Dispose();
                SqlCommand iz = new SqlCommand(@"SELECT izlozbaID,mesto,datum FROM Izlozba 
                                                WHERE DATEADD(day,2,GETDATE())<datum;", conn);
                SqlDataReader riz = iz.ExecuteReader();
                while (riz.Read())
                {
                    cbIzlozba.Items.Add(riz[0].ToString() + "-" + riz[1].ToString() + "-" + Convert.ToDateTime(riz[2].ToString()).ToShortDateString());
                }
                riz.Dispose();
                SqlCommand k = new SqlCommand(@"SELECT kategorijaID,naziv FROM Kategorija", conn);
                SqlDataReader rk = k.ExecuteReader();
                while (rk.Read())
                {
                    cbKategorija.Items.Add(rk[0].ToString() + "-" + rk[1].ToString());
                }
                rk.Dispose();

                /*TAB 2*/

                SqlCommand iz2 = new SqlCommand(@"SELECT izlozbaID,mesto,datum FROM Izlozba 
                                                WHERE GETDATE()>datum;", conn);
                SqlDataReader riz2 = iz2.ExecuteReader();
                while (riz2.Read())
                {
                    cbIzlozbaTab2.Items.Add(riz2[0].ToString() + "-" + riz2[1].ToString() + "-" + Convert.ToDateTime(riz2[2].ToString()).ToShortDateString());
                }
                riz2.Dispose();
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string[] pom = cbPas.Text.Split('-');
                string pas = pom[0];
                pom = cbIzlozba.Text.Split('-');
                string iz = pom[0];
                pom = cbKategorija.Text.Split('-');
                string k = pom[0];
                conn.Open();
                if (!string.IsNullOrEmpty(cbPas.Text) && !string.IsNullOrEmpty(cbKategorija.Text) && !string.IsNullOrEmpty(cbIzlozba.Text))
                {
                    SqlCommand exists = new SqlCommand(@"SELECT COUNT(*) FROM Rezultat 
                                                         WHERE pasID=@pas AND izlozbaID=@iz AND kategorijaID=@k;", conn);
                    exists.Parameters.AddWithValue("@pas", pas);
                    exists.Parameters.AddWithValue("@iz", iz);
                    exists.Parameters.AddWithValue("@k", k);
                    int br = Convert.ToInt32(exists.ExecuteScalar());
                    exists.Dispose();
                    if (br == 0)
                    {
                        SqlCommand upis = new SqlCommand(@"INSERT INTO Rezultat (izlozbaID,kategorijaID,pasID) VALUES (@iz,@k,@pas)", conn);
                        upis.Parameters.AddWithValue("@pas", pas);
                        upis.Parameters.AddWithValue("@iz", iz);
                        upis.Parameters.AddWithValue("@k", k);
                        upis.ExecuteNonQuery();
                        MessageBox.Show("Pas je prijavljen!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Pas je vec prijavljen!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    MessageBox.Show("Morate popuniti formu za prijavu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbIzlozbaTab2.Text))
            {
                try
                {
                    conn.Open();
                    graph.Series[0].Points.Clear();
                    string[] pom = cbIzlozbaTab2.Text.Split('-');
                    string iz = pom[0];
                    SqlCommand comm = new SqlCommand(@"SELECT kategorijaID AS Sifra,
                                                (SELECT naziv FROM Kategorija AS K WHERE K.kategorijaID=R.kategorijaID) AS 'Naziv kategorije',
                                                (SELECT COUNT(pasID) FROM Rezultat WHERE kategorijaID=R.kategorijaID AND izlozbaID=@iz ) AS 'Broj pasa'
                                                FROM Rezultat AS R
                                                WHERE izlozbaID=@iz
                                                GROUP BY kategorijaID;", conn);
                    comm.Parameters.AddWithValue("@iz", iz);
                    SqlCommand prijava = new SqlCommand(@"SELECT COUNT(pasID) FROM Rezultat WHERE izlozbaID=@iz;", conn);
                    prijava.Parameters.AddWithValue("@iz", iz);
                    lblbrPrijavljenih.Text = prijava.ExecuteScalar().ToString();
                    SqlCommand takmicenje = new SqlCommand(@"SELECT COUNT(pasID) FROM Rezultat WHERE izlozbaID=@iz AND rezultat IS NOT NULL;", conn);
                    takmicenje.Parameters.AddWithValue("@iz", iz);
                    lblbrTakmicenje.Text = takmicenje.ExecuteScalar().ToString();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    if (adapter != null)
                    {
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);
                        GV.DataSource = tabela;
                        GV.Refresh();
                        foreach (DataRow row in tabela.Rows)
                        {
                            graph.Series[0].Points.AddXY(row[1].ToString(), row[2].ToString());
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
                }
            }

            else
            {
                MessageBox.Show("Odaberite izlozbu za prikaz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPagePrijava;
        }

        private void tabPageExit_Enter(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
