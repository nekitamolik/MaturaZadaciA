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

namespace Matura_Zadatak_A21
{
    public partial class Analiza : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A21;User ID=SA;Password=sp@sic123.");

        public Analiza()
        {
            InitializeComponent();
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            graph.ChartAreas[0].AxisX.Interval = 1;
            graph.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            numericUpDownOD.Minimum = DateTime.Now.Year - 30;
            numericUpDownOD.Maximum = DateTime.Now.Year - 1;
            numericUpDownDO.Minimum = DateTime.Now.Year-29;
            numericUpDownDO.Maximum = DateTime.Now.Year;
        }

        private void Analiza_FormClosed(object sender, FormClosedEventArgs e)
        {
            Putovanja f = new Putovanja();
            f.Show();
            this.Hide();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT TOP 10 
                                                    (SELECT naziv_mesta FROM Destinacija WHERE destinacijaID=A.destinacijaID),
                                                    COUNT(*)
                                                    FROM Aranzman AS A
                                                    GROUP BY destinacijaID
                                                    ORDER BY COUNT(*) DESC;", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    graph.Series[0].Points.AddXY(reader[0].ToString(), reader[1].ToString());
                }
                reader.Dispose();
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
