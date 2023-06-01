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

namespace Matura_Zadatak_A22
{
    public partial class Golf_turnir : Form
    {

        public static SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A22;User ID=SA;Password=sp@sic123.");
        public static Golf_turnir Gt;
        public RichTextBox rtbText;

        public Golf_turnir()
        {
            InitializeComponent();
            Gt = this;
            rtbText = rtbIgraci;

        }

        private void Golf_turnir_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cbGrad.Text = "--svi--";
                cbTeren.Text = "--svi--";
                dateTimePickerDatum.Value = DateTime.Now;
                dateTimePickerVreme.Value = DateTime.Now;
                rtbIgraci.Text = "\n\n\t Prvi igrac : \n\n\t Drugi igrac :";

                SqlCommand grad = new SqlCommand(@"SELECT grad FROM Grad", conn);
                SqlDataReader greader = grad.ExecuteReader();
                while (greader.Read()) 
                {
                    cbGrad.Items.Add(greader[0].ToString());
                }
                greader.Dispose();
                grad.Dispose();

                SqlCommand teren = new SqlCommand(@"SELECT teren FROM Teren", conn);
                SqlDataReader treader = teren.ExecuteReader();
                while (treader.Read())
                {
                    cbTeren.Items.Add(treader[0].ToString());
                }
                treader.Dispose();
                teren.Dispose();

                /*Tab 2*/
                radioButtonZ.Checked = true;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Igrac1 f = new Igrac1();
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Igrac2 f = new Igrac2();
            f.Show();
        }

        private void btnZakazi_Click(object sender, EventArgs e)
        {
            if (
                cbGrad.Text != "--svi--" && cbTeren.Text != "--svi--" && !string.IsNullOrEmpty(Igrac1.igrac1) && !string.IsNullOrEmpty(Igrac2.igrac2)
                )
            {
                if (Convert.ToDateTime(dateTimePickerDatum.Value.ToString("yyyy.MM.dd")+" "+dateTimePickerVreme.Value.ToString("HH:mm:ss")) > DateTime.Now.AddDays(1))
                {


                    try
                    {
                        conn.Open();

                        string[] pom1 = Igrac1.igrac1.Split(new char[] { ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        string[] pom2 = Igrac2.igrac2.Split(new char[] { ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                        SqlCommand comm = new SqlCommand(@"INSERT INTO Partija (terenID,datum,vreme_pocetka,vreme_zavrsetka,prvi_igracID,drugi_igracID)	VALUES
	                                                        ((SELECT terenID FROM Teren WHERE teren=@teren),@datum,@vreme,NULL,@igrac1,@igrac2);", conn);
                        comm.Parameters.AddWithValue("@grad", cbGrad.Text);
                        comm.Parameters.AddWithValue("@teren", cbTeren.Text);
                        comm.Parameters.AddWithValue("@datum", dateTimePickerDatum.Value.ToString("yyyy.MM.dd"));
                        comm.Parameters.AddWithValue("@vreme", dateTimePickerVreme.Value.ToString("HH:mm"));
                        comm.Parameters.AddWithValue("@igrac1", pom1[0]);
                        comm.Parameters.AddWithValue("@igrac2", pom2[0]);
                        comm.ExecuteNonQuery();

                        MessageBox.Show("Uspesno zakazan mec!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbGrad.Text = "--svi--";
                        cbTeren.Text = "--svi--";
                        dateTimePickerDatum.Value = DateTime.Now;
                        dateTimePickerVreme.Value = DateTime.Now; 
                        rtbIgraci.Text = "\n\n\t Prvi igrac : \n\n\t Drugi igrac :";
                        Igrac1.igrac1 = "";
                        Igrac2.igrac2 = "";
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
                    MessageBox.Show("Morate zakazati mec najranije 24h pre pocetka!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Morate popuniti sva polja forme!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string selectedR;
                if (radioButtonO.Checked)
                    selectedR = "NOT NULL";
                else
                    selectedR = "NULL";
                SqlCommand comm = new SqlCommand(@"SELECT terenID AS TerenID,teren AS Teren,
                                                    (SELECT grad FROM Grad WHERE gradID=T.gradID) AS Grad,
                                                    (SELECT COUNT(*) FROM Partija WHERE terenID=T.terenID AND vreme_zavrsetka IS " + selectedR + @") AS Broj
                                                    FROM Teren AS T", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);

                if (adapter != null) 
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    GVTeren.DataSource = tabela;
                    GVTeren.Refresh();
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

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GVTeren_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (GVTeren.SelectedRows.Count > 0)
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    string selectedR;
                    if (radioButtonO.Checked)
                        selectedR = "NOT NULL";
                    else
                        selectedR = "NULL";
                    SqlCommand comm = new SqlCommand(@"SELECT (SELECT ime+' '+prezime FROM Igrac WHERE igracID=P.prvi_igracID)
                                                    +' vs '+
                                                    (SELECT ime+' '+prezime FROM Igrac WHERE igracID=P.drugi_igracID) AS Igraci,
                                                    datum AS Datum, vreme_pocetka AS 'Pocetkak',ISNULL(vreme_zavrsetka,'00:00') AS 'Zavrsetak'
                                                    FROM Partija AS P
                                                    WHERE terenID=@teren AND vreme_zavrsetka IS " + selectedR, conn);
                    comm.Parameters.AddWithValue("@teren", GVTeren.SelectedRows[0].Cells[0].Value.ToString());

                    SqlDataReader reader = comm.ExecuteReader();
                    DataTable tabela = new DataTable();
                    tabela.Columns.Add("Igraci", typeof(string));
                    tabela.Columns.Add("Datum", typeof(string));
                    tabela.Columns.Add("Pocetak", typeof(string));
                    tabela.Columns.Add("Zavrsetak", typeof(string));
                    while (reader.Read())
                    {
                        DataRow row = tabela.NewRow();
                        row[0] = reader[0].ToString();
                        row[1] = Convert.ToDateTime(reader[1].ToString()).ToString("dd.MM.yyyy");
                        row[2] = Convert.ToDateTime(reader[2].ToString()).ToString("HH:mm");
                        if (Convert.ToDateTime(reader[3].ToString()).ToString("HH:mm") == "00:00")
                            row[3] = "...";
                        else
                            row[3] = Convert.ToDateTime(reader[3].ToString()).ToString("HH:mm");
                        tabela.Rows.Add(row);
                    }
                    reader.Dispose();
                    comm.Dispose();
                    if (tabela != null)
                    {
                        GVPartija.DataSource = tabela;
                        GVPartija.Refresh();
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
            }
        }

        

       
    }
}
