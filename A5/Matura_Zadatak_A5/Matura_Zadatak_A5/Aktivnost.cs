using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Matura_Zadatak_A5
{
    public partial class Aktivnost : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A5;User ID=SA;Password=sp@sic123.");

        public Aktivnost()
        {
            InitializeComponent();
        }

        private void Aktivnost_Load(object sender, EventArgs e)
        {
            cbDanUNedelji.Items.Add("Ponedeljak");
            cbDanUNedelji.Items.Add("Utorak");
            cbDanUNedelji.Items.Add("Sreda");
            cbDanUNedelji.Items.Add("Cetvrtak");
            cbDanUNedelji.Items.Add("Petak");
            cbDanUNedelji.Items.Add("Subota");
            cbDanUNedelji.Items.Add("Nedelja");
            ListView_Refresh(); 
        }

        private void ListView_Refresh() 
        {
            try 
            {
                conn.Open();
                listViewAktivnosti.Items.Clear();
                SqlCommand comm = new SqlCommand(@" SELECT * FROM Aktivnosti;", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    ListViewItem row = new ListViewItem(reader[0].ToString()); 
                    row.SubItems.Add(reader[1].ToString());
                    row.SubItems.Add(reader[2].ToString());
                    row.SubItems.Add(reader[3].ToString().Substring(0,5));
                    row.SubItems.Add(reader[4].ToString().Substring(0,5));
                    listViewAktivnosti.Items.Add(row);
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

        private void toolStripButtonStatistika_Click(object sender, EventArgs e)
        {
            Statistika f = new Statistika();
            f.Show();
            this.Hide();
        }

        private void toolStripLabelInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputstvo", "Korisnicko Uputsvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNaziv.Text) && !listViewAktivnosti.Items.ContainsKey(tbSifra.Text))
            {
                try
                {
                    conn.Open();
                    int id = listViewAktivnosti.Items.Count;
                    SqlCommand comm = new SqlCommand(@"INSERT INTO Aktivnosti (aktivnostID,naziv_aktivnosti,dan,pocetak,zavrsetak) VALUES
                                                (@aktivnostID,@naziv,@dan,@vreme_p,@vreme_z);", conn);
                    if (string.IsNullOrEmpty(tbVremePocetka.Text)) 
                    {
                        comm.Parameters.AddWithValue("@vreme_p", "00:00");
                    }
                    else
                        comm.Parameters.AddWithValue("@vreme_p", tbVremePocetka.Text);
                    if (string.IsNullOrEmpty(tbVremeZavrsetka.Text))
                    {
                        comm.Parameters.AddWithValue("@vreme_z","00:01");
                    }
                    else
                        comm.Parameters.AddWithValue("@vreme_z", tbVremeZavrsetka.Text);
                    comm.Parameters.AddWithValue("@aktivnostID", tbSifra.Text);
                    comm.Parameters.AddWithValue("@naziv", tbNaziv.Text);
                    comm.Parameters.AddWithValue("@dan", cbDanUNedelji.Text);
                    comm.ExecuteNonQuery();
                }

                catch (Exception error)
                {
                    MessageBox.Show("Ovde" + error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                    ListView_Refresh();
                }
            }
            
            else 
            {
                MessageBox.Show("Morate uneti unikatnu sifru, takodje morate nazvati vasu aktivnost", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listViewAktivnosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAktivnosti.SelectedItems.Count != 0)
            {
                tbSifra.Text = listViewAktivnosti.SelectedItems[0].Text;
                tbNaziv.Text = listViewAktivnosti.SelectedItems[0].SubItems[1].Text;
                cbDanUNedelji.Text = listViewAktivnosti.SelectedItems[0].SubItems[2].Text;
                tbVremePocetka.Text = listViewAktivnosti.SelectedItems[0].SubItems[3].Text;
                tbVremeZavrsetka.Text = listViewAktivnosti.SelectedItems[0].SubItems[4].Text;
            }
        }
    }
}
