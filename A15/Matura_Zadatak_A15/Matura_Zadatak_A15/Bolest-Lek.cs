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

namespace Matura_Zadatak_A15
{
    public partial class Bolest_Lek : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A15;User ID=SA;Password=sp@sic123.");

        public Bolest_Lek()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand bolest = new SqlCommand(@"SELECT naziv FROM Bolest", conn);
                SqlDataReader br = bolest.ExecuteReader();
                while (br.Read()) 
                {
                    cbBolest.Items.Add(br[0].ToString());
                }
                br.Dispose();
                SqlCommand lek = new SqlCommand(@"SELECT naziv_leka FROM Lek", conn);
                SqlDataReader lr = lek.ExecuteReader();
                while (lr.Read())
                {
                    cbLek.Items.Add(lr[0].ToString());
                }
                lr.Dispose();
                GV_Refresh();
                cbBolest.Text = GV.Rows[0].Cells[0].Value.ToString();
                cbLek.Text = GV.Rows[0].Cells[1].Value.ToString();
                tbNapomena.Text = GV.Rows[0].Cells[3].Value.ToString();
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

        private void GV_Refresh() 
        {
            try
            {
                if(conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT 
                                                            (SELECT naziv FROM Bolest AS B WHERE B.bolestID=LB.bolestID) AS Bolest,
                                                            (SELECT naziv_leka FROM Lek AS L WHERE L.lekID=LB.lekID) AS Lek,
                                                            (SELECT 
                                                            (SELECT naziv FROM Proizvodjac AS P WHERE P.proizvodjacID=L.proizvodjacID) 
                                                            FROM Lek AS L WHERE L.lekID=LB.lekID) AS Proizvodjac,
                                                            napomena FROM Lek_Bolest AS LB
                                                            ORDER BY Bolest;", conn);
                if (adapter != null) 
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    GV.DataSource = tabela;
                    GV.Columns[3].Visible = false;
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

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool exists = false;
                for (int i = 0; i < GV.Rows.Count;i++ )
                {
                    if (GV.Rows[i].Cells[0].Value.ToString() == cbBolest.Text && GV.Rows[i].Cells[1].Value.ToString() == cbLek.Text)
                    {
                        exists = true;
                        MessageBox.Show("Izabrani lek je vec dodeljen selektovanoj bolesti!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                if (exists == false)
                {
                    conn.Open();
                    SqlCommand upis = new SqlCommand(@"INSERT INTO Lek_Bolest VALUES
	                                                    (
		                                                    (SELECT lekid FROM Lek WHERE naziv_leka=@lek),
		                                                    (SELECT bolestid FROM Bolest WHERE naziv=@bolest),
		                                                    @napomena
	                                                    );", conn);
                    upis.Parameters.AddWithValue("@bolest", cbBolest.Text);
                    upis.Parameters.AddWithValue("@lek", cbLek.Text);
                    upis.Parameters.AddWithValue("@napomena", tbNapomena.Text);
                    upis.ExecuteNonQuery();
                    MessageBox.Show("Podatak je upiasn u bazu!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GV_Refresh();
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

        private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
        {
            Analiza f = new Analiza();
            f.Show();
            this.Hide();
        }

        private void toolStripButtonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputstvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GV_SelectionChanged(object sender, EventArgs e)
        {
            if (GV.SelectedRows.Count > 0) 
            {
                cbBolest.Text = GV.SelectedRows[0].Cells[0].Value.ToString();
                cbLek.Text = GV.SelectedRows[0].Cells[1].Value.ToString();
                tbNapomena.Text = GV.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
