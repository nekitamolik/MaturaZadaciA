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

namespace Matura_Zadatak_A2
{
    public partial class Autor : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=192.168.0.20;Initial Catalog=A2;User ID=SA;Password=sp@sic123.");

        public Autor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateListView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonBrisanje_Click(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("DELETE FROM AUTOR WHERE autorID = " + tbSifra.Text, conn);
                comm.ExecuteNonQuery();  
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            finally
            {
                conn.Close();
                updateListView();
            }
                
        }

        public void updateListView() 
        {
            try 
            {
                conn.Open();
                listView.Items.Clear();
                SqlCommand comm = new SqlCommand("SELECT autorID,ime,prezime,datum_rodjenja FROM Autor", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    ListViewItem row = new ListViewItem(reader[0].ToString());
                    row.SubItems.Add(reader[1].ToString());
                    row.SubItems.Add(reader[2].ToString());
                    row.SubItems.Add(reader[3].ToString());
                    listView.Items.Add(row);
                }
                reader.Dispose();
            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
               
            finally
            {
                conn.Close();
            }
        }

        private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
        {
            Analiza f = new Analiza();
            if (f == null)
            {
                f.Parent = this;
            }
            f.Show();
            this.Hide();
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kratko korisnicko uputstvo", "Uputstvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count != 0)
            {
                tbSifra.Text = listView.SelectedItems[0].Text;
                tbIme.Text = listView.SelectedItems[0].SubItems[1].Text;
                tbPrezime.Text = listView.SelectedItems[0].SubItems[2].Text;
                DateTime datum_rodjenja = DateTime.Parse(listView.SelectedItems[0].SubItems[3].Text);
                tbRodjen.Text = datum_rodjenja.ToShortDateString();
            }
        }


    }
}
