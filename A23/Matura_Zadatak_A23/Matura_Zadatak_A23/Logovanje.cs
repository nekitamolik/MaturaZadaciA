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
    public partial class Logovanje : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A23;User ID=SA;Password=sp@sic123.");

        public static bool logovan = false;
        public static int korisnikID = 0;

        public Logovanje()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrEmpty(tbPSW.Text))
                {
                    SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) FROM Pretplatnik WHERE pretplatnikID=@id AND lozinka=@psw;", conn);
                    comm.Parameters.AddWithValue("@id", tbID.Text);
                    comm.Parameters.AddWithValue("@psw", tbPSW.Text);
                    int exists = Convert.ToInt16(comm.ExecuteScalar());
                    if (exists == 1)
                    {
                        logovan = true;
                        korisnikID = Convert.ToInt16(tbID.Text);
                        Pozoriste f = new Pozoriste();
                        f.Text = "Pozoriste-Registrovani Korisnik";
                        f.Show();
                        this.Hide();
                    }

                    else
                        lblError.Text = "Pogresan ID ili lozinka!";
                }

                else
                   lblError.Text = "Morate popuniti oba polja za prijavu!";
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
            Pozoriste f = new Pozoriste();
            f.Show();
            this.Hide();
        }
    }
}
