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

namespace Matura_Zadatak_A3
{
    public partial class Statistika : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=192.168.0.20;Initial Catalog=A3;User ID=SA;Password=sp@sic123.");
        public Statistika()
        {
            InitializeComponent();
        }

        private void Statistika_Load(object sender, EventArgs e)
        {
            Refresh_form();
        }

        private void Statistika_FormClosing(object sender, FormClosingEventArgs e)
        {
            Projekat f = new Projekat();
            f.Show();
            this.Hide();
        }

        private void Refresh_form() 
        {
            try
            {
                conn.Open();
                int godine_starosti = Convert.ToInt32(numericUpDownGodineStarostiProjekta.Value);
                DataTable GV_tabela = new DataTable();
                GV_tabela.Columns.Add("Godina", typeof(int));
                GV_tabela.Columns.Add("Broj Projekata", typeof(int));
                GV_tabela.Columns.Add("Broj Radnika", typeof(int));
                for (int i = DateTime.Now.Year - godine_starosti; i < DateTime.Now.Year; i++) 
                {
                    DataRow row = GV_tabela.NewRow();
                    row[0] = i;
                    SqlCommand br_projekta = new SqlCommand("SELECT COUNT(projekatID) FROM Projekat WHERE YEAR(datum_pocetka) = @godina;", conn);
                    br_projekta.Parameters.AddWithValue("@godina", i);
                    row[1] = br_projekta.ExecuteScalar();
                    SqlCommand br_radnika = new SqlCommand(@"SELECT ISNULL(COUNT(radnikID),0)
                                                             FROM Angazman AS A JOIN Projekat AS P 
                                                             ON A.projekatID=P.projekatID
                                                             WHERE YEAR(P.datum_pocetka) = @godina ;", conn);
                    br_radnika.Parameters.AddWithValue("@godina", i);
                    row[2] = br_radnika.ExecuteScalar();
                    GV_tabela.Rows.Add(row);
                }
                if (GV_tabela != null)
                {
                    GV.DataSource = GV_tabela;
                    GV.Refresh();

                    ChartProjekat.Series[0].Points.Clear();

                    for (int i = 0; i < GV_tabela.Rows.Count; i++)
                        ChartProjekat.Series[0].Points.AddXY(GV_tabela.Rows[i][0].ToString(), GV_tabela.Rows[i][2].ToString());

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

        private void numericUpDownGodineStarostiProjekta_ValueChanged(object sender, EventArgs e)
        {
            Refresh_form();
        }

        
    }
}
