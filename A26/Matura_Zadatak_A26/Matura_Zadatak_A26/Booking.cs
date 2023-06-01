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

namespace Matura_Zadatak_A26
{
    public partial class Booking : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.20;Initial Catalog=A26;User ID=SA;Password=sp@sic123.");

        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hotel f = new Hotel();
            f.Show();
            this.Hide();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string cmdtxt = @"SELECT sobaID AS 'No',
                                (SELECT tip_sobe FROM Tip_Sobe WHERE tip_sobeID=S.tip_sobeID) AS 'Tip sobe',
                                sprat AS 'Sprat'
                                FROM Soba AS S
                                WHERE sobaID NOT IN (";
                for (DateTime OD = monthCalendarOD.SelectionRange.Start; OD <= monthCalendarOD.SelectionRange.End; OD=OD.AddDays(1.0))
                    for (DateTime DO = monthCalendarDO.SelectionRange.Start; DO <= monthCalendarDO.SelectionRange.End; DO=DO.AddDays(1.0))
                    {

                        SqlCommand sobe = new SqlCommand(@"
                                (SELECT sobaID FROM Rezervacija_Sobe WHERE ugovorID IN 
                                (SELECT ugovorID FROM Rezervacija WHERE pocetak_usluge BETWEEN @od AND @do AND kraj_usluge>@od))",conn);
                        sobe.Parameters.AddWithValue("@od", OD.ToString("yyyy.MM.dd"));
                        sobe.Parameters.AddWithValue("@do", DO.ToString("yyyy.MM.dd"));
                        SqlDataReader reader = sobe.ExecuteReader();
                        while (reader.Read())
                        {
                            cmdtxt += reader[0].ToString();
                            if (OD == monthCalendarOD.SelectionRange.End && DO == monthCalendarDO.SelectionRange.End)
                                cmdtxt += ");";
                            else
                                cmdtxt += ",";
                        }
                        reader.Dispose();
                        
                    }
                SqlCommand comm = new SqlCommand(cmdtxt, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable tabela = new DataTable();
                if (adapter != null)
                {
                    adapter.Fill(tabela);
                    GV.DataSource = tabela;
                    GV.Refresh();
                }
                SqlCommand br = new SqlCommand("SELECT COUNT(*) FROM Soba", conn);
                lblUkupno.Text = "Ukupni kapacitet: " + br.ExecuteScalar().ToString();
                lblOstalo.Text = "Dostupni kapacitet: " + tabela.Rows.Count.ToString();
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
            Hotel f = new Hotel();
            f.Show();
            this.Hide();
        }
    }
}
