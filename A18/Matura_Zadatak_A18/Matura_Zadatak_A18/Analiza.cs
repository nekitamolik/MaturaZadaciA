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

namespace Matura_Zadatak_A18
{
    public partial class Analiza : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A17;User ID=SA;Password=sp@sic123.");


        public Analiza()
        {
            InitializeComponent();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMin.Text) && !string.IsNullOrEmpty(tbMax.Text))
            {
                try
                {
                    graph.Series[0].Points.Clear();
                    conn.Open();
                    SqlCommand comm = new SqlCommand(@"SELECT voziloID,registracija,godina_proizvodnje,predjeno_km,cena
                                                        FROM Vozilo AS V
                                                        WHERE cena BETWEEN @min AND @max;", conn);
                    comm.Parameters.AddWithValue("@min", tbMin.Text);
                    comm.Parameters.AddWithValue("@max", tbMax.Text);
                    SqlDataReader reader = comm.ExecuteReader();
                    DataTable tabela = new DataTable();
                    tabela.Columns.Add("Vozilo ID", typeof(string));
                    tabela.Columns.Add("Registracija", typeof(string));
                    tabela.Columns.Add("Godina\nProizvodnje", typeof(string));
                    tabela.Columns.Add("Predjeno KM", typeof(string));
                    tabela.Columns.Add("Cena", typeof(string));
                    while (reader.Read()) 
                    {
                        DataRow row = tabela.NewRow();
                        row[0] = reader[0].ToString();
                        row[1] = reader[1].ToString();
                        row[2] = reader[2].ToString();
                        row[3] = reader[3].ToString();
                        row[4] = reader[4].ToString();
                        tabela.Rows.Add(row);
                    }
                    reader.Dispose();
                    comm.Dispose();
                    GV.DataSource = tabela;
                    GV.Refresh();
                    SqlCommand comm2 = new SqlCommand(@"SELECT DISTINCT
                                                        (SELECT naziv FROM model WHERE modelID=V.modelID),
                                                        (SELECT COUNT(*) FROM Vozilo WHERE modelID=V.modelID AND cena BETWEEN 9000 AND 10000)
                                                        FROM Vozilo AS V
                                                        WHERE cena BETWEEN @min AND @max;", conn);
                    comm2.Parameters.AddWithValue("@min", tbMin.Text);
                    comm2.Parameters.AddWithValue("@max", tbMax.Text);
                    SqlDataReader reader2 = comm2.ExecuteReader();
                    while (reader2.Read()) 
                    {
                        graph.Series[0].Points.AddXY(reader2[0].ToString(), reader2[1].ToString());
                    }
                    reader2.Dispose();
                    comm2.Dispose();
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

            else
            {
                MessageBox.Show("Odaberite zeljeni opseg cene za prikaz podataka!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Garaza f = new Garaza();
            if (f == null)
                f.Parent = this;
            f.Show();
            this.Hide();
        }
    }
}
