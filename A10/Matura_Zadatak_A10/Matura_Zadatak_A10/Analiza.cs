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

namespace Matura_Zadatak_A10
{
    public partial class Analiza : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A10;User ID=SA;Password=sp@sic123.");

        public Analiza()
        {
            InitializeComponent();
            cbPecaros.Items.Add("Izaberi pecarosa");
            cbPecaros.SelectedItem = cbPecaros.Items[0];

            try 
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT pecarosID,ime,prezime FROM Pecaros", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    cbPecaros.Items.Add(reader[0] + "-" + reader[1] + " " + reader[2]);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (dateTimePickerDO.Value != null && dateTimePickerOD.Value != null && cbPecaros.SelectedItem != null && cbPecaros.SelectedItem != "Izaberi pecarosa")
            {
                try
                {
                    GV.DataSource = null;
                    GV.Refresh();
                    graph.Series[0].Points.Clear();
                    string[] s = cbPecaros.SelectedItem.ToString().Split('-');
                    conn.Open();
                    SqlCommand comm = new SqlCommand(@"SELECT V.naziv AS Naziv, COUNT(Rbr_ulova) AS Broj
                                                    FROM Ulov AS U JOIN Vrsta_Ribe AS V ON U.vrstaID  = V.vrstaID
                                                    WHERE pecarosID = @id AND datum BETWEEN @od AND @do
                                                    GROUP BY V.naziv;", conn);
                    comm.Parameters.AddWithValue("@id", s[0]);
                    comm.Parameters.AddWithValue("@od", dateTimePickerOD.Value.ToShortDateString());
                    comm.Parameters.AddWithValue("@do", dateTimePickerDO.Value.ToShortDateString());
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    if (adapter != null)
                    {
                        DataTable gv_tabela = new DataTable();
                        adapter.Fill(gv_tabela);
                        GV.DataSource = gv_tabela;
                        GV.Refresh();
                        foreach (DataRow r in gv_tabela.Rows)
                        {
                            graph.Series[0].Points.AddXY(r[0].ToString(), r[1].ToString());
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
                MessageBox.Show("Morate da odaberte pecarosa i period prikaza!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
