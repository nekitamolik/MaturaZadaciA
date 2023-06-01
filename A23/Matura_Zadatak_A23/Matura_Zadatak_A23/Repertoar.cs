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

namespace Matura_Zadatak_A23
{
    public partial class Repertoar : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A23;User ID=SA;Password=sp@sic123.");

        public Repertoar()
        {
            InitializeComponent();
            numericUpDownBrmesta.Minimum = 1;
            monthCalendarObseg.Visible = false;
            monthCalendarObseg.SelectionStart = DateTime.Now;
            cbKomad.Text = "Izaberi komad";
        }

        private void Repertoar_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (Logovanje.logovan)
                {
                    btnPrijava.Enabled = false;
                    this.Text += "-Registrovani Korisnik";
                    string ime = "";
                    SqlCommand comm = new SqlCommand(@"SELECT ime + ' ' + prezime FROM Pretplatnik WHERE pretplatnikID=@id", conn);
                    comm.Parameters.AddWithValue("@id", Logovanje.korisnikID);
                    ime = comm.ExecuteScalar().ToString();
                    lblPretplatnik.Text = ime + "\n(id: " + Logovanje.korisnikID + ")";
                }

                else
                {
                    this.Text += "-Neregistrovani Korisnik";
                    btnRezervacija.Enabled = false;
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

        private void btnRepertoar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (string.IsNullOrEmpty(tbDate.Text) && cbKomad.Text == "Izaberi komad")
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT komadID AS KomadID,
                                                                (SELECT naziv FROM Pozorisni_Komad WHERE komadID=P.komadID) AS Naziv,
                                                                datum AS Datum,
                                                                (SELECT naziv FROM Pozorisna_Trupa WHERE trupaID=p.trupaID) AS 'Naziv Trupe'
                                                                FROM Predstava AS P
                                                                WHERE datum>=GETDATE()
                                                                ORDER BY datum ASC;", conn);
                    if (adapter != null)
                    {
                        DataTable gv_tabela = new DataTable();
                        adapter.Fill(gv_tabela);
                        foreach (DataRow row in gv_tabela.Rows)
                            row[2] = Convert.ToDateTime(row[2]).ToShortDateString();
                        conn.Close();
                        GV.DataSource = gv_tabela;
                        GV.Refresh();
                    }
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

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Logovanje f = new Logovanje();
            f.Show();
            this.Hide();
        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            if (GV.SelectedRows.Count == 1)
            {
                int broj = Convert.ToInt16(numericUpDownBrmesta.Value);
                double cena = Convert.ToDouble(lblCena.Text);
                double iznos = Math.Round(broj * cena, 3);

                DialogResult r = MessageBox.Show("Ovim se slazete sa kupovinom:\nBroj karata " + numericUpDownBrmesta.Value + "\n Iznos za placanje: " + iznos, "PAZNJA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(@"INSERT INTO Rezervacija VALUES (@datum_rezervacije,@pretplatnikID,@komadID,@datum_izvodjenja,@broj_mesta)", conn);
                        comm.Parameters.AddWithValue("@datum_rezervacije", DateTime.Now.ToString("yyyy.MM.dd"));
                        comm.Parameters.AddWithValue("@pretplatnikID", Logovanje.korisnikID);
                        comm.Parameters.AddWithValue("@komadID", GV.SelectedRows[0].Cells[0].Value);
                        comm.Parameters.AddWithValue("@datum_izvodjenja", Convert.ToDateTime(GV.SelectedRows[0].Cells[2].Value).ToString("yyyy.MM.dd"));
                        comm.Parameters.AddWithValue("@broj_mesta", numericUpDownBrmesta.Value);
                        comm.ExecuteNonQuery();
                        lblUplata.Text = iznos.ToString();
                        MessageBox.Show("Uspesna rezervacija!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            else
            {
                MessageBox.Show("Morate odabrati predstavu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Pozoriste f = new Pozoriste();
            if (Logovanje.logovan)
                f.Text = "Pozoriste-Registrovani Korisnik";
            else
                f.Text = "Pozoriste-Neregistrovani Korisnik";
            f.Show();
            this.Hide();
        }

        private void tbDate_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendarObseg.Visible = true;
        }

        private void monthCalendarObseg_Leave(object sender, EventArgs e)
        {
            if (monthCalendarObseg.Visible)
            {
                try
                {
                    monthCalendarObseg.Visible = false;
                    cbKomad.Items.Clear();
                    DateTime pocetak = monthCalendarObseg.SelectionStart;
                    DateTime kraj = monthCalendarObseg.SelectionEnd;
                    tbDate.Text = "od " + pocetak.ToString("dd.MM.yyyy") + " do " + kraj.ToString("dd.MM.yyyy");
                    conn.Open();
                    SqlCommand comm = new SqlCommand(@"SELECT (SELECT naziv FROM Pozorisni_Komad WHERE komadID=P.komadID) FROM Predstava AS P WHERE datum BETWEEN @pocetak AND @kraj;", conn);
                    comm.Parameters.AddWithValue("@pocetak", pocetak.ToString("yyyy.MM.dd"));
                    comm.Parameters.AddWithValue("@kraj", kraj.ToString("yyyy.MM.dd"));
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        cbKomad.Items.Add(reader[0].ToString());
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

        private void cbKomad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT komadID AS KomadID,
                                                (SELECT naziv FROM Pozorisni_Komad WHERE komadID=P.komadID) AS Naziv,
                                                datum AS Datum,
                                                (SELECT naziv FROM Pozorisna_Trupa WHERE trupaID=p.trupaID) AS 'Naziv Trupe'
                                                FROM Predstava AS P
                                                WHERE datum BETWEEN @pocetak AND @kraj
                                                AND
                                                komadID = (SELECT komadID FROM Pozorisni_Komad WHERE naziv=@komad)
                                                ORDER BY datum ASC;", conn);
                comm.Parameters.AddWithValue("@pocetak", monthCalendarObseg.SelectionStart);
                comm.Parameters.AddWithValue("@kraj", monthCalendarObseg.SelectionEnd);
                comm.Parameters.AddWithValue("@komad", cbKomad.SelectedItem);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                if (adapter != null)
                {
                    DataTable gv_tabela = new DataTable();
                    adapter.Fill(gv_tabela);
                    conn.Close();
                    foreach (DataRow row in gv_tabela.Rows)
                        row[2] = Convert.ToDateTime(row[2]).ToShortDateString();
                    GV.DataSource = gv_tabela;
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

        private void GV_SelectionChanged(object sender, EventArgs e)
        {
            if (GV.SelectedRows.Count == 1)
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(@"SELECT cena_karte FROM Predstava WHERE komadID=@id AND datum=@datum", conn);
                    comm.Parameters.AddWithValue("@id", GV.SelectedRows[0].Cells[0].Value);
                    comm.Parameters.AddWithValue("@datum", GV.SelectedRows[0].Cells[2].Value);
                    lblCena.Text = comm.ExecuteScalar().ToString();

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
    }
}
