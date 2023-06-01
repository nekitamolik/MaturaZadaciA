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

namespace Matura_Zadatak_A4
{
    public partial class Sela : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A4;User ID=SA;Password=sp@sic123.");

        public Sela()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            List_Update();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT Grad FROM Grad;", conn);
            DataTable grad = new DataTable();
            if (adapter != null)
            {
                adapter.Fill(grad);
                foreach (DataRow row in grad.Rows)
                {
                    cbGrad.Items.Add(row[0].ToString());
                }
            }
        }

        private void List_Update() 
        {
            try
            {
                conn.Open();
                ListViewSela.Items.Clear();
                SqlCommand comm = new SqlCommand(@"SELECT seloID, naziv, G.grad 
                                                 FROM Selo AS S JOIN Grad AS G ON S.gradID = G.gradID;", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    ListViewItem row = new ListViewItem(reader[0].ToString());
                    row.SubItems.Add(reader[1].ToString());
                    row.SubItems.Add(reader[2].ToString());
                    ListViewSela.Items.Add(row);
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

        private void btnIzmene_Click(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                if (!string.IsNullOrEmpty(tbSifra.Text) && !string.IsNullOrEmpty(tbNaziv.Text) && !string.IsNullOrEmpty(cbGrad.Text))
                {
                    SqlCommand comm = new SqlCommand(@"UPDATE Selo
                                                 SET naziv=@naziv,
                                                 gradID=(SELECT gradID FROM Grad WHERE grad = @grad)
                                                 WHERE seloID = @id;", conn);
                    comm.Parameters.AddWithValue("@id", tbSifra.Text);
                    comm.Parameters.AddWithValue("@naziv", tbNaziv.Text);
                    comm.Parameters.AddWithValue("@grad", cbGrad.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Uspesno izvrsene izmene", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else 
                {
                    string path = Directory.GetCurrentDirectory() + "/Log doks/error.txt";
                    File.AppendAllText(path, DateTime.Now.ToShortDateString() + " Error : morate popuniti sva polja radi uspesne izmene \n");
                }
            }

            catch (Exception error)
            {
                string path = Directory.GetCurrentDirectory() + "/Log doks/error.txt";
                File.AppendAllText(path, DateTime.Now.ToShortDateString() + " Error : " + error.Message + "\n");
            }

            finally
            {
                conn.Close();
                List_Update();
            }

        }

        private void tbSifra_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSifra.Text))
            {
                if (ListViewSela.FindItemWithText(tbSifra.Text) != null)
                {
                    int i = ListViewSela.FindItemWithText(tbSifra.Text).Index;

                    tbNaziv.Text = ListViewSela.Items[i].SubItems[1].Text;
                    cbGrad.Text = ListViewSela.Items[i].SubItems[2].Text;
                    ListViewSela.Items[i].Focused = true;
                    ListViewSela.Items[i].Selected = true;
                }
            }
            else 
            {
                tbNaziv.Text = "";
                cbGrad.Text = "";
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputstvo", "Korisnicko Uputsvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Statistika f = new Statistika();
            f.Show();
            this.Hide();
        }

    }
}
