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

namespace Matura_Zadatak_A14
{
    public partial class Analiza : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A14;User ID=SA;Password=sp@sic123.");

        public Analiza()
        {
            InitializeComponent();
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT naziv FROM Proizvodjac", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    checkedListBoxProizvodjaci.Items.Add(reader[0].ToString());
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

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            graph.Series[0].Points.Clear();
            if (checkedListBoxProizvodjaci.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBoxProizvodjaci.CheckedItems.Count; i++) 
                {
                    try 
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) 
                                                           FROM Lek AS L JOIN Proizvodjac AS P ON L.proizvodjacID = P.proizvodjacID
                                                           WHERE P.naziv = @proizvodjac;", conn);
                        comm.Parameters.AddWithValue("@proizvodjac", checkedListBoxProizvodjaci.CheckedItems[i].ToString());
                        int br = Convert.ToInt32(comm.ExecuteScalar());
                        graph.Series[0].Points.AddXY(checkedListBoxProizvodjaci.CheckedItems[i].ToString(), br);
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
                MessageBox.Show("Odaberite prozivodjace koje zelite prikazati!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Lek_Prozivodjac f = new Lek_Prozivodjac();
            f.Show();
            this.Hide();
        }
    }
}
