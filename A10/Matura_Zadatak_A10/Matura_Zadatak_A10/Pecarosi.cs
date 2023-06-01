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
    public partial class Pecarosi : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A10;User ID=SA;Password=sp@sic123.");

        public Pecarosi()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT pecarosID,ime,prezime,adresa,G.grad,telefon 
                                                 FROM Pecaros AS P JOIN Grad AS G ON p.gradID=G.gradID;", conn);
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {

                    listBoxPecarosi.Items.Add(string.Format("{0,5} {1,25} {2,25} {3,30} {4,35} {5,35}", r[0].ToString(), r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString(), r[5].ToString()));
                }
                r.Dispose();
                comm.Dispose();

                SqlCommand comm1 = new SqlCommand(@"SELECT grad FROM Grad", conn);
                SqlDataReader r1 = comm1.ExecuteReader();
                while (r1.Read()) 
                {
                    cbGrad.Items.Add(r1[0].ToString());
                }
                r1.Dispose();
                comm1.Dispose();
                if (!string.IsNullOrEmpty(listBoxPecarosi.Items[0].ToString()))
                {
                    string[] red = listBoxPecarosi.Items[0].ToString().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    tbSifra.Text = red[0];
                    tbIme.Text = red[1];
                    tbPrezime.Text = red[2];
                    tbAdresa.Text = red[3];
                    cbGrad.Text = red[4];
                    tbTelefon.Text = red[5];
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

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand u = new SqlCommand(@"UPDATE Pecaros 
                                                SET ime = @ime,
                                                prezime = @prezime,
                                                adresa = @adresa,
                                                gradID = (SELECT gradID FROM Grad WHERE grad = @grad),
                                                telefon = @telefon
                                                WHERE pecarosID = @id", conn);
                u.Parameters.AddWithValue("@ime", tbIme.Text);
                u.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                u.Parameters.AddWithValue("@adresa", tbAdresa.Text);
                u.Parameters.AddWithValue("@grad", cbGrad.Text);
                u.Parameters.AddWithValue("@telefon", tbTelefon.Text);
                u.Parameters.AddWithValue("@id", tbSifra.Text);
                u.ExecuteNonQuery();
                SqlCommand comm = new SqlCommand(@"SELECT pecarosID,ime,prezime,adresa,G.grad,telefon 
                                                 FROM Pecaros AS P JOIN Grad AS G ON p.gradID=G.gradID;", conn);
                SqlDataReader r = comm.ExecuteReader();
                MessageBox.Show("Uspesan upis", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxPecarosi.Items.Clear();
                while (r.Read())
                {

                    listBoxPecarosi.Items.Add(string.Format("{0,5} {1,25} {2,25} {3,30} {4,35} {5,35}", r[0].ToString(), r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString(), r[5].ToString()));
                }
                r.Dispose();
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

        private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
        {
            Analiza f = new Analiza();
            f.Show();
            this.Hide();
        }

        private void toolStripButtonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputstvo","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxPecarosi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(listBoxPecarosi.SelectedItem.ToString()))
            {
                string[] red = listBoxPecarosi.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                tbSifra.Text = red[0];
                tbIme.Text = red[1];
                tbPrezime.Text = red[2];
                tbAdresa.Text = red[3];
                cbGrad.Text = red[4];
                tbTelefon.Text = red[5];
            }
        }
    }
}
