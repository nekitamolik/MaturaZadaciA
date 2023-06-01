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
    public partial class Igrac2 : Form
    {

        SqlConnection conn = Golf_turnir.conn;
        public static string igrac2 = "";

        public Igrac2()
        {
            InitializeComponent();
        }

        private void Igrac2_Load(object sender, EventArgs e)
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

        private void btnDrugiIgrac_Click(object sender, EventArgs e)
        {
            if (igrac2 == "")
            {
                if (checkedListBoxIgraci.CheckedItems.Count > 0)
                {
                    if (checkedListBoxIgraci.CheckedItems.Count == 1)
                    {
                        igrac2 = checkedListBoxIgraci.CheckedItems[0].ToString();
                        if (igrac2 != Igrac1.igrac1)
                        {
                            Golf_turnir.Gt.rtbText.Text += " " + igrac2;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Igrac ne moze igrati protiv samog sebe!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            igrac2 = "";
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
