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

namespace Matura_Zadatak_A15
{
    public partial class Analiza : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A15;User ID=SA;Password=sp@sic123.");

        public Analiza()
        {
            InitializeComponent();
            graph.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            graph.ChartAreas[0].AxisX.Interval = 1;
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT naziv_grupe FROM Grupa_Leka", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    checkedListBoxGrupeLekova.Items.Add(reader[0].ToString());
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
            if (checkedListBoxGrupeLekova.CheckedItems.Count > 0)
            {
                graph.Series[0].Points.Clear();
                for (int i = 0; i < checkedListBoxGrupeLekova.CheckedItems.Count; i++)
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) FROM Lek 
                                                         WHERE grupa_lekaID=(SELECT grupa_lekaID FROM Grupa_Leka WHERE naziv_grupe=@grupa);", conn);
                        comm.Parameters.AddWithValue("@grupa", checkedListBoxGrupeLekova.CheckedItems[i].ToString());
                        int br = Convert.ToInt32(comm.ExecuteScalar());
                        graph.Series[0].Points.AddXY(checkedListBoxGrupeLekova.CheckedItems[i].ToString(), br);
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

            else 
            {
                MessageBox.Show("Morate odabrati grupe za prikaz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Bolest_Lek f = new Bolest_Lek();
            f.Show();
            this.Hide();
        }
    }
}
