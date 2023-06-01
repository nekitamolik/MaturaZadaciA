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


namespace Matura_Zadatak_A8
{
    public partial class TipAntikviteta : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A8;User ID=SA;Password=sp@sic123.");

        string newPicturePath = "";

        public TipAntikviteta()
        {
            InitializeComponent();
            pbSlika.ErrorImage = Image.FromFile(@"C:\Users\Velja\Desktop\Matura\A8\Matura\A8\Matura_Zadatak_A8\Matura_Zadatak_A8\Images\no_image.jpg");
            btnBack.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if(!string.IsNullOrEmpty(tbTipNaziv.Text) && !string.IsNullOrEmpty(lblSifraID.Text))
                {
                    SqlCommand comm = new SqlCommand(@"UPDATE Tip_Antikviteta 
                                                    SET tip= @naziv, slika=@path
                                                    WHERE tip_antikvitetaID=@id;", conn);
                    comm.Parameters.AddWithValue("@naziv", tbTipNaziv.Text);
                    comm.Parameters.AddWithValue("@path", newPicturePath);
                    comm.Parameters.AddWithValue("@id",lblSifraID.Text);
                    comm.ExecuteNonQuery();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int i = 1;
                if (!string.IsNullOrEmpty(lblSifraID.Text))
                    i = Convert.ToInt16(lblSifraID.Text) - 1;
                SqlCommand comm = new SqlCommand(@"SELECT tip_antikvitetaID, tip , slika FROM Tip_Antikviteta 
                                                     WHERE tip_antikvitetaID = @id;", conn);
                comm.Parameters.AddWithValue("@id", i);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                if (adapter != null)
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    lblSifraID.Text = tabela.Rows[0][0].ToString();
                    tbTipNaziv.Text = tabela.Rows[0][1].ToString();
                    pbSlika.Image = Image.FromFile(tabela.Rows[0][2].ToString());
                }
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int i = 1;
                if (!string.IsNullOrEmpty(lblSifraID.Text))
                     i = Convert.ToInt16(lblSifraID.Text) + 1;
                 SqlCommand comm = new SqlCommand(@"SELECT tip_antikvitetaID, tip , slika FROM Tip_Antikviteta 
                                                     WHERE tip_antikvitetaID = @id;", conn);
                    comm.Parameters.AddWithValue("@id", i);
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    if (adapter != null)
                    {
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);
                        lblSifraID.Text = tabela.Rows[0][0].ToString();
                        tbTipNaziv.Text = tabela.Rows[0][1].ToString();
                        pbSlika.Image = Image.FromFile(tabela.Rows[0][2].ToString());
                    }
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

        private void tbTipNaziv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(conn.State != ConnectionState.Open)
                    conn.Open();
                if (!string.IsNullOrEmpty(tbTipNaziv.Text))
                {
                    SqlCommand comm = new SqlCommand(@"SELECT tip_antikvitetaID, tip , slika FROM Tip_Antikviteta;", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    if (adapter != null)
                    {
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);
                        bool x = false;
                        foreach (DataRow row in tabela.Rows)
                            if (row[1].ToString() == tbTipNaziv.Text)
                            {
                                x = true;
                                lblSifraID.Text = row[0].ToString();
                                tbTipNaziv.Text = row[1].ToString();
                                pbSlika.Image = Image.FromFile(row[2].ToString());
                            }
                        if (x == false) 
                        {
                            lblSifraID.Text = "0";
                            pbSlika.Image = pbSlika.ErrorImage;
                        }   
                    }
                    comm.Dispose();
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

        private void pbSlika_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult r = open.ShowDialog();
            if ( r == DialogResult.OK)
            {
                pbSlika.Image = new Bitmap(open.FileName);
                newPicturePath = open.FileName;
            }
        }

        private void lblSifraID_TextChanged(object sender, EventArgs e)
        {
            int i;
            if(string.IsNullOrEmpty(lblSifraID.Text))
                i = 0;
            else
                i = Convert.ToInt16(lblSifraID.Text);
            SqlCommand c = new SqlCommand(@"SELECT COUNT(*) FROM Tip_Antikviteta;", conn);
            int count = Convert.ToInt32(c.ExecuteScalar());
            if (i < count)
                btnNext.Enabled = true;
            else
                btnNext.Enabled = false;
            if (i > 1)
                btnBack.Enabled = true;
            else
                btnBack.Enabled = false;
            c.Dispose();
        }

        
    }
}
