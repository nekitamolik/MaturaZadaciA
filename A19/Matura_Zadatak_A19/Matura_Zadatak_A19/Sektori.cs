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

namespace Matura_Zadatak_A19
{
    public partial class Sektori : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A19;User ID=SA;Password=sp@sic123.");

        public static string sektor = "";

        public Sektori()
        {
            InitializeComponent();
            btnRukovodilacIzmena.Enabled = false;
            toolStripButtonAnaliza.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cbSektor.Text = "Odaberite sektor";
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT naziv FROM Sektor", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    cbSektor.Items.Add(reader[0].ToString());
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

       private void ListViewRefresh() 
        { 
            try
            {
                if (!string.IsNullOrEmpty(sektor))
                {
                    listViewRukovodioci.Items.Clear();
                    if(conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand comm = new SqlCommand(@"SELECT R.radnikID,R.ime,R.prezime,RS.datum_postavljanja,ISNULL(RS.datum_razresenja,GETDATE()) 
                                                    FROM Rukovodi_Sektorom AS RS JOIN Radnik AS R 
                                                    ON RS.radnikID=R.radnikID
                                                    WHERE RS.sektorID=(SELECT sektorID FROM Sektor WHERE naziv=@sektor) 
                                                    ORDER BY ISNULL(RS.datum_razresenja,GETDATE()),RS.datum_razresenja;", conn);
                    comm.Parameters.AddWithValue("@sektor", sektor);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem row = new ListViewItem(reader[0].ToString());
                        row.SubItems.Add(reader[1].ToString());
                        row.SubItems.Add(reader[2].ToString());
                        row.SubItems.Add(Convert.ToDateTime(reader[3].ToString()).ToShortDateString());
                        row.SubItems.Add(Convert.ToDateTime(reader[4].ToString()).ToShortDateString() == DateTime.Now.ToShortDateString() ? "Do danas" : Convert.ToDateTime(reader[4].ToString()).ToShortDateString());
                        listViewRukovodioci.Items.Add(row);
                    }
                    reader.Dispose();
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

        private void btnRukovodilacIzmena_Click(object sender, EventArgs e)
        {
            NoviRukovodioc f = new NoviRukovodioc();
            f.Show();
        }

        private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
        {
            Analiza f = new Analiza();
            f.Show();
            this.Hide();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbSektor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sektor = cbSektor.Text;
                btnRukovodilacIzmena.Enabled = true;
                toolStripButtonAnaliza.Enabled = true;
                conn.Open();
                SqlCommand opis = new SqlCommand(@"SELECT 
                                                    (SELECT ime FROM Radnik WHERE radnikID=RS.radnikID) + ' ' +
                                                    (SELECT prezime FROM Radnik WHERE radnikID=RS.radnikID),
                                                    datum_postavljanja
                                                    FROM Rukovodi_Sektorom AS RS
                                                    WHERE sektorID=(SELECT sektorID FROM Sektor WHERE naziv=@sektor)  AND datum_razresenja IS NULL;", conn);
                opis.Parameters.AddWithValue("@sektor", cbSektor.SelectedItem.ToString());
                SqlDataReader oreader = opis.ExecuteReader();
                while (oreader.Read()) 
                {
                    rtbOpis.Text = "Sektor " + cbSektor.SelectedItem.ToString() + "\nRukovodilac:\n" + oreader[0].ToString() + "\nPostavljen:\n" + Convert.ToDateTime(oreader[1].ToString()).ToShortDateString();
                }
                oreader.Dispose();
                opis.Dispose();

            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
                ListViewRefresh();
            }
        }
    }
}
