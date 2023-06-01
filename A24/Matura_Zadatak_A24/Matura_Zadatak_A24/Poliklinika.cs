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

namespace Matura_Zadatak_A24
{
    public partial class Poliklinika : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A24;User ID=SA;Password=sp@sic123.");

        public Poliklinika()
        {
            InitializeComponent();
            cbSpecijalizacija.Text = "Izaberite specijalizaciju ...";

            graph.ChartAreas[0].AxisX.Interval = 1;
            graph.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
        }

        private void Poliklinika_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT tip FROM Tip_Lekara", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    cbSpecijalizacija.Items.Add(reader[0].ToString());
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (izmenjeni_indexi.Length > 0)
            {
                try
                {
                    conn.Open();
                    for (int i = 0; i < izmenjeni_indexi.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(izmenjeni_indexi[i]))
                        {
                            string[] pom = izmenjeni_indexi[i].Split(' ');
                            bool state = Convert.ToBoolean(pom[0]);
                            int index = Convert.ToInt16(pom[1]);

                            string[] separator = new string[2] { "Spec dr med. ", " " };
                            pom = cbLekar.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                            string ime = pom[0];
                            string prezime = pom[1];


                            SqlCommand comm = new SqlCommand(@"SELECT lekarID,poliklinikaID,aktivan FROM Poliklinika_Specijalista 
                                                            WHERE
                                                            lekarID=
	                                                            (SELECT lekarID FROM Lekar
	                                                            WHERE 
	                                                            ime=@ime AND prezime=@prezime
	                                                            AND
	                                                            tip_lekaraID=(SELECT tip_lekaraID FROM Tip_Lekara WHERE tip=@tip))
                                                            AND
                                                            poliklinikaID=
	                                                            (SELECT poliklinikaID FROM Poliklinika 
	                                                            WHERE naziv=@poliklinika
	                                                            AND
	                                                            gradID = (SELECT gradID FROM Grad WHERE grad=@grad));", conn);
                            comm.Parameters.AddWithValue("@tip", cbSpecijalizacija.Text);
                            comm.Parameters.AddWithValue("@ime", ime);
                            comm.Parameters.AddWithValue("@prezime", prezime);
                            comm.Parameters.AddWithValue("@poliklinika", GV.Rows[index].Cells[1].Value);
                            comm.Parameters.AddWithValue("@grad", GV.Rows[index].Cells[0].Value);
                            SqlDataReader reader = comm.ExecuteReader();
                            if (reader.HasRows)
                            {
                                string lekarID = "", poliklinikaID = "", aktivan = "";
                                while (reader.Read())
                                {
                                    lekarID = reader[0].ToString();
                                    poliklinikaID = reader[1].ToString();
                                    aktivan = reader[2].ToString();
                                }
                                reader.Dispose();
                                comm.Dispose();

                                /*Program state:false Baza state:true */
                                if (Convert.ToBoolean(aktivan) && !state)
                                    aktivan = "FALSE";

                                /*Program state:true Baza state:false */
                                else if (!Convert.ToBoolean(aktivan) && state)
                                    aktivan = "TRUE";

                                SqlCommand update = new SqlCommand(@"UPDATE Poliklinika_Specijalista SET aktivan=@aktivan
                                                                 WHERE lekarID=@lekarID AND poliklinikaID=@poliklinikaID", conn);
                                update.Parameters.AddWithValue("@lekarID", lekarID);
                                update.Parameters.AddWithValue("@poliklinikaID", poliklinikaID);
                                update.Parameters.AddWithValue("@aktivan", aktivan);
                                update.ExecuteNonQuery();

                            }

                            else
                            {
                                reader.Dispose();
                                string lekarID = "", poliklinikaID = "";

                                SqlCommand poliklinika = new SqlCommand(@"SELECT poliklinikaID FROM Poliklinika 
	                                                                    WHERE naziv=@poliklinika
	                                                                    AND
	                                                                    gradID = (SELECT gradID FROM Grad WHERE grad=@grad)", conn);
                                poliklinika.Parameters.AddWithValue("@poliklinika", GV.Rows[index].Cells[1].Value);
                                poliklinika.Parameters.AddWithValue("@grad", GV.Rows[index].Cells[0].Value);
                                poliklinikaID = poliklinika.ExecuteScalar().ToString();
                                poliklinika.Dispose();

                                SqlCommand lekar = new SqlCommand(@"SELECT lekarID FROM Lekar
	                                                            WHERE 
	                                                            ime=@ime AND prezime=@prezime
	                                                            AND
	                                                            tip_lekaraID=(SELECT tip_lekaraID FROM Tip_Lekara WHERE tip=@tip)", conn);
                                lekar.Parameters.AddWithValue("@tip", cbSpecijalizacija.Text);
                                lekar.Parameters.AddWithValue("@ime", ime);
                                lekar.Parameters.AddWithValue("@prezime", prezime);
                                lekarID = lekar.ExecuteScalar().ToString();
                                lekar.Dispose();

                                SqlCommand upis = new SqlCommand(@"INSERT INTO Poliklinika_Specijalista VALUES (@poliklinikaID,@lekarID,@aktivan)", conn);
                                upis.Parameters.AddWithValue("@lekarID", lekarID);
                                upis.Parameters.AddWithValue("@poliklinikaID", poliklinikaID);
                                upis.Parameters.AddWithValue("@aktivan", "TRUE");
                                upis.ExecuteNonQuery();
                            }
                        }
                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                    MessageBox.Show("Uspesna izmena angazovanja!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Morate izmeniti nesto u vec postojecem angazmanu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbSpecijalizacija_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT ime+' '+prezime FROM Lekar WHERE tip_lekaraID=(SELECT tip_lekaraID FROM Tip_Lekara WHERE tip=@tip); ", conn);
                comm.Parameters.AddWithValue("@tip", cbSpecijalizacija.SelectedItem);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    cbLekar.Items.Add("Spec dr med. " + reader[0].ToString());
                }
                reader.Dispose();
                comm.Dispose();
                cbLekar.Text = "Izaberite lekara ...";
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

        private void cbLekar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                GV.Rows.Clear();
                string[] separator = new string[2] { "Spec dr med. ", " " };
                string[] pom = cbLekar.SelectedItem.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string ime = pom[0];
                string prezime = pom[1];

                SqlCommand comm = new SqlCommand(@"SELECT
	                                                (SELECT grad FROM Grad WHERE gradID=P.gradID),
	                                                naziv,
	                                                ISNULL(
	                                                (SELECT aktivan FROM Poliklinika_Specijalista 
	                                                WHERE 
	                                                poliklinikaID=P.poliklinikaID 
	                                                AND 
	                                                lekarID=
		                                                (SELECT lekarID FROM Lekar
		                                                WHERE 
		                                                ime=@ime AND prezime=@prezime
		                                                AND
		                                                tip_lekaraID=(SELECT tip_lekaraID FROM Tip_Lekara WHERE tip=@tip)))
	                                                ,'FALSE')
                                                FROM Poliklinika AS P  ", conn);
                comm.Parameters.AddWithValue("@tip", cbSpecijalizacija.Text);
                comm.Parameters.AddWithValue("@ime", ime);
                comm.Parameters.AddWithValue("@prezime", prezime);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    GV.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString() == "TRUE" ? true : false);
                }
                reader.Dispose();
                comm.Dispose();

                foreach (DataGridViewRow row in GV.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[2].Value))
                        row.Selected = true;
                    else
                        row.Selected = false;
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
        
        string[] izmenjeni_indexi = new string[20];
        int br = 0;

        private void GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(br<20)
                if (GV.SelectedRows.Count > 0)
                {
                    int index = GV.SelectedRows.Count - 1;
                    if (Convert.ToBoolean(GV.SelectedRows[index].Cells[2].Value))
                    {
                        GV.SelectedRows[index].Cells[2].Value = false;
                        izmenjeni_indexi[br] = GV.SelectedRows[index].Cells[2].Value.ToString() + " " + e.RowIndex;
                        br++;
                    }

                    else
                    {
                        GV.SelectedRows[index].Cells[2].Value = true;
                        izmenjeni_indexi[br] = GV.SelectedRows[index].Cells[2].Value.ToString() + " " + e.RowIndex;
                        br++;
                    }

                    foreach (DataGridViewRow row in GV.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[2].Value))
                            row.Selected = true;
                        else
                            row.Selected = false;
                    }
                }
            else
               MessageBox.Show("Maximalan broj izmena po 1 zahtevu", "", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            try
            {
                graph.Series[0].Points.Clear();
                conn.Open();
                string OD = "", DO = "";
                string cmdtxt = "";

                if (!string.IsNullOrEmpty(tbDateOD.Text) && !string.IsNullOrEmpty(tbDateDO.Text))
                {
                    OD = Convert.ToDateTime(tbDateOD.Text).ToString("yyyy.MM.dd");
                    DO = Convert.ToDateTime(tbDateDO.Text).ToString("yyyy.MM.dd");
                }

                else 
                {
                    OD = DateTime.Now.AddYears(-10).ToString("yyyy.MM.dd");
                    DO = DateTime.Now.ToString("yyyy.MM.dd");

                }

                if (rbKlinika.Checked)
                {
                    cmdtxt = @"SELECT TOP 10 T.Poliklinika,
                                (SELECT COUNT(*) FROM Zakazivanje
                                WHERE poliklinikaID IN (SELECT poliklinikaID FROM Poliklinika WHERE naziv = T.Poliklinika)
                                AND 
                                datum_zakazivanja";
                    cmdtxt += " BETWEEN '" + OD + "' AND '" + DO + "' )";
                    cmdtxt += @"FROM
                                (SELECT
                                (SELECT naziv FROM Poliklinika WHERE poliklinikaID=Z.poliklinikaID) AS Poliklinika
                                FROM Zakazivanje AS Z ) AS T
                                GROUP BY T.Poliklinika;";
                }
                else if (rbSpec.Checked)
                {
                    cmdtxt = @"SELECT TOP 10 Tip,
                                (SELECT COUNT(*) FROM Zakazivanje
                                WHERE 
                                lekarID IN ((SELECT lekarID FROM Lekar WHERE tip_lekaraID = (SELECT tip_lekaraID FROM Tip_Lekara WHERE tip=T.Tip))) 
                                AND
                                datum_zakazivanja";
                    cmdtxt += " BETWEEN '" + OD + "' AND '" + DO + "' )";
                    cmdtxt += @"FROM
                                (SELECT
                                (SELECT tip FROM Tip_Lekara
                                WHERE tip_lekaraID = 
				                                (SELECT tip_lekaraID FROM Lekar WHERE lekarID=Z.lekarID)) AS Tip
                                FROM Zakazivanje AS Z)  AS T
                                GROUP BY T.Tip;";
                }
                else
                {
                    cmdtxt = @"SELECT TOP 10 Grad ,
                                (SELECT COUNT(*) FROM Zakazivanje 
                                WHERE
                                poliklinikaID IN ((SELECT poliklinikaID FROM Poliklinika WHERE gradID = (SELECT gradID FROM Grad WHERE grad=T.Grad)))
                                AND
                                datum_zakazivanja";
                    cmdtxt += " BETWEEN '" + OD + "' AND '" + DO + "' )";
                    cmdtxt += @"FROM
                                (SELECT
                                (SELECT (SELECT grad FROM Grad WHERE gradID = P.gradID) 
                                FROM Poliklinika AS P WHERE poliklinikaID = Z.poliklinikaID) AS Grad
                                FROM Zakazivanje AS Z) AS T
                                GROUP BY T.Grad;";
                }

                SqlCommand comm = new SqlCommand(cmdtxt, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    graph.Series[0].Points.AddXY(reader[0].ToString(), reader[1].ToString());
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
