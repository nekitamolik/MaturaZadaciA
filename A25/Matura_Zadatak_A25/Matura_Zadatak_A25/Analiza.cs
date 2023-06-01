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


namespace Matura_Zadatak_A25
{
    public partial class Analiza : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A25;User ID=SA;Password=sp@sic123.");

        public Analiza()
        {
            InitializeComponent();
            
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand minY = new SqlCommand(@"SELECT MIN(YEAR(datum_zakazivanja)) FROM Zakazivanje", conn);
                int min = Convert.ToInt32(minY.ExecuteScalar());
                int max = DateTime.Now.Year;
                numericUpDownOD.Minimum = min;
                numericUpDownOD.Maximum = max - 1;
                numericUpDownDO.Minimum = min + 1;
                numericUpDownDO.Maximum = max;
                numericUpDownOD.Value = DateTime.Now.AddYears(-10).Year;
                numericUpDownDO.Value = DateTime.Now.Year;
                SqlCommand grad = new SqlCommand(@"SELECT grad FROM Grad", conn);
                SqlDataReader reader = grad.ExecuteReader();
                cbGrad.Text = "Izaberite grad ...";
                while (reader.Read()) 
                {
                    cbGrad.Items.Add(reader[0].ToString());
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

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                graph.Series[0].Points.Clear();
                int godina = Convert.ToInt32(numericUpDownOD.Value);
                for (int i = Convert.ToInt32(numericUpDownOD.Value); i <= Convert.ToInt32(numericUpDownDO.Value);i++ )
                {
                    SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) FROM Zakazivanje
                                                    WHERE 
                                                    pacijentID IN (SELECT pacijentID FROM Pacijent WHERE gradID = (SELECT gradID FROM Grad WHERE grad=@grad))
                                                    AND
                                                    YEAR(datum_zakazivanja)=@god;", conn);
                    comm.Parameters.AddWithValue("@grad", cbGrad.Text);
                    comm.Parameters.AddWithValue("@god", i);
                    int br = Convert.ToInt32(comm.ExecuteScalar());
                    graph.Series[0].Points.AddXY(i, br);
                    godina++;
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

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            ZakaziPregled f = new ZakaziPregled();
            f.Show();
            this.Hide();
        }

        
    }
}
