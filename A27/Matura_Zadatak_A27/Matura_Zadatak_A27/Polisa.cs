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

namespace Matura_Zadatak_A27
{
    public partial class Polisa : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A27;User ID=SA;Password=sp@sic123.");

        public Polisa()
        {
            InitializeComponent();
            numericUpDownDani.Value = 7;
            numericUpDownDani.Minimum = 1;
            lbldatum.Text = "Datum: " + DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                listViewPolise.Items.Clear();
                SqlCommand comm = new SqlCommand(@"SELECT 
                                                (SELECT ime FROM Vozac WHERE vozacID = (SELECT vozacID FROM Vozilo_Vozac WHERE voziloID=Vozilo.voziloID )),
                                                (SELECT prezime FROM Vozac WHERE vozacID = (SELECT vozacID FROM Vozilo_Vozac WHERE voziloID=Vozilo.voziloID )),
                                                (SELECT naziv FROM Model WHERE modelID = Vozilo.modelID),
                                                (SELECT naziv FROM Proizvodjac WHERE proizvodjacID=(SELECT proizvodjacID FROM Model WHERE modelID = Vozilo.modelID)),
                                                registarski_broj,
                                                polisaID,
                                                (SELECT datum_pocetka FROM Polisa WHERE polisaID=Vozilo.polisaID),
                                                (SELECT datum_zavrsetka FROM Polisa WHERE polisaID=Vozilo.polisaID)
                                                FROM Vozilo 
                                                WHERE polisaID IN (SELECT polisaID FROM Polisa WHERE datum_zavrsetka BETWEEN GETDATE() AND @datum);", conn);
                comm.Parameters.AddWithValue(@"datum", DateTime.Now.AddDays(Convert.ToInt16(numericUpDownDani.Value)));
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem row = new ListViewItem(reader[0].ToString());
                    row.SubItems.Add(reader[1].ToString());
                    row.SubItems.Add(reader[2].ToString());
                    row.SubItems.Add(reader[3].ToString());
                    row.SubItems.Add(reader[4].ToString());
                    row.SubItems.Add(reader[5].ToString());
                    row.SubItems.Add(Convert.ToDateTime(reader[6].ToString()).ToString("dd.MM.yyyy"));
                    row.SubItems.Add(Convert.ToDateTime(reader[7].ToString()).ToString("dd.MM.yyyy"));
                    listViewPolise.Items.Add(row);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Osiguranje f = new Osiguranje();
            f.Show();
            this.Hide();
        }

        private void Polisa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Osiguranje f = new Osiguranje();
            f.Show();
            this.Hide();
        }

        
    }
}
