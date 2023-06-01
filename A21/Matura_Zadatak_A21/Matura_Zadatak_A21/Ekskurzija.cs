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


namespace Matura_Zadatak_A21
{
    public partial class Ekskurzija : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A21;User ID=SA;Password=sp@sic123.");

        public Ekskurzija()
        {
            InitializeComponent();
        }

        private void Ekskurzija_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT naziv_mesta,drzava FROM Destinacija", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    cbDestinacija.Items.Add(reader[0].ToString() + ", " + reader[1].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewEkskurzije.SelectedItems.Count == 1)
                {
                    conn.Open();
                    string[] dani = new string[7];
                    bool izmena = false;
                    SqlCommand exists = new SqlCommand(@"SELECT (SELECT dan FROM Dani WHERE danID = RO.danID) FROM Raspored_Obilazaka AS RO WHERE ponudaID=@id", conn);
                    exists.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                    SqlDataReader reader = exists.ExecuteReader();
                    int i = 0;
                    while (reader.Read()) 
                    {
                        dani[i] = reader[0].ToString();
                        i++;
                    }
                    reader.Dispose();
                    exists.Dispose();
                    bool Pon = false, Uto = false, Sre = false, Cet = false, Pet = false, Sub = false, Ned = false;
                    foreach (string x in dani) 
                    {
                        switch (x)
                        {
                            case "Ponedeljak": Pon = true; break;
                            case "Utorak": Uto = true; break;
                            case "Sreda": Sre = true; break;
                            case "Cetvrtak": Cet = true; break;
                            case "Petak": Pet = true; break;
                            case "Subota": Sub = true; break;
                            case "Nedelja": Ned = true; break;
                        }
                    }
                    if (cbPon.Checked && Pon == false)
                    {
                        SqlCommand PonUpis = new SqlCommand(@"INSERT INTO Raspored_Obilazaka (danID,ponudaID) VALUES ((SELECT danID FROM Dani WHERE dan='Ponedeljak'),@id)", conn);
                        PonUpis.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        PonUpis.ExecuteNonQuery();
                        izmena = true;
                    }
                    else if(cbPon.Checked == false && Pon == true)
                    {
                        SqlCommand PonDel = new SqlCommand(@"DELETE FROM Raspored_Obilazaka WHERE ponudaID=@id AND danID=(SELECT danID FROM Dani WHERE dan='Ponedeljak');", conn);
                        PonDel.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        PonDel.ExecuteNonQuery();
                        izmena = true;
                    }
                    if (cbUto.Checked && Uto == false)
                    {
                        SqlCommand UtoUpis = new SqlCommand(@"INSERT INTO Raspored_Obilazaka (danID,ponudaID) VALUES ((SELECT danID FROM Dani WHERE dan='Utorak'),@id)", conn);
                        UtoUpis.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        UtoUpis.ExecuteNonQuery();
                        izmena = true;
                    }
                    else if (cbUto.Checked == false && Uto == true)
                    {
                        SqlCommand UtoDel = new SqlCommand(@"DELETE FROM Raspored_Obilazaka WHERE ponudaID=@id AND danID=(SELECT danID FROM Dani WHERE dan='Utorak');", conn);
                        UtoDel.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        UtoDel.ExecuteNonQuery();
                        izmena = true;
                    }
                    if (cbSre.Checked && Sre == false)
                    {
                        SqlCommand SreUpis = new SqlCommand(@"INSERT INTO Raspored_Obilazaka (danID,ponudaID) VALUES ((SELECT danID FROM Dani WHERE dan='Sreda'),@id)", conn);
                        SreUpis.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        SreUpis.ExecuteNonQuery();
                        izmena = true;
                    }
                    else if (cbSre.Checked == false && Sre == true)
                    {
                        SqlCommand SreDel = new SqlCommand(@"DELETE FROM Raspored_Obilazaka WHERE ponudaID=@id AND danID=(SELECT danID FROM Dani WHERE dan='Sreda');", conn);
                        SreDel.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        SreDel.ExecuteNonQuery();
                        izmena = true;
                    }
                    if (cbCet.Checked && Cet == false)
                    {
                        SqlCommand CetUpis = new SqlCommand(@"INSERT INTO Raspored_Obilazaka (danID,ponudaID) VALUES ((SELECT danID FROM Dani WHERE dan='Cetvrtak'),@id)", conn);
                        CetUpis.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        CetUpis.ExecuteNonQuery();
                        izmena = true;
                    }
                    else if (cbCet.Checked == false && Cet == true)
                    {
                        SqlCommand CetDel = new SqlCommand(@"DELETE FROM Raspored_Obilazaka WHERE ponudaID=@id AND danID=(SELECT danID FROM Dani WHERE dan='Cetvrtak');", conn);
                        CetDel.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        CetDel.ExecuteNonQuery();
                        izmena = true;
                    }
                    if (cbPet.Checked && Pet == false)
                    {
                        SqlCommand PetUpis = new SqlCommand(@"INSERT INTO Raspored_Obilazaka (danID,ponudaID) VALUES ((SELECT danID FROM Dani WHERE dan='Petak'),@id)", conn);
                        PetUpis.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        PetUpis.ExecuteNonQuery();
                        izmena = true;
                    }
                    else if (cbPet.Checked == false && Pet == true)
                    {
                        SqlCommand PetDel = new SqlCommand(@"DELETE FROM Raspored_Obilazaka WHERE ponudaID=@id AND danID=(SELECT danID FROM Dani WHERE dan='Petak');", conn);
                        PetDel.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        PetDel.ExecuteNonQuery();
                        izmena = true;
                    }
                    if (cbSub.Checked && Sub == false)
                    {
                        SqlCommand SubUpis = new SqlCommand(@"INSERT INTO Raspored_Obilazaka (danID,ponudaID) VALUES ((SELECT danID FROM Dani WHERE dan='Subota'),@id)", conn);
                        SubUpis.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        SubUpis.ExecuteNonQuery();
                        izmena = true;
                    }
                    else if (cbSub.Checked == false && Sub == true)
                    {
                        SqlCommand SubDel = new SqlCommand(@"DELETE FROM Raspored_Obilazaka WHERE ponudaID=@id AND danID=(SELECT danID FROM Dani WHERE dan='Subota');", conn);
                        SubDel.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        SubDel.ExecuteNonQuery();
                        izmena = true;
                    }
                    if (cbNed.Checked && Ned == false)
                    {
                        SqlCommand NedUpis = new SqlCommand(@"INSERT INTO Raspored_Obilazaka (danID,ponudaID) VALUES ((SELECT danID FROM Dani WHERE dan='Nedelja'),@id)", conn);
                        NedUpis.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        NedUpis.ExecuteNonQuery();
                        izmena = true;
                    }
                    else if (cbNed.Checked == false && Ned == true)
                    {
                        SqlCommand NedDel = new SqlCommand(@"DELETE FROM Raspored_Obilazaka WHERE ponudaID=@id AND danID=(SELECT danID FROM Dani WHERE dan='Nedelja');", conn);
                        NedDel.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                        NedDel.ExecuteNonQuery();
                        izmena = true;
                    }
                    if(izmena)
                        MessageBox.Show("Raspored izvodjenja ekskurzije je izmenjen!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Niste uneli izmene kako bi se raspored izmenio!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbDestinacija_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                listViewEkskurzije.Items.Clear();
                string[] pom = cbDestinacija.SelectedItem.ToString().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                SqlCommand comm = new SqlCommand(@"SELECT ponudaID,(SELECT naziv FROM Dodatni_Obilazak WHERE obilazakID=PE.obilazakID),cena
                                                    FROM Ponuda_Ekskurzija AS PE
                                                    WHERE destinacijaID=(SELECT destinacijaID FROM Destinacija WHERE naziv_mesta=@mesto AND drzava=@drzava);", conn);
                comm.Parameters.AddWithValue("@mesto", pom[0]);
                comm.Parameters.AddWithValue("@drzava", pom[1]);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem row = new ListViewItem(reader[0].ToString());
                    row.SubItems.Add(reader[1].ToString());
                    row.SubItems.Add(reader[2].ToString());
                    listViewEkskurzije.Items.Add(row);
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

        private void listViewEkskurzije_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewEkskurzije.SelectedItems.Count > 0)
                {
                    conn.Open();
                    cbPon.Checked = false;
                    cbUto.Checked = false;
                    cbSre.Checked = false;
                    cbCet.Checked = false;
                    cbPet.Checked = false;
                    cbSub.Checked = false;
                    cbNed.Checked = false;
                    SqlCommand comm = new SqlCommand(@"SELECT (SELECT dan FROM Dani WHERE danID=RO.danID) FROM Raspored_Obilazaka AS RO WHERE ponudaID=@id", conn);
                    comm.Parameters.AddWithValue("@id", listViewEkskurzije.SelectedItems[0].SubItems[0].Text);
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        switch (reader[0].ToString())
                        {
                            case "Ponedeljak": cbPon.Checked = true; break;
                            case "Utorak": cbUto.Checked = true; break;
                            case "Sreda": cbSre.Checked = true; break;
                            case "Cetvrtak": cbCet.Checked = true; break;
                            case "Petak": cbPet.Checked = true; break;
                            case "Subota": cbSub.Checked = true; break;
                            case "Nedelja": cbNed.Checked = true; break;
                        }

                    }
                    reader.Dispose();
                    comm.Dispose();
                    if (!cbPon.Checked && !cbUto.Checked && !cbSre.Checked && !cbCet.Checked && !cbPet.Checked && !cbSub.Checked && !cbNed.Checked)
                        MessageBox.Show("Ekskurzija se trenutno ne izvodi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Ekskurzija_FormClosed(object sender, FormClosedEventArgs e)
        {
            Putovanja f = new Putovanja();
            f.Show();
            this.Hide();
        }
    }
}
