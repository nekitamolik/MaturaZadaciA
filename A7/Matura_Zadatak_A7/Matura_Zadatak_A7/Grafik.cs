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

namespace Matura_Zadatak_A7
{
    public partial class Grafik : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A7;User ID=SA;Password=sp@sic123.");

        public Grafik()
        {
            InitializeComponent();
        }

        private void Grafik_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT predmet FROM Predmet;", conn);
                if (adapter != null) 
                {
                    DataTable predmeti = new DataTable();
                    string predmet = "";
                    adapter.Fill(predmeti);
                    foreach (DataRow row in predmeti.Rows) 
                    {
                        predmet = row[0].ToString();
                        checkedListBoxPredmeti.Items.Add(predmet,CheckState.Unchecked);
                    }

                    graph.Series[0].LegendText = (DateTime.Now.Year - 3).ToString();
                    graph.Series[1].LegendText = (DateTime.Now.Year - 2).ToString();
                    graph.Series[2].LegendText = (DateTime.Now.Year - 1).ToString();
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
            try 
            {
                conn.Open();
                GV.DataSource = null;
                GV.Refresh();
                graph.Series[0].Points.Clear();
                graph.Series[1].Points.Clear();
                graph.Series[2].Points.Clear();
                string predmeti = "";
                for (int i = 0; i < checkedListBoxPredmeti.CheckedItems.Count; i++) 
                {
                    if (i == checkedListBoxPredmeti.CheckedItems.Count - 1)
                        predmeti += "'" + checkedListBoxPredmeti.CheckedItems[i].ToString() + "'";
                    else
                        predmeti += "'" + checkedListBoxPredmeti.CheckedItems[i].ToString() + "',";
                }
                SqlCommand comm = new SqlCommand(@"
                                                SELECT predmet,
                                                (SELECT COUNT(studentID)
                                                FROM  Izabrani_Predmet AS IZP JOIN Predmet AS P 
                                                ON IZP.predmetID = P.predmetID 
                                                WHERE P.predmet = Pr.predmet AND godina_slusanja=@godina1) AS '" + (DateTime.Now.Year - 3).ToString() + @"',
                                                (SELECT COUNT(studentID)
                                                FROM  Izabrani_Predmet AS IZP JOIN Predmet AS P 
                                                ON IZP.predmetID = P.predmetID 
                                                WHERE P.predmet = Pr.predmet AND godina_slusanja=@godina2) AS '" + (DateTime.Now.Year - 2).ToString() + @"',
                                                (SELECT COUNT(studentID)
                                                FROM  Izabrani_Predmet AS IZP JOIN Predmet AS P 
                                                ON IZP.predmetID = P.predmetID 
                                                WHERE P.predmet = Pr.predmet AND godina_slusanja=@godina3) AS '" + (DateTime.Now.Year - 1).ToString() + @"'
                                                FROM Predmet AS Pr
                                                WHERE predmet IN (" + predmeti + ");", conn);
                
                comm.Parameters.AddWithValue("@godina1", DateTime.Now.Year - 3);
                comm.Parameters.AddWithValue("@godina2", DateTime.Now.Year - 2);
                comm.Parameters.AddWithValue("@godina3", DateTime.Now.Year - 1);

                SqlDataAdapter adapter = new SqlDataAdapter (comm);
                if (adapter != null) 
                {
                    DataTable GV_tabela = new DataTable();
                    adapter.Fill(GV_tabela);
                    GV.DataSource = GV_tabela;
                    GV.Refresh();

                    foreach (DataRow row in GV_tabela.Rows) 
                    {
                        graph.Series[0].Points.AddXY(row[0].ToString(), row[1].ToString());
                        graph.Series[1].Points.AddXY(row[0].ToString(), row[2].ToString());
                        graph.Series[2].Points.AddXY(row[0].ToString(), row[3].ToString());
                    }
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

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkedListBoxPredmeti_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBoxPredmeti.CheckedItems.Count > 4) 
            {
                MessageBox.Show("Mozete pregledati najvise 5 predmeta po prikazu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.NewValue = CheckState.Unchecked;
            }            
        }
    }
}
