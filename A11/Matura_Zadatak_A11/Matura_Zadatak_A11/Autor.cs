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
    public partial class Autor : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A11;User ID=SA;Password=sp@sic123.");        

        public Autor()
        {
            InitializeComponent();
            btnOdustani.Enabled = false;
            btnUpisi.Enabled = false;
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT autorID, ime,prezime,datum_rodjenja FROM Autor", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    listBoxAutori.Items.Add(string.Format("{0,20}{1,30}{2,40}{3,60}", reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), (Convert.ToDateTime(reader[3].ToString())).ToShortDateString()));
                }
                reader.Dispose();
                comm.Dispose();
                if (!string.IsNullOrEmpty(listBoxAutori.Items[0].ToString()))
                {
                    string[] red = listBoxAutori.Items[0].ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    tbSifra.Text = red[0];
                    tbIme.Text = red[1];
                    tbPrezime.Text = red[2];
                    dateTimePickerDatumRodjenja.Value = Convert.ToDateTime(red[3]);
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
            MessageBox.Show("Uputstvo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnOdustani.Enabled = true;
            btnUpisi.Enabled = true;
            tbSifra.Enabled = false;
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                if (!string.IsNullOrEmpty(tbPrezime.Text) && !string.IsNullOrEmpty(tbIme.Text) && dateTimePickerDatumRodjenja.Value.ToString() != null)
                {
                    SqlCommand upis = new SqlCommand(@"INSERT INTO Autor VALUES (@ime,@prezime,@datum);", conn);
                    upis.Parameters.AddWithValue("@ime", tbIme.Text);
                    upis.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                    upis.Parameters.AddWithValue("@datum", dateTimePickerDatumRodjenja.Value.ToShortDateString());
                    upis.ExecuteNonQuery();
                    MessageBox.Show("Uspesan upis", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBoxAutori.Items.Clear();
                    SqlCommand comm = new SqlCommand(@"SELECT autorID, ime,prezime,datum_rodjenja FROM Autor", conn);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        listBoxAutori.Items.Add(string.Format("{0,20}{1,30}{2,40}{3,60}", reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), (Convert.ToDateTime(reader[3].ToString())).ToShortDateString()));
                    }
                    reader.Dispose();
                    comm.Dispose();
                }
                else 
                {
                    MessageBox.Show("Unesite obavezna polja", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
             
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
                btnOdustani.Enabled = false;
                btnUpisi.Enabled = false;
                tbSifra.Enabled = true;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            btnOdustani.Enabled = false;
            btnUpisi.Enabled = false;
            tbSifra.Enabled = true;
        }

        private void listBoxAutori_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] red = listBoxAutori.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            tbSifra.Text = red[0];
            tbIme.Text = red[1];
            tbPrezime.Text = red[2];
            dateTimePickerDatumRodjenja.Value = Convert.ToDateTime(red[3]);
        }

        private void tbSifra_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSifra.Text))
                for (int i = 0; i < listBoxAutori.Items.Count; i++)
                {
                    string[] red = listBoxAutori.Items[i].ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (red[0] == tbSifra.Text)
                    {
                        tbIme.Text = red[1];
                        tbPrezime.Text = red[2];
                        dateTimePickerDatumRodjenja.Value = Convert.ToDateTime(red[3]);
                    }
                    
                }
            else
            {
                tbIme.Text = "";
                tbPrezime.Text = "";
            }
        }
    }
}
