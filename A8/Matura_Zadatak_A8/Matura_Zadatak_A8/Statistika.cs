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

namespace Matura_Zadatak_A8
{
    public partial class Statistika : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A8;User ID=SA;Password=sp@sic123.");

        public Statistika()
        {
            InitializeComponent();
            nudGod.Maximum = DateTime.Now.Year;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                graph.Series[0].Points.Clear();
                SqlCommand comm = new SqlCommand(@"SELECT G.grad AS Grad , COUNT(antikvitetID) AS 'Broj Otkrica'
                                                FROM Antikvitet AS A JOIN Lokalitet AS L ON A.lokalitetID = L.lokalitetID
                                                JOIN Grad AS G ON L.gradID=G.gradID
                                                WHERE YEAR(A.datum_pronalaska)>@god
                                                GROUP BY G.grad
                                                HAVING COUNT(antikvitetID)>@br", conn);
                comm.Parameters.AddWithValue("@god", nudGod.Value);
                comm.Parameters.AddWithValue("@br", nudBr.Value);
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
    }
}
