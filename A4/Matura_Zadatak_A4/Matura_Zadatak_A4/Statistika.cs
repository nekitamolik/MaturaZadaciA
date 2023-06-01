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

namespace Matura_Zadatak_A4
{
    public partial class Statistika : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A4;User ID=SA;Password=sp@sic123.");

        public Statistika()
        {
            InitializeComponent();
        }

        private void Vauceri_Load(object sender, EventArgs e)
        {
            GV_Refresh();
        }

        private void GV_Refresh() 
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT ime + ' ' + prezime AS Ime ,
                                                (SELECT COUNT(*) FROM Rezervacija WHERE Rezervacija.klijentID = Klijent.klijentID) AS Broj
                                                FROM Klijent
                                                WHERE aktivan_klijent = 'TRUE' AND 
                                                (SELECT COUNT(*) FROM Rezervacija WHERE Rezervacija.klijentID = Klijent.klijentID) >= @broj;", conn);
                comm.Parameters.AddWithValue("@broj", numericUpDownBrojAranzmana.Value);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable GV_tabela = new DataTable();
                if (adapter != null)
                {
                    adapter.Fill(GV_tabela);
                    GV.DataSource = GV_tabela;
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

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            GV_Refresh();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Sela f = new Sela();
            f.Show();
            this.Hide();
        }

        private void Statistika_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sela f = new Sela();
            f.Show();
            this.Hide();
        }


    }
}
