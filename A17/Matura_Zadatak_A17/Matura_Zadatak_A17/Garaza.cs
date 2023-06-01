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

namespace Matura_Zadatak_A17
{
    public partial class Garaza : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A17;User ID=SA;Password=sp@sic123.");

        public Garaza()
        {
            InitializeComponent();
        }

        private void Garaza_Load(object sender, EventArgs e)
        {
            try
            {
                btnOdustani.Visible = false;
                ListBoxRefresh();
                listBoxVozila.SelectedIndex = 0;
                conn.Open();
                SqlCommand model = new SqlCommand(@"SELECT naziv FROM Model;", conn);
                SqlDataReader mreader = model.ExecuteReader();
                while (mreader.Read()) 
                {
                    cbModel.Items.Add(mreader[0].ToString());
                }
                mreader.Dispose();
                model.Dispose();
                SqlCommand boja = new SqlCommand(@"SELECT naziv FROM Boja;", conn);
                SqlDataReader breader = boja.ExecuteReader();
                while (breader.Read())
                {
                    cbBoja.Items.Add(breader[0].ToString());
                }
                breader.Dispose();
                boja.Dispose();
                SqlCommand gorivo = new SqlCommand(@"SELECT naziv FROM Gorivo;", conn);
                SqlDataReader greader = gorivo.ExecuteReader();
                while (greader.Read())
                {
                    cbGorivo.Items.Add(greader[0].ToString());
                }
                greader.Dispose();
                gorivo.Dispose();
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

        private void ListBoxRefresh() 
        {
            try
            {
                listBoxVozila.Items.Clear();
                if(conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT voziloID,registracija,godina_proizvodnje,predjeno_km,modelID,bojaID,gorivoID,cena FROM Vozilo;", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    listBoxVozila.Items.Add(string.Format("{0,10}{1,40}{2,30}{3,30}{4,20}{5,30}{6,20}{7,25}", reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
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

        private void btnIzmena_Click(object sender, EventArgs e)
        {
            btnOdustani.Visible = true;
            btnIzmena.ForeColor = Color.Black;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            btnOdustani.Visible = false;
            btnIzmena.ForeColor = Color.White;
        }

        private void toolStripLabelIzmeni_Click(object sender, EventArgs e)
        {
            if (btnOdustani.Visible)
            {
                try 
                {
                    conn.Open();
                    SqlCommand update = new SqlCommand(@"UPDATE Vozilo SET
                                                        registracija=@reg,
                                                        godina_proizvodnje=@god,
                                                        predjeno_km=@km,
                                                        modelID= (SELECT modelid FROM Model WHERE naziv=@model),
                                                        bojaID=(SELECT bojaID FROM Boja WHERE naziv=@boja),
                                                        gorivoID=(SELECT gorivoID FROM Gorivo WHERE naziv=@gorivo),
                                                        cena =@cena
                                                        WHERE voziloID=@id;", conn);
                    update.Parameters.AddWithValue("@id", tbID.Text);
                    update.Parameters.AddWithValue("@reg", tbReg.Text);
                    update.Parameters.AddWithValue("@god", tbGod.Text);
                    update.Parameters.AddWithValue("@km", tbKM.Text);
                    update.Parameters.AddWithValue("@model", cbModel.Text);
                    update.Parameters.AddWithValue("@boja", cbBoja.Text);
                    update.Parameters.AddWithValue("@gorivo", cbGorivo.Text);
                    update.Parameters.AddWithValue("@cena", tbCena.Text);
                    update.ExecuteNonQuery();
                    MessageBox.Show("Podaci o vozilu su izmenjeni u bazi\n Sifra vozila je : " + tbID.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                    ListBoxRefresh();
                    btnOdustani.Visible = false;
                    btnIzmena.ForeColor = Color.White;
                } 
            }

            else 
            {
                MessageBox.Show("Morate pripremiti izmenu pre izvrsenja!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripLabelAnaliza_Click(object sender, EventArgs e)
        {
            Analiza f = new Analiza();
            f.Show();
            this.Hide();
        }

        private void toolStripLabelInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputstvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripLabelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string[] row = listBoxVozila.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                tbID.Text = row[0];
                tbReg.Text = row[1];
                tbGod.Text = row[2];
                tbKM.Text = row[3];
                tbCena.Text = row[7];
                SqlCommand model = new SqlCommand(@"SELECT naziv FROM Model WHERE modelID=@id", conn);
                model.Parameters.AddWithValue("@id", row[4]);
                cbModel.Text = model.ExecuteScalar().ToString();
                SqlCommand boja = new SqlCommand(@"SELECT naziv FROM Boja WHERE bojaID=@id", conn);
                boja.Parameters.AddWithValue("@id", row[5]);
                cbBoja.Text = boja.ExecuteScalar().ToString();
                SqlCommand gorivo = new SqlCommand(@"SELECT naziv FROM Gorivo WHERE gorivoID=@id", conn);
                gorivo.Parameters.AddWithValue("@id", row[6]);
                cbGorivo.Text = gorivo.ExecuteScalar().ToString();
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
