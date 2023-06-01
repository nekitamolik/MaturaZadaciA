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

namespace Matura_Zadatak_A7
{
    public partial class DeleteForm : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A7;User ID=SA;Password=sp@sic123.");

        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            GV_Refresh();
        }

        private void GV_Refresh() 
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select predmetID,sifra_predmeta,predmet,semestar,opis FROM Predmet;", conn);
                DataTable GV_tabela = new DataTable();
                if (adapter != null)
                {
                    adapter.Fill(GV_tabela);
                    GV.DataSource = GV_tabela;
                    GV.Refresh();
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            {
                conn.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (GV.SelectedRows[0].Cells[0].Value.ToString() != null)
                {
                    SqlCommand del = new SqlCommand(@"DELETE FROM Predmet WHERE predmetID = @id;", conn);
                    del.Parameters.AddWithValue("@id", GV.SelectedRows[0].Cells[0].Value.ToString());
                    del.ExecuteNonQuery();
                }
                else 
                {
                    MessageBox.Show("Morate odabrati predmet koji zelite izbrisati", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            {
                conn.Close();
                GV_Refresh();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Komunikacija f = new Komunikacija();
            f.Show();
            this.Hide();
        }

        private void GV_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected) 
            {
                if (GV.SelectedRows.Count != 0)
                {
                    tbID.Text = GV.SelectedRows[0].Cells[0].Value.ToString();
                    tbSifra.Text = GV.SelectedRows[0].Cells[1].Value.ToString();
                    tbPredmet.Text = GV.SelectedRows[0].Cells[2].Value.ToString();
                    tbSemestar.Text = GV.SelectedRows[0].Cells[3].Value.ToString();
                    tbOpis.Text = GV.SelectedRows[0].Cells[4].Value.ToString();
                }
            }
        }
    }
}
