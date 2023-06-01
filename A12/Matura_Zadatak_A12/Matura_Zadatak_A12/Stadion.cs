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

namespace Matura_Zadatak_A12
{
    public partial class Stadion : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A12;User ID=SA;Password=sp@sic123.");
        public static Stadion instanca;

        public Stadion()
        {
            instanca = this;
            InitializeComponent();
            try 
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT grad FROM Grad;", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    cbGrad.Items.Add(reader[0].ToString());
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
                numericUpDownBrojUlaza.Minimum = 1;
                numericUpDownBrojUlaza.Maximum = 150;
                numericUpDownKapacitet.Maximum = 1000000;
                LV_Refresh();
            }
            
        }

        public void LV_Refresh() 
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                listViewStadioni.Items.Clear();
                SqlCommand comm = new SqlCommand(@"SELECT stadionID,naziv,adresa,kapacitet,broj_ulaza,G.grad 
                                                   FROM Stadion AS S JOIN Grad AS G
                                                   ON S.gradID = G.gradID;", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    ListViewItem row = new ListViewItem(reader[0].ToString());
                    row.SubItems.Add(reader[1].ToString());
                    row.SubItems.Add(reader[2].ToString());
                    row.SubItems.Add(reader[3].ToString());
                    row.SubItems.Add(reader[4].ToString());
                    row.SubItems.Add(reader[5].ToString());
                    listViewStadioni.Items.Add(row);
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

        public void Src(string drzava) 
        {
            if (!string.IsNullOrEmpty(drzava))
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    listViewStadioni.Items.Clear();
                    SqlCommand comm = new SqlCommand(@"SELECT stadionID,naziv,adresa,kapacitet,broj_ulaza,G.grad 
                                                        FROM Stadion AS S JOIN Grad AS G
                                                        ON S.gradID = G.gradID
                                                        WHERE G.gradID IN (SELECT gradID FROM Grad WHERE drzavaID = 
                                                        (SELECT drzavaID FROM Drzava WHERE naziv = @drzava));", conn);
                    comm.Parameters.AddWithValue("@drzava", drzava);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem row = new ListViewItem(reader[0].ToString());
                        row.SubItems.Add(reader[1].ToString());
                        row.SubItems.Add(reader[2].ToString());
                        row.SubItems.Add(reader[3].ToString());
                        row.SubItems.Add(reader[4].ToString());
                        row.SubItems.Add(reader[5].ToString());
                        listViewStadioni.Items.Add(row);
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
        }

        private void btnSrc_Click(object sender, EventArgs e)
        {
            Filter f =  new Filter();
            f.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                SqlCommand update = new SqlCommand(@"UPDATE Stadion SET
                                                    naziv = @naziv,
                                                    adresa = @adresa,
                                                    kapacitet=@kapacitet,
                                                    broj_ulaza=@broj_ulaza,
                                                    gradID = (SELECT gradID FROM Grad WHERE grad=@grad)
                                                    WHERE stadionID = @id;", conn);
                update.Parameters.AddWithValue("@id", tbSifra.Text);
                update.Parameters.AddWithValue("@naziv", tbNaziv.Text);
                update.Parameters.AddWithValue("@adresa", tbAdresa.Text);
                update.Parameters.AddWithValue("@kapacitet", numericUpDownKapacitet.Value);
                update.Parameters.AddWithValue("@broj_ulaza", numericUpDownBrojUlaza.Value);
                update.Parameters.AddWithValue("@grad", cbGrad.Text);
                update.ExecuteNonQuery();
                LV_Refresh();
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

        private void btnGraph_Click(object sender, EventArgs e)
        {
            Statistika f = new Statistika();
            f.Show();
            this.Hide();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputsvo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listViewStadioni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStadioni.SelectedIndices.Count != 0) 
            {
                tbSifra.Text = listViewStadioni.SelectedItems[0].SubItems[0].Text;
                tbNaziv.Text = listViewStadioni.SelectedItems[0].SubItems[1].Text;
                tbAdresa.Text = listViewStadioni.SelectedItems[0].SubItems[2].Text;
                numericUpDownKapacitet.Value = Convert.ToInt32(listViewStadioni.SelectedItems[0].SubItems[3].Text);
                numericUpDownBrojUlaza.Value = Convert.ToInt32(listViewStadioni.SelectedItems[0].SubItems[4].Text);
                cbGrad.Text = listViewStadioni.SelectedItems[0].SubItems[5].Text;
            }
        }
    }
}
