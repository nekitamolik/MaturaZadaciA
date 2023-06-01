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
    public partial class Igrac1 : Form
    {

        SqlConnection conn = Golf_turnir.conn;

        public static string igrac1 = "";

        public Igrac1()
        {
            InitializeComponent();
        }

        private void Igrac1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(@"	SELECT igracID,ime+' '+prezime FROM Igrac", conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) 
                {
                    checkedListBoxIgraci.Items.Add("(" + reader[0].ToString() + ") " + reader[1].ToString(), false);
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

        private void btnPrviIgrac_Click(object sender, EventArgs e)
        {
            if (igrac1 == "")
            {
                if (checkedListBoxIgraci.CheckedItems.Count > 0)
                {
                    if (checkedListBoxIgraci.CheckedItems.Count == 1)
                    {
                        igrac1 = checkedListBoxIgraci.CheckedItems[0].ToString();
                        if (igrac1 != Igrac2.igrac2)
                        {
                            Golf_turnir.Gt.rtbText.Text = "\n\n\t Prvi igrac : " + igrac1 + " \n\n\t Drugi igrac :";
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Igrac ne moze igrati protiv samog sebe!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            igrac1 = "";
                        }
                    }

                    else
                        MessageBox.Show("Mozete izbarati samo jednog igraca!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                    MessageBox.Show("Izaberite igraca!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Zakazivanje u toku, morate zavrsiti trenutno zakazivanje kako bi zapoceli novo!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
