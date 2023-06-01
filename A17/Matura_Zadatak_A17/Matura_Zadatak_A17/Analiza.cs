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


namespace Matura_Zadatak_A17
{
    public partial class Analiza : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A17;User ID=SA;Password=sp@sic123.");

        public Analiza()
        {
            InitializeComponent();
            graph.ChartAreas[0].Area3DStyle.Enable3D = true;
            graph.ChartAreas[0].Area3DStyle.Inclination = 75;
            
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                SqlCommand model = new SqlCommand(@"SELECT naziv FROM Model;", conn);
                SqlDataReader mreader = model.ExecuteReader();
                while (mreader.Read())
                {
                    cbModel.Items.Add(mreader[0].ToString());
                }
                mreader.Dispose();
                model.Dispose();
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

        private void btnPrikaz_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cbModel.Text))
            {
                try
                {
                    graph.Series[0].Points.Clear();
                    conn.Open();
                    SqlCommand comm = new SqlCommand(@"SELECT godina_proizvodnje AS 'Godina proizvodnje', 
                                                            (SELECT AVG(cena) FROM Vozilo 
                                                            WHERE modelID= (SELECT modelID FROM Model WHERE naziv=@model)
                                                            AND
                                                            godina_proizvodnje=V.godina_proizvodnje) AS 'Prosecna Cena'
                                                            FROM Vozilo AS V
                                                            WHERE 
                                                            (SELECT COUNT(*) FROM Vozilo WHERE
                                                            modelID= (SELECT modelID FROM Model WHERE naziv=@model)
                                                            AND
                                                            godina_proizvodnje=V.godina_proizvodnje)>0
                                                            GROUP BY godina_proizvodnje;", conn);
                    comm.Parameters.AddWithValue("@model", cbModel.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    if (adapter != null)
                    {
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);
                        GV.DataSource = tabela;
                        GV.Refresh();
                        foreach (DataRow row in tabela.Rows)
                        {
                            graph.Series[0].Points.AddXY(row[0].ToString(), row[1].ToString());
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

            else
            {
                MessageBox.Show("Odaberite zeljeni model za prikaz podataka!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Garaza f = new Garaza();
            f.Show();
            this.Hide();
        }
    }
}
