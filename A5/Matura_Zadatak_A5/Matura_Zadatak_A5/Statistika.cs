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

namespace Matura_Zadatak_A5
{
    public partial class Statistika : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A5;User ID=SA;Password=sp@sic123.");

        public Statistika()
        {
            InitializeComponent();
        }

        private void btnIzadji1_Click(object sender, EventArgs e)
        {
            Aktivnost f = new Aktivnost();
            f.Show();
            this.Hide();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                DataTable GV_tabela = new DataTable();
                GV_tabela.Columns.Add("Dan");
                GV_tabela.Columns.Add("Broj");
                for (int i = 0; i < 7; i++) 
                {
                    switch (i) 
                    {
                        case 0: 
                            {
                                SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) AS Broj
                                                FROM Registar_Aktivnosti AS RA  JOIN  Aktivnosti AS A ON RA.aktivnostID = A.aktivnostID 
                                                WHERE A.dan = 'Ponedeljak';", conn);
                                DataRow row = GV_tabela.NewRow();
                                row[0] = "Ponedeljak";
                                row[1] = comm.ExecuteScalar().ToString();
                                GV_tabela.Rows.Add(row);
                            }break;
                        case 1:
                            {
                                SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) AS Broj
                                                FROM Registar_Aktivnosti AS RA  JOIN  Aktivnosti AS A ON RA.aktivnostID = A.aktivnostID 
                                                WHERE A.dan = 'Utorak';", conn);
                                DataRow row = GV_tabela.NewRow();
                                row[0] = "Utorak";
                                row[1] = comm.ExecuteScalar().ToString();
                                GV_tabela.Rows.Add(row);
                            } break;
                        case 2:
                            {
                                SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) AS Broj
                                                FROM Registar_Aktivnosti AS RA  JOIN  Aktivnosti AS A ON RA.aktivnostID = A.aktivnostID 
                                                WHERE A.dan = 'Sreda';", conn);
                                DataRow row = GV_tabela.NewRow();
                                row[0] = "Sreda";
                                row[1] = comm.ExecuteScalar().ToString();
                                GV_tabela.Rows.Add(row);
                            } break;
                        case 3:
                            {
                                SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) AS Broj
                                                FROM Registar_Aktivnosti AS RA  JOIN  Aktivnosti AS A ON RA.aktivnostID = A.aktivnostID 
                                                WHERE A.dan = 'Cetvrtak';", conn);
                                DataRow row = GV_tabela.NewRow();
                                row[0] = "Cetvrtak";
                                row[1] = comm.ExecuteScalar().ToString();
                                GV_tabela.Rows.Add(row);
                            } break;
                        case 4:
                            {
                                SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) AS Broj
                                                FROM Registar_Aktivnosti AS RA  JOIN  Aktivnosti AS A ON RA.aktivnostID = A.aktivnostID 
                                                WHERE A.dan = 'Petak';", conn);
                                DataRow row = GV_tabela.NewRow();
                                row[0] = "Petak";
                                row[1] = comm.ExecuteScalar().ToString();
                                GV_tabela.Rows.Add(row);
                            } break;
                        case 5:
                            {
                                SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) AS Broj
                                                FROM Registar_Aktivnosti AS RA  JOIN  Aktivnosti AS A ON RA.aktivnostID = A.aktivnostID 
                                                WHERE A.dan = 'Subota';", conn);
                                DataRow row = GV_tabela.NewRow();
                                row[0] = "Subota";
                                row[1] = comm.ExecuteScalar().ToString();
                                GV_tabela.Rows.Add(row);
                            } break;
                        case 6:
                            {
                                SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) AS Broj
                                                FROM Registar_Aktivnosti AS RA  JOIN  Aktivnosti AS A ON RA.aktivnostID = A.aktivnostID 
                                                WHERE A.dan = 'Nedelja';", conn);
                                DataRow row = GV_tabela.NewRow();
                                row[0] = "Nedelja";
                                row[1] = comm.ExecuteScalar().ToString();
                                GV_tabela.Rows.Add(row);
                            } break;
                    }
                }

                if (GV_tabela != null) 
                {
                    GV.DataSource = GV_tabela;
                    GV.Refresh();
                    foreach (DataRow row in  GV_tabela.Rows) 
                    {
                        GV_chart.Series["S"].Points.AddXY(row[0].ToString(), row[1].ToString());
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

        
    }
}
