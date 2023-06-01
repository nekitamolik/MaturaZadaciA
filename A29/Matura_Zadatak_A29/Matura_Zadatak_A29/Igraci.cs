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


namespace Matura_Zadatak_A29
{
    public partial class Igraci : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A29;User ID=SA;Password=sp@sic123.");

        public Igraci()
        {
            InitializeComponent();
            btnGiveUp.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FORM_Refresh();
        }

        private void FORM_Refresh() 
        {
            try
            {
                if(conn.State!=ConnectionState.Open)
                    conn.Open();
                listBoxIgraci.Items.Clear();
                cbSifra.Items.Clear();
                cbGrad.Items.Clear();


                //      ListBox refresh
                SqlCommand LBcomm = new SqlCommand(@"SELECT igracID,ime,prezime,adresa,gradID,email,telefon FROM Igrac ", conn);
                SqlDataReader LBreader = LBcomm.ExecuteReader();
                while (LBreader.Read()) 
                {
                    listBoxIgraci.Items.Add(string.Format("{0,0}{1,15}{2,30}{3,35}{4,20}{5,40}{6,20}", LBreader[0].ToString(), LBreader[1].ToString(), LBreader[2].ToString(), LBreader[3].ToString(), LBreader[4].ToString(), LBreader[5].ToString(), LBreader[6].ToString()));
                }
                LBreader.Dispose();
                LBcomm.Dispose();

                //      ComboBox filler
                SqlCommand CBcommS = new SqlCommand(@"SELECT igracID FROM Igrac ", conn);
                SqlDataReader CBreaderS = CBcommS.ExecuteReader();
                while (CBreaderS.Read())
                    cbSifra.Items.Add(CBreaderS[0].ToString());
                CBreaderS.Dispose();
                CBcommS.Dispose();
                SqlCommand CBcommG = new SqlCommand(@"SELECT grad FROM Grad ", conn);
                SqlDataReader CBreaderG = CBcommG.ExecuteReader();
                while (CBreaderG.Read())
                    cbGrad.Items.Add(CBreaderG[0].ToString());
                CBreaderG.Dispose();
                CBcommG.Dispose();

                //      Fields reset
                listBoxIgraci.SelectedIndex = 0;
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            {
                conn.Close();
            }
        }

        private void toolStripLabelUnos_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (priprema_active)
                {
                    if (!string.IsNullOrEmpty(tbIme.Text) && !string.IsNullOrEmpty(tbPrezime.Text)
                    && !string.IsNullOrEmpty(tbAdresa.Text) && !string.IsNullOrEmpty(cbGrad.Text) && !string.IsNullOrEmpty(tbMejl.Text)
                    && !string.IsNullOrEmpty(tbTelefon.Text))
                    {
                        SqlCommand unos = new SqlCommand(@"INSERT INTO Igrac VALUES (@ime,@prezime,@adresa,@gradID,@email,@telefon)", conn);
                        unos.Parameters.AddWithValue("@ime", tbIme.Text);
                        unos.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                        unos.Parameters.AddWithValue("@adresa", tbAdresa.Text);
                        unos.Parameters.AddWithValue("@gradID", cbGrad.SelectedIndex + 1);
                        unos.Parameters.AddWithValue("@email", tbMejl.Text);
                        unos.Parameters.AddWithValue("@telefon", tbTelefon.Text);
                        unos.ExecuteNonQuery();
                        MessageBox.Show("Uspesan upis novog igrača!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FORM_Refresh();
                        priprema_active = false;
                        cbSifra.Enabled = true;
                    }
                    else
                        MessageBox.Show("Morate popuniti sva polja kako bi uneli novog igrača!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Morate prvo pripremiti aplikaciju za unos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            {
                conn.Close();
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
            Uputstvo f = new Uputstvo();
            f.Show();
        }

        private void toolStripLabelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool priprema_active = false;

        private void btnPriprema_Click(object sender, EventArgs e)
        {
            cbSifra.Enabled = false;
            cbSifra.Text = "";
            tbIme.Text = "";
            tbPrezime.Text = "";
            tbAdresa.Text = "";
            cbGrad.Text = "";
            tbMejl.Text = "";
            tbTelefon.Text = "";
            priprema_active = true;
            btnGiveUp.Visible = true;
        }

        private void listBoxIgraci_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] podaci = listBoxIgraci.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            cbSifra.Text = podaci[0];
            tbIme.Text = podaci[1];
            tbPrezime.Text = podaci[2];
            tbAdresa.Text = podaci[3];
            cbGrad.Text = cbGrad.Items[Convert.ToInt16(podaci[4]) - 1].ToString();
            tbMejl.Text = podaci[5];
            tbTelefon.Text = podaci[6];
        }

        private void cbSifra_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxIgraci.FindString(cbSifra.Text);
            string[] podaci = listBoxIgraci.Items[index].ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            cbSifra.Text = podaci[0];
            tbIme.Text = podaci[1];
            tbPrezime.Text = podaci[2];
            tbAdresa.Text = podaci[3];
            cbGrad.Text = cbGrad.Items[Convert.ToInt16(podaci[4])-1].ToString();
            tbMejl.Text = podaci[5];
            tbTelefon.Text = podaci[6];
            listBoxIgraci.SelectedIndex = index;
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            cbSifra.Enabled = true;
            cbSifra_SelectedIndexChanged(sender, e);
            priprema_active = false;
            btnGiveUp.Visible = false;
        }
    }
}
