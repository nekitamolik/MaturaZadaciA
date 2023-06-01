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
    public partial class Pregled : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A20;User ID=SA;Password=sp@sic123.");

        public Pregled()
        {
            InitializeComponent();
        }

        private void Pregled_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                DateTime datumP = DateTime.Now, datumZ=DateTime.Now.AddDays(15);
                SqlCommand comm = new SqlCommand(@"SELECT ugovorID,
                                                (SELECT ime FROM Klijent WHERE klijentID=TA.klijentID),
                                                (SELECT prezime FROM Klijent WHERE klijentID=TA.klijentID),
                                                (SELECT naziv_mesta FROM Turisticka_Destinacija WHERE destinacijaID=TA.destinacijaID),
                                                datum_polaska,ukupna_cena_aranzmana,
                                                (SELECT SUM(iznos) FROM Uplata WHERE ugovorID=TA.ugovorID),
                                                ukupna_cena_aranzmana-(SELECT SUM(iznos) FROM Uplata WHERE ugovorID=Ta.ugovorID)
                                                FROM Turisticki_Aranzman AS TA
                                                WHERE datum_polaska BETWEEN @datumP AND @datumZ;", conn);
                comm.Parameters.AddWithValue("@datumP", datumP);
                comm.Parameters.AddWithValue("@datumZ", datumZ);
                SqlDataReader reader = comm.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Columns.Add("Ugovor ID", typeof(string));
                tabela.Columns.Add("Ime", typeof(string));
                tabela.Columns.Add("Prezime", typeof(string));
                tabela.Columns.Add("Destinacija", typeof(string));
                tabela.Columns.Add("Polazak", typeof(string));
                tabela.Columns.Add("Cena", typeof(string));
                tabela.Columns.Add("Placeno", typeof(string));
                tabela.Columns.Add("Dugovanje", typeof(string));
                while (reader.Read()) 
                {
                    DataRow row = tabela.NewRow();
                    row[0] = reader[0].ToString();
                    row[1] = reader[1].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[3].ToString();
                    row[4] = Convert.ToDateTime(reader[4].ToString()).ToString("dd/MM/yyyy");
                    row[5] = Math.Round(Convert.ToDouble(reader[5].ToString()), 2);
                    row[6] = Math.Round(Convert.ToDouble(reader[6].ToString()),2);
                    row[7] = Math.Round(Convert.ToDouble(reader[7].ToString()), 2);
                    tabela.Rows.Add(row);
                }
                reader.Dispose();
                comm.Dispose();
                if (tabela.Rows.Count > 0)
                {
                    GV.DataSource = tabela;
                    GV.Refresh();
                    foreach (DataGridViewRow row in GV.Rows)
                    {
                        if (Convert.ToDouble(row.Cells[7].Value) >= 0)
                            row.Cells[7].Style.BackColor = Color.PaleGreen;
                        else
                            row.Cells[7].Style.BackColor = Color.IndianRed;
                    }
                }
                lblDatum.Text = "(Polasci od " + datumP.ToString("dd/MM/yyyy") + " do " + datumZ.ToString("dd/MM/yyyy") + ")";
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

        private void Pregled_FormClosed(object sender, FormClosedEventArgs e)
        {
            Putovanje f = new Putovanje();
            f.Show();
            this.Hide();
        }
    }
}
