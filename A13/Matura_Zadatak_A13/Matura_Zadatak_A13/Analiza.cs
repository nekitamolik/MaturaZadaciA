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

namespace Matura_Zadatak_A13
{
    public partial class Analiza : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A13;User ID=SA;Password=sp@sic123.");

        public Analiza()
        {
            InitializeComponent();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT P.ime AS Producent, COUNT(Pro.filmID) AS 'Broj filmova' FROM
                                                            Producirao AS PRO JOIN  Producent AS P 
                                                            ON PRO.producentID = P.producentID 
                                                            GROUP BY P.ime;", conn);
                if(adapter != null)
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    GV.DataSource = tabela;
                    GV.Refresh();

                    graph.Series[0].Points.Clear();
                    foreach(DataRow row in tabela.Rows)
                    {
                        graph.Series[0].Points.AddXY(row[0].ToString(), row[1].ToString());
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Producentska_kuca f = new Producentska_kuca();
            f.Show();
            this.Hide();
        }

        private void Analiza_FormClosed(object sender, FormClosedEventArgs e)
        {
            Producentska_kuca f = new Producentska_kuca();
            f.Show();
            this.Hide();
        }

    
    }
}
