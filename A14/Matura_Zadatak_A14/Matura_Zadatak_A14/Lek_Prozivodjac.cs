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
    public partial class Lek_Prozivodjac : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A14;User ID=SA;Password=sp@sic123.");

        public Lek_Prozivodjac()
        {
            InitializeComponent();
            GV_Refresh();
            tbNazivLeka.Text = GV.Rows[0].Cells[2].Value.ToString();
            tbProizvodjac.Text = GV.Rows[0].Cells[4].Value.ToString();
        }


        private void GV_Refresh() 
        {
            try
            {
                if(conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT lekID,L.proizvodjacID,naziv_leka,nezasticeno_ime,P.naziv
                                                            FROM Lek AS L JOIN Proizvodjac AS P ON L.proizvodjacID = P.proizvodjacID
                                                            ORDER BY naziv_leka", conn);
                if (adapter != null)
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    GV.DataSource = tabela;
                    GV.Refresh();
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


        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani lek?\n Portvrdite brisanje leka!", "Brisanje leka iz evidencije", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(@"DELETE FROM Lek 
                                                       WHERE naziv_leka=@ime
                                                       AND proizvodjacID = (SELECT proizvodjacID FROM Proizvodjac WHERE naziv =@pime);", conn);
                    comm.Parameters.AddWithValue("@ime", tbNazivLeka.Text);
                    comm.Parameters.AddWithValue("@pime", tbProizvodjac.Text);
                    comm.ExecuteNonQuery();
                    GV_Refresh();
                    MessageBox.Show("Lek je uspesno izbrisan", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
        {
            Analiza f = new Analiza();
            f.Show();
            this.Hide();
        }

        private void toolStripButtonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputsvo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GV_SelectionChanged(object sender, EventArgs e)
        {
            if (GV.SelectedRows.Count > 0)
            {
                tbNazivLeka.Text = GV.SelectedRows[0].Cells[2].Value.ToString();
                tbProizvodjac.Text = GV.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        
    }
}
