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


namespace Matura_Zadatak_A12
{
    public partial class Statistika : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A12;User ID=SA;Password=sp@sic123.");

        public Statistika()
        {
            InitializeComponent();
            chartUtakmice.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chartUtakmice.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
        }

        private void Statistika_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stadion f = new Stadion();
            f.Show();
            this.Hide();
        }

        private void Statistika_Load(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT TOP 10 (SELECT naziv FROM Stadion WHERE stadionID = K.stadionID ) , 
                                                (SELECT COUNT (*) FROM Utakmica WHERE domacinID = k.klubID AND YEAR(datum_igranja) = YEAR(GETDATE())) 
                                                FROM  Klub AS  K", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    chartUtakmice.Series[0].Points.AddXY(reader[0].ToString(), reader[1].ToString());
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
