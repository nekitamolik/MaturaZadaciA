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

namespace Matura_Zadatak_A20
{
    public partial class Uplata : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A20;User ID=SA;Password=sp@sic123.");

        public Uplata()
        {
            InitializeComponent();
            cbDestinacija.Text = "Odaberite destinaciju";
        }

        private void Uplata_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT naziv_mesta,drzava FROM Turisticka_Destinacija", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    cbDestinacija.Items.Add(reader[0].ToString() + ", " + reader[1].ToString());
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

        private void cbDestinacija_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbAranzman.Items.Clear();
                conn.Open();
                string[] destinacija = cbDestinacija.SelectedItem.ToString().Split(new char[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries);
                SqlCommand comm = new SqlCommand(@"SELECT ugovorID,
                                                (SELECT ime+' '+prezime FROM Klijent WHERE klijentID = Turisticki_Aranzman.klijentID) 
                                                FROM Turisticki_Aranzman
                                                WHERE destinacijaID =
                                                (SELECT destinacijaID FROm Turisticka_Destinacija 
                                                WHERE naziv_mesta=@destinacija AND drzava=@drzava);", conn);
                comm.Parameters.AddWithValue("@destinacija",destinacija[0]);
                comm.Parameters.AddWithValue("@drzava", destinacija[1]);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    cbAranzman.Items.Add("(ugovor br." + reader[0].ToString() + ") " + reader[1].ToString());
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

        private void cnAranzman_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string[] cbValue = cbAranzman.SelectedItem.ToString().Split(new char[] { '.', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int ugovorID = Convert.ToInt32(cbValue[2]);

                SqlCommand datumpocetka = new SqlCommand(@"SELECT datum_polaska FROM Turisticki_Aranzman WHERE ugovorID=@id;", conn);
                datumpocetka.Parameters.AddWithValue("@id", ugovorID);
                DateTime datumP = Convert.ToDateTime(datumpocetka.ExecuteScalar());
                SqlCommand datumzavrsetka = new SqlCommand(@"SELECT datum_povratka FROM Turisticki_Aranzman WHERE ugovorID=@id;", conn);
                datumzavrsetka.Parameters.AddWithValue("@id", ugovorID);
                DateTime datumZ = Convert.ToDateTime(datumzavrsetka.ExecuteScalar());
                for (DateTime d = datumP; d <= datumZ; d=d.AddDays(1)) 
                {
                    monthCalendarTrajanje.AddAnnuallyBoldedDate(d);
                }
                monthCalendarTrajanje.SelectionStart = datumP;

                SqlCommand lv = new SqlCommand(@"SELECT rata,iznos,datum_uplate FROM Uplata WHERE ugovorID=@id;", conn);
                lv.Parameters.AddWithValue("@id", ugovorID);
                SqlDataReader lvreader = lv.ExecuteReader();
                while (lvreader.Read())
                {
                    ListViewItem row = new ListViewItem(lvreader[0].ToString());
                    row.SubItems.Add(lvreader[1].ToString());
                    row.SubItems.Add(Convert.ToDateTime(lvreader[2].ToString()).ToShortDateString());
                    listViewUplate.Items.Add(row);
                }
                lvreader.Dispose();
                lv.Dispose();

                SqlCommand iznos = new SqlCommand("SELECT ukupna_cena_aranzmana FROM Turisticki_Aranzman WHERE ugovorID=@id;", conn);
                iznos.Parameters.AddWithValue("@id", ugovorID);
                lblUkCena.Text = iznos.ExecuteScalar().ToString();
                SqlCommand dug = new SqlCommand(@"SELECT ukupna_cena_aranzmana-(SELECT SUM(iznos) FROM Uplata WHERE ugovorID=@id) 
                                                    FROM Turisticki_Aranzman WHERE ugovorID=@id;", conn);
                dug.Parameters.AddWithValue("@id", ugovorID);
                lblDug.Text = Math.Round(Convert.ToDouble(dug.ExecuteScalar()),2).ToString();
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

        private void btnUplati_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbIznos.Text))
                {

                    conn.Open();
                    string[] cbValue = cbAranzman.Text.ToString().Split(new char[] { '.', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int ugovorID = Convert.ToInt32(cbValue[2]);

                    SqlCommand uplata = new SqlCommand(@"INSERT INTO Uplata VALUES
                                                        (@id,@rata,@iznos,@datum);", conn);
                    uplata.Parameters.AddWithValue("@id", ugovorID);
                    uplata.Parameters.AddWithValue("@rata", listViewUplate.Items.Count + 1);
                    uplata.Parameters.AddWithValue("@iznos", tbIznos.Text);
                    uplata.Parameters.AddWithValue("@datum", DateTime.Now);
                    uplata.ExecuteNonQuery();

                    ListViewItem row = new ListViewItem((listViewUplate.Items.Count + 1).ToString());
                    row.SubItems.Add(tbIznos.Text);
                    row.SubItems.Add(DateTime.Now.ToShortDateString());
                    row.ForeColor = Color.Red;
                    listViewUplate.Items.Add(row);

                    SqlCommand dug = new SqlCommand(@"SELECT ukupna_cena_aranzmana-(SELECT SUM(iznos) FROM Uplata WHERE ugovorID=@id) 
                                                    FROM Turisticki_Aranzman WHERE ugovorID=@id;", conn);
                    dug.Parameters.AddWithValue("@id", ugovorID);
                    lblDug.Text = Math.Round(Convert.ToDouble(dug.ExecuteScalar()), 2).ToString();
                    tbIznos.Text = "";
                }

                else
                {
                    MessageBox.Show("Unesite iznos za uplatu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Uplata_FormClosed(object sender, FormClosedEventArgs e)
        {
            Putovanje f = new Putovanje();
            f.Show();
            this.Hide();
        }
    }
}
