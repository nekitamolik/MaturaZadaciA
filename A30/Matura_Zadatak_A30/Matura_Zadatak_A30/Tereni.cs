using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Matura_Zadatak_A30
{
    public partial class Tereni : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A30;User ID=SA;Password=sp@sic123.");

        public Tereni()
        {
            InitializeComponent();
        }

        private void Tereni_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT terenID,(SELECT grad FROM Grad WHERE gradID=Teren.gradID) FROM Teren", conn);
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {
                    cbSifra.Items.Add(r[0].ToString());
                    if (!cbGrad.Items.Contains(r[1].ToString()))
                        cbGrad.Items.Add(r[1].ToString());
                }
                r.Dispose();
                listBoxRefresh();
                listBoxTereni.SelectedIndex = 0;
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

        private void listBoxRefresh()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                listBoxTereni.Items.Clear();
                SqlCommand comm = new SqlCommand("SELECT terenID,teren,adresa,kontakt_telefon,(SELECT grad FROM Grad WHERE gradID=Teren.gradID) FROM Teren;", conn);
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {
                    listBoxTereni.Items.Add(string.Format("{0,5}{1,35}{2,40}{3,55}{4,60}", r[0].ToString(), r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString()));
                }
                r.Dispose();
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

        private void listBoxTereni_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] podaci = listBoxTereni.SelectedItems[0].ToString().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            cbSifra.Text = podaci[0];
            tbNaziv.Text = podaci[1];
            tbAdresa.Text = podaci[2];
            cbGrad.Text = podaci[4];
            tbTel.Text = podaci[3];
        }

        private void cbSifra_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTereni.SelectedIndex = cbSifra.SelectedIndex;
        }

        private void cbSifra_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbSifra.Text))
            {
                if (cbSifra.Items.Contains(cbSifra.Text)) 
                {
                    listBoxTereni.SelectedIndex = Convert.ToInt16(cbSifra.Text) - 1;
                }

                else
                    MessageBox.Show("Neispravna sifra!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("DELETE FROM Teren WHERE terenID=@id", conn);
                comm.Parameters.AddWithValue("@id", cbSifra.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Uspesno izbrisan teren", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        
    }
}
