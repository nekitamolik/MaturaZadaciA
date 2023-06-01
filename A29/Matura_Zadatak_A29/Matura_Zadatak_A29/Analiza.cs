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

namespace Matura_Zadatak_A29
{
    public partial class Analiza : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A29;User ID=SA;Password=sp@sic123.");

        public Analiza()
        {
            InitializeComponent();
            PieChart.ChartAreas[0].Area3DStyle.Enable3D = true ;
            PieChart.ChartAreas[0].Area3DStyle.Inclination = 45;
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++) 
            {
                cbDanOD.Items.Add(i);
                cbDanDO.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                cbMesecOD.Items.Add(i);
                cbMesecDO.Items.Add(i);
            }
        }

        private void Analiza_FormClosed(object sender, FormClosedEventArgs e)
        {
            Igraci f = new Igraci();
            f.Show();
            this.Hide();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                GV.DataSource = null;
                PieChart.Series[0].Points.Clear();
                if (!string.IsNullOrEmpty(cbDanOD.Text) && !string.IsNullOrEmpty(cbMesecOD.Text) && !string.IsNullOrEmpty(tbGodinaOD.Text)
                    && !string.IsNullOrEmpty(cbDanDO.Text) && !string.IsNullOrEmpty(cbMesecDO.Text) && !string.IsNullOrEmpty(tbGodinaDO.Text)) 
                {
                    SqlCommand comm = new SqlCommand(@"SELECT terenID AS TerenID,(SELECT teren FROM Teren WHERE terenID=P.terenID) AS Teren,COUNT(partijaID) AS Broj
                                                     FROM Partija AS P
                                                     WHERE datum BETWEEN @OD AND @DO
                                                     GROUP BY terenID;", conn);
                    comm.Parameters.AddWithValue("@OD", tbGodinaOD.Text + "." + cbMesecOD.Text + "." + cbDanOD.Text);
                    comm.Parameters.AddWithValue("@DO", tbGodinaDO.Text + "." + cbMesecDO.Text + "." + cbDanDO.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    if (adapter != null) 
                    {
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);
                        GV.DataSource = tabela;
                        GV.Refresh();
                        foreach (DataRow row in tabela.Rows) 
                        {
                            PieChart.Series[0].Points.AddXY(row[1].ToString(), row[2].ToString());
                        }
                    }
                }

                else
                    MessageBox.Show("Morate popuniti vremenski interval za prikaz!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Igraci f = new Igraci();
            f.Show();
            this.Hide();
        }


    }
}
