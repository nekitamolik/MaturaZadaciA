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

namespace Matura_Zadatak_A13
{
    public partial class Producentska_kuca : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A13;User ID=SA;Password=sp@sic123.");

        public Producentska_kuca()
        {
            InitializeComponent();
            ListBox_Refresh();
            if (!string.IsNullOrEmpty(listBoxProducenti.Items[0].ToString()))
            {
                string[] red = listBoxProducenti.Items[0].ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                tbSifra.Text = red[0];
                tbIme.Text = red[1];
                tbEmail.Text = red[2];
            }
        }

        private void ListBox_Refresh() 
        {
            try
            {
                if(conn.State != ConnectionState.Open)
                    conn.Open();
                listBoxProducenti.Items.Clear();
                SqlCommand comm = new SqlCommand(@"SELECT producentID,ime,email FROM Producent", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    listBoxProducenti.Items.Add(string.Format("{0,20}{1,50}{2,30}", reader[0].ToString(), reader[1].ToString(), reader[2].ToString()));
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

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbSifra.Text))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(@"UPDATE Producent 
                                                SET ime = @ime, email=@mail
                                                WHERE producentID=@id;", conn);
                    comm.Parameters.AddWithValue("@id", tbSifra.Text);
                    comm.Parameters.AddWithValue("@ime", tbIme.Text);
                    comm.Parameters.AddWithValue("@mail", tbEmail.Text);
                    comm.ExecuteNonQuery();
                    ListBox_Refresh();
                    MessageBox.Show("Uspesan upis!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
        {
            Analiza f = new Analiza();
            f.Show();
            this.Hide();
        }

        private void toolStripButtonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputstvo", "Uputstvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxProducenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(listBoxProducenti.SelectedItem.ToString()))
            {
                string[] red = listBoxProducenti.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                tbSifra.Text = red[0];
                tbIme.Text = red[1];
                tbEmail.Text = red[2];
            }
        }
    }
}
