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
using System.IO;

namespace Matura_Zadatak_A9
{
    public partial class Game : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P14D2RL;Initial Catalog=A9;Integrated Security=True");

        public Game()
        {
            InitializeComponent();
            cbDrzava.Items.Add("Sve drzave");
            cbGrad.Items.Add("Svi gradovi");
            cbKlub.Items.Add("Svi klubovi");
            cbDrzava.SelectedIndex = 0;
            cbGrad.SelectedIndex = 0;
            cbKlub.SelectedIndex = 0;
            cbGrad.Enabled = false;
            cbKlub.Enabled = false;
            pbGrb.ErrorImage = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Klubovi\no_image.jpg");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT naziv FROM Drzava;", conn);
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read()) 
                {
                    cbDrzava.Items.Add(r[0].ToString());
                }
                r.Dispose();
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

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            cbDrzava.SelectedIndex = 0;
            cbGrad.SelectedIndex = 0;
            cbKlub.SelectedIndex = 0;
            cbGrad.Enabled = false;
            cbKlub.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDrzava.SelectedIndex != 0)
            {
                try
                {
                    cbGrad.Enabled = true;
                    conn.Open();
                    SqlCommand comm = new SqlCommand(@"SELECT grad FROM Grad WHERE drzavaID = (SELECT drzavaID FROM Drzava WHERE naziv = @drzava)", conn);
                    comm.Parameters.AddWithValue("@drzava", cbDrzava.SelectedItem.ToString());
                    SqlDataReader r = comm.ExecuteReader();
                    while (r.Read())
                    {
                        cbGrad.Items.Add(r[0].ToString());
                    }
                    r.Dispose();
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
            else 
            {
                cbGrad.SelectedIndex = 0;
                cbKlub.SelectedIndex = 0;
                cbGrad.Enabled = false;
                cbKlub.Enabled = false; 
            }
        }

        private void cbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGrad.SelectedIndex != 0)
            {
                try
                {
                    cbKlub.Enabled = true;
                    conn.Open();
                    SqlCommand comm = new SqlCommand(@"SELECT K.Naziv FROM Klub AS K JOIN Stadion AS S ON K.stadionID = S.stadionID
                                                WHERE S.stadionID = (SELECT gradID FROM Grad WHERE grad = @grad)", conn);
                    comm.Parameters.AddWithValue("@grad", cbGrad.SelectedItem.ToString());
                    SqlDataReader r = comm.ExecuteReader();
                    while (r.Read())
                    {
                        cbKlub.Items.Add(r[0].ToString());
                    }
                    r.Dispose();
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
            else 
            {
                cbKlub.SelectedIndex = 0;
                cbKlub.Enabled = false; 
            }
        }

        private void cbKlub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKlub.SelectedIndex != 0)
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(@"SELECT  G.grad, S.naziv, K.Sajt , K.amblem
                                                FROM Klub AS K JOIN Stadion AS S ON K.stadionID = S.stadionID
                                                JOIN Grad AS G ON S.gradID = G.gradID
                                                WHERE K.naziv = @klub", conn);
                    comm.Parameters.AddWithValue("@klub", cbKlub.SelectedItem.ToString());
                    SqlDataReader r = comm.ExecuteReader();
                    while (r.Read())
                    {
                        lblGrad.Text = r[0].ToString();
                        lblStadion.Text = r[1].ToString();
                        LlblSajt.Text = r[2].ToString();
                        pbGrb.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "/Klubovi/" + r[3].ToString());
                    }
                    r.Dispose();
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

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                listViewUtakmice.Items.Clear();
                SqlCommand comm = new SqlCommand(@"SELECT (SELECT naziv FROM Stadion 
                                                WHERE stadionID = (SELECT stadionID FROM Klub WHERE klubID = domacinID)),
                                                (SELECT naziv FROM Klub WHERE klubID = domacinID),
                                                golova_domacin,golova_gost,
                                                (SELECT naziv FROM Klub WHERE klubID = gostID)
                                                FROM Utakmica
                                                WHERE datum_igranja=@datum", conn);
                comm.Parameters.AddWithValue("@datum", dateTimePickerDatum.Value.ToShortDateString());
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    ListViewItem row = new ListViewItem(reader[0].ToString());
                    row.SubItems.Add(reader[1].ToString());
                    row.SubItems.Add(reader[2].ToString());
                    row.SubItems.Add(reader[3].ToString());
                    row.SubItems.Add(reader[4].ToString());
                    listViewUtakmice.Items.Add(row);
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
}
