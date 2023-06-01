using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Matura_Zadatak_A6
{
    public partial class Model : Form
    {

        SqlConnection conn=new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A6;User ID=SA;Password=sp@sic123.");

        public Model()
        {
            InitializeComponent();
        }

        private void Model_Load(object sender, EventArgs e)
        {
            
            try 
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT naziv FROM Proizvodjac;", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    cbProizvodjac.Items.Add(reader[0].ToString());
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
                Model f = new Model();
                tabControl1.Size = f.Size;
                listBox_Refresh();
            }

            /*tab2*/
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT MIN(godina_proizvodnje) FROM Vozilo;", conn);
                int min = Convert.ToInt32(comm.ExecuteScalar());
                numericUpDownOD.Minimum = min;
                numericUpDownOD.Maximum = DateTime.Today.Year - 1;
                numericUpDownDO.Minimum = min + 1;
                numericUpDownDO.Maximum = DateTime.Today.Year;
                listViewProizvodjac.Columns[0].Width = listViewProizvodjac.Width *2/3;
                listViewProizvodjac.Columns[1].Width = listViewProizvodjac.Width / 3;
                Graph.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                Graph.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true;
                
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

        private void listBox_Refresh() 
        { 
            try
            {
                conn.Open();
                listBoxModeli.Items.Clear();
                SqlCommand comm = new SqlCommand(@"SELECT modelID, M.naziv+', '+P.naziv 
                                                FROM Model AS M JOIN Proizvodjac AS P ON M.proizvodjacID=P.proizvodjacID;", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    listBoxModeli.Items.Add(string.Format("{0:000}",reader[0])+"\t"+reader[1].ToString());
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

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                if (!string.IsNullOrEmpty(tbSifra.Text))
                {
                    if (listBoxModeli.FindString(string.Format("{0:000}", Convert.ToInt32(tbSifra.Text))) > 0)
                    {
                        int i = listBoxModeli.FindString(string.Format("{0:000}", Convert.ToInt32(tbSifra.Text)));
                        string selected = listBoxModeli.Items[i].ToString();
                        string[] s = selected.Split('\t');
                        string[] s1 = s[1].Split(',');
                        string proizvodjac = s1[1];
                        string model = s1[0];
                        SqlCommand comm = new SqlCommand(@"SELECT proizvodjacID FROM Model WHERE modelID = @mID;", conn);
                        comm.Parameters.AddWithValue("@mID", tbSifra.Text);
                        int pID = Convert.ToInt32(comm.ExecuteScalar());
                        SqlCommand comm1 = new SqlCommand(@"UPDATE Model 
                                                        SET naziv = @model
                                                        WHERE modelID=@mID;", conn);
                        SqlCommand comm2 = new SqlCommand(@"UPDATE Proizvodjac
                                                        SET naziv = @proizvodjac
                                                        WHERE proizvodjacID=@pID;", conn);
                        comm1.Parameters.AddWithValue("@model", tbNazivModela.Text);
                        comm1.Parameters.AddWithValue("@mID", tbSifra.Text);
                        comm2.Parameters.AddWithValue("@proizvodjac", cbProizvodjac.Text);
                        comm2.Parameters.AddWithValue("@pID", pID);
                        comm1.ExecuteNonQuery();
                        comm2.ExecuteNonQuery();
                    }
                }

                else
                    MessageBox.Show("Morate selektovati red za izmenu putem pretrage!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
                listBox_Refresh();
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSifra.Text))
            {
                if (listBoxModeli.FindString(string.Format("{0:000}", Convert.ToInt32(tbSifra.Text))) > 0)
                {
                    int i = listBoxModeli.FindString(string.Format("{0:000}", Convert.ToInt32(tbSifra.Text)));
                    string selected = listBoxModeli.Items[i].ToString();
                    string[] s = selected.Split('\t');
                    string[] s1 = s[1].Split(',');
                    cbProizvodjac.Text = s1[1];
                    tbNazivModela.Text = s1[0];
                    listBoxModeli.SelectedItem = listBoxModeli.Items[i];
                }

                else
                {
                    cbProizvodjac.Text = "";
                    tbNazivModela.Text = "";
                    listBoxModeli.SelectedItem = null;
                }
            }
        }

        private void btnPrikaziTab2_Click(object sender, EventArgs e)
        {
            try
            {
                listViewProizvodjac.Items.Clear();
                conn.Open();
                SqlCommand r = new SqlCommand(@"SELECT P.naziv,COUNT(*) FROM
                                                Vozilo AS V JOIN Model AS M ON V.modelID=M.modelID
                                                JOIN Proizvodjac AS P ON M.proizvodjacID=P.proizvodjacID
                                                WHERE V.godina_proizvodnje BETWEEN @godOD AND @godDO AND V.predjenoKM<@km
                                                GROUP BY P.naziv
                                                ORDER BY P.naziv;", conn);
                r.Parameters.AddWithValue("@godOD", numericUpDownOD.Value.ToString());
                r.Parameters.AddWithValue("@godDO", numericUpDownDO.Value.ToString());
                r.Parameters.AddWithValue("@km", tbKm.Text);
                SqlDataReader reader = r.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem row = new ListViewItem(reader[0].ToString());
                    row.SubItems.Add(reader[1].ToString());
                    listViewProizvodjac.Items.Add(row);
                }
                reader.Dispose();
                Graph.Series[0].Points.Clear();
                for (int i = 0; i < listViewProizvodjac.Items.Count; i++) 
                {
                    Graph.Series[0].Points.AddXY(listViewProizvodjac.Items[i].SubItems[0].Text, listViewProizvodjac.Items[i].SubItems[1].Text);
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


    }
}
