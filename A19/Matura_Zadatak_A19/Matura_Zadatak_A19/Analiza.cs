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

namespace Matura_Zadatak_A19
{
    public partial class Analiza : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A19;User ID=SA;Password=sp@sic123.");

        public Analiza()
        {
            InitializeComponent();
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                graph.Series[0].LegendText = Sektori.sektor;
                SqlCommand comm = new SqlCommand(@"SELECT (SELECT ime+' '+prezime FROM Radnik WHERE radnikID=RU.radnikID),
                                                datum_postavljanja,ISNULL(datum_razresenja,GETDATE())
                                                FROM Rukovodi_Sektorom AS RU
                                                WHERE sektorID = (SELECT sektorID FROM Sektor WHERE naziv=@sektor);", conn);
                comm.Parameters.AddWithValue(@"sektor", Sektori.sektor);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    DateTime OD = Convert.ToDateTime(reader[1].ToString());
                    DateTime DO = Convert.ToDateTime(reader[2].ToString());
                    int dani = Convert.ToInt32((DO - OD).TotalDays);
                    graph.Series[0].Points.AddXY(reader[0].ToString(), dani);
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

        private void Analiza_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sektori f = new Sektori();
            f.Show();
            this.Hide();
        }
    }
}
