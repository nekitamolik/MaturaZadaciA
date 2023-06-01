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

namespace Matura_Zadatak_A28
{
    public partial class Magacin : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A28;User ID=SA;Password=sp@sic123.");

        public Magacin()
        {
            InitializeComponent();
            dateTimePickerOD.Value = DateTime.Now;
            dateTimePickerDO.Value = DateTime.Now.AddDays(10);
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            try 
            {
                listViewPregled.Items.Clear();
                conn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT * FROM
                                                    (SELECT 
                                                    (SELECT proizvod FROM Proizvod WHERE proizvodID=SP.proizvodID) AS Proizvod,
                                                    (SELECT (SELECT jedinica_mere FROM Jedinica_Mere WHERE jedinica_mereID = P.jedinicaID) 
	                                                    FROM Proizvod AS P WHERE proizvodID=SP.proizvodID) AS 'Jedinica Mere',
                                                    (SELECT jedinica_na_stanju FROM Proizvod WHERE proizvodID=SP.proizvodID) AS 'Zaliha' ,
                                                    SUM(kolicina) AS 'Poruceno'
                                                    FROM Stavke_Porudzbine AS SP
                                                    WHERE
                                                    (SELECT datum_porucivanja FROM Porudzbina WHERE porudzbinaID=SP.porudzbinaID ) BETWEEN @od AND @do
                                                    GROUP BY proizvodID) AS T 
                                                    WHERE T.Poruceno>T.Zaliha;", conn);
                comm.Parameters.AddWithValue("@od", dateTimePickerOD.Value.ToString("yyyy.MM.dd"));
                comm.Parameters.AddWithValue("@do", dateTimePickerDO.Value.ToString("yyyy.MM.dd"));
                SqlDataReader reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    ListViewItem row = new ListViewItem(reader[0].ToString());
                    row.SubItems.Add(reader[1].ToString());
                    row.SubItems.Add(reader[2].ToString());
                    row.SubItems.Add(reader[3].ToString());
                    listViewPregled.Items.Add(row);
                }
                reader.Dispose();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Stovariste f = new Stovariste();
            f.Show();
            this.Hide();
        }
    }
}
