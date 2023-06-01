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

namespace Matura_Zadatak_A11
{
    public partial class Analiza : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A11;User ID=SA;Password=sp@sic123.");        

        public Analiza()
        {
            InitializeComponent();
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT  ime,prezime FROM Autor ORDER BY ime ASC , prezime ASC", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    checkedListBoxAutori.Items.Add(reader[0] + " " + reader[1], CheckState.Unchecked);
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
            try
            {
                conn.Open();
                graph.Series[0].Points.Clear();
                if (checkedListBoxAutori.CheckedItems.Count >= 2)
                {
                    for (int i = 0; i < checkedListBoxAutori.CheckedItems.Count; i++)
                    {
                        string[] cb = checkedListBoxAutori.CheckedItems[i].ToString().Split(' ');
                        string ime = cb[0];
                        string prezime = cb[1];
                        SqlCommand comm = new SqlCommand(@"SELECT SUM(broj_izdanja) FROM Autor_Izdanje
                                                        WHERE autorID = (SELECT autorID FROM Autor WHERE ime=@ime AND prezime = @prezime);", conn);
                        comm.Parameters.AddWithValue("@ime", ime);
                        comm.Parameters.AddWithValue("@prezime", prezime);
                        int br = Convert.ToInt32(comm.ExecuteScalar());
                        graph.Series[0].Points.AddXY(ime + " " + prezime, br);
                    }
                }

                else
                {
                    MessageBox.Show("Morate odabrati najmanje 2 autora za pregled", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            graph.Series[0].Points.Clear();
            for (int i = 0; i < checkedListBoxAutori.Items.Count; i++)
                checkedListBoxAutori.SetItemChecked(i, false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Autor f = new Autor();
            f.Show();
            this.Hide();
        }

        
    }
}
