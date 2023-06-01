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
using System.Globalization;


namespace Matura_Zadatak_A25
{
    public partial class IzmenaDatuma : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A25;User ID=SA;Password=sp@sic123.");

        public IzmenaDatuma()
        {
            InitializeComponent();
        }

        private void IzmenaDatuma_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT pacijentID FROM Pacijent", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    cbPacijent.Items.Add(reader[0].ToString());
                }
                reader.Dispose();

                dateTimePickerDate.Value = DateTime.Now;
            }

            catch (Exception errro)
            {
                MessageBox.Show(errro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            {
                conn.Close();
            }
        }

        private void LV_Refresh()
        {
            try
            {
                listViewPregled.Items.Clear();
                if(conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand lv = new SqlCommand(@"SELECT  (SELECT naziv FROM Poliklinika WHERE poliklinikaID=Z.poliklinikaID),
                                                (SELECT ime + ' ' + prezime FROM Lekar WHERE lekarID=Z.lekarID),
                                                datum_zakazivanja,
                                                status
                                                FROM Zakazivanje AS Z
                                                WHERE pacijentID=@id
                                                ORDER BY datum_zakazivanja ASC;", conn);
                lv.Parameters.AddWithValue("@id", cbPacijent.Text);
                SqlDataReader lvreader = lv.ExecuteReader();
                while (lvreader.Read())
                {
                    ListViewItem row = new ListViewItem(lvreader[0].ToString());
                    row.SubItems.Add(lvreader[1].ToString());
                    row.SubItems.Add(Convert.ToDateTime(lvreader[2].ToString()).ToString("dd.MM.yyyy"));
                    row.SubItems.Add(lvreader[3].ToString());
                    listViewPregled.Items.Add(row);
                }
                lvreader.Dispose();
            }

            catch (Exception errro)
            {
                MessageBox.Show(errro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }
        }

        private void btnSrc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbPacijent.Text))
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(@"SELECT ime + ' ' + prezime,adresa + ' , ' + (SELECT grad FROM Grad WHERE gradID=Pacijent.gradID),broj_telefona
                                                    FROM Pacijent
                                                    WHERE pacijentID=@id;", conn);
                    comm.Parameters.AddWithValue("@id", cbPacijent.Text);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        rtbPodaci.Text = "LBO: " + cbPacijent.Text + "\nIme i prezime: " + reader[0].ToString() + "\nAdresa: " + reader[1].ToString() + "\nTelefon: " + reader[2].ToString();
                    }
                    reader.Dispose();
                    LV_Refresh();
                }

                catch (Exception errro)
                {
                    MessageBox.Show(errro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                }
            }

            else
                MessageBox.Show("Unesite ili odaberite LBO pacijenta!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnIzmenaDatuma_Click(object sender, EventArgs e)
        {
            if (DateTime.ParseExact(listViewPregled.SelectedItems[0].SubItems[2].Text, "dd.MM.yyyy", CultureInfo.InvariantCulture) > DateTime.Now)
            {
                try
                {
                    conn.Open();
                    string[] pom = listViewPregled.SelectedItems[0].SubItems[1].Text.Split(' ');
                    string lekarIme = pom[0];
                    string lekarPrezime = pom[1];
                    SqlCommand comm = new SqlCommand(@"UPDATE Zakazivanje 
                                                        SET datum_zakazivanja=@datumNew
                                                        WHERE
                                                        pacijentID=@pacijentID
                                                        AND
                                                        poliklinikaID = (SELECT poliklinikaID FROM Poliklinika WHERE naziv=@poliklinika)
                                                        AND 
                                                        lekarID = (SELECT lekarID FROM Lekar WHERE ime=@lekarIme AND prezime=@lekarPrezime)
                                                        AND
                                                        datum_zakazivanja = @datumOld", conn);
                    comm.Parameters.AddWithValue("@pacijentID", cbPacijent.Text);
                    comm.Parameters.AddWithValue("@datumNew", dateTimePickerDate.Value.ToString("yyyy.MM.dd"));
                    comm.Parameters.AddWithValue("@poliklinika", listViewPregled.SelectedItems[0].SubItems[0].Text);
                    comm.Parameters.AddWithValue("@lekarIme", lekarIme);
                    comm.Parameters.AddWithValue("@lekarPrezime", lekarPrezime);
                    comm.Parameters.AddWithValue("@datumOld", DateTime.ParseExact(listViewPregled.SelectedItems[0].SubItems[2].Text, "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("yyyy.MM.dd"));
                    comm.ExecuteNonQuery();
                }

                catch (Exception errro)
                {
                    MessageBox.Show(errro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                    LV_Refresh();
                }
            }

            else
                MessageBox.Show("Mozete menjati samo predstojece preglede!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnOtkazivanje_Click(object sender, EventArgs e)
        {
            if (DateTime.ParseExact(listViewPregled.SelectedItems[0].SubItems[2].Text, "dd.MM.yyyy", CultureInfo.InvariantCulture) > DateTime.Now) 
            {
                try
                {
                    conn.Open();
                    string[] pom = listViewPregled.SelectedItems[0].SubItems[1].Text.Split(' ');
                    string lekarIme = pom[0];
                    string lekarPrezime = pom[1];
                    SqlCommand comm = new SqlCommand(@"UPDATE Zakazivanje 
                                                        SET status='otkazan'
                                                        WHERE
                                                        pacijentID=@pacijentID
                                                        AND
                                                        poliklinikaID = (SELECT poliklinikaID FROM Poliklinika WHERE naziv=@poliklinika)
                                                        AND 
                                                        lekarID = (SELECT lekarID FROM Lekar WHERE ime=@lekarIme AND prezime=@lekarIme)
                                                        AND
                                                        datum_zakazivanja = @datum", conn);
                    comm.Parameters.AddWithValue("@pacijentID", cbPacijent.Text);
                    comm.Parameters.AddWithValue("@poliklinika", listViewPregled.SelectedItems[0].SubItems[0].Text);
                    comm.Parameters.AddWithValue("@lekarIme", lekarIme);
                    comm.Parameters.AddWithValue("@lekarPrezime", lekarPrezime);
                    comm.Parameters.AddWithValue("@datum", DateTime.ParseExact(listViewPregled.SelectedItems[0].SubItems[2].Text, "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("yyyy.MM.dd"));
                    comm.ExecuteNonQuery();
                }

                catch (Exception errro)
                {
                    MessageBox.Show(errro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                    LV_Refresh();
                }
            }

            else
                MessageBox.Show("Mozete menjati samo predstojece preglede!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ZakaziPregled f = new ZakaziPregled();
            f.Show();
            this.Hide();
        }

        private void cbPacijent_TextChanged(object sender, EventArgs e)
        {
            bool valid = false;
            if (!string.IsNullOrEmpty(cbPacijent.Text))
            {
                for (int i = 0; i < cbPacijent.Items.Count; i++)
                {
                    if (cbPacijent.Items[i].ToString() == cbPacijent.Text)
                    {
                        valid = true;
                        break;
                    }
                }
                if (!valid)
                {
                    MessageBox.Show("Neispravan LBO!", "", MessageBoxButtons.OK);
                    cbPacijent.Text = "";
                }
            }
        }
    }
}
