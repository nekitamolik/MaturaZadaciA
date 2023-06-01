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
    public partial class NoviRukovodioc : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A19;User ID=SA;Password=sp@sic123.");

        public NoviRukovodioc()
        {
            InitializeComponent();
        }

        private void NoviRukovodioc_Load(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT radnikID,ime+' '+prezime FROM Radnik 
                                                WHERE sektorID = (SELECT sektorID FROM Sektor WHERE naziv=@sektor);", conn);
                comm.Parameters.AddWithValue("@sektor",Sektori.sektor);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    cbRukovodioc.Items.Add("(" + reader[0].ToString() + ") " + reader[1].ToString());
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbDatum.Text) && !string.IsNullOrEmpty(cbRukovodioc.Text))
            {
                try
                {
                    conn.Open();
                    string[] pom = cbRukovodioc.Text.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    string radnikID = pom[0];
                    DateTime datum = Convert.ToDateTime(tbDatum.Text);
                    SqlCommand sektor = new SqlCommand(@"SELECT sektorID FROM Sektor WHERE naziv=@sektor", conn);
                    sektor.Parameters.AddWithValue("@sektor", Sektori.sektor);
                    string sektorID = sektor.ExecuteScalar().ToString();
                    SqlCommand comm = new SqlCommand(@"INSERT INTO Rukovodi_Sektorom VALUES
	                                                        (@sektor,@id,@date,NULL);", conn);
                    comm.Parameters.AddWithValue("@id", radnikID);
                    comm.Parameters.AddWithValue("@sektor", sektorID);
                    comm.Parameters.AddWithValue("@date", datum);
                    comm.ExecuteNonQuery();
                    SqlCommand comm2 = new SqlCommand(@"UPDATE Rukovodi_Sektorom 
                                                        SET datum_razresenja=@date
                                                        WHERE datum_razresenja IS NULL AND sektorID = @sektor;", conn);
                    comm2.Parameters.AddWithValue("@sektor", sektorID);
                    comm2.Parameters.AddWithValue("@date", datum);
                    comm2.ExecuteNonQuery();
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                    this.Close();
                }
            }

            else 
            {
                MessageBox.Show("Morate popuniti polja ove forma radi imenovanja novog rukovodioca!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
