using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Matura_Zadatak_A30
{
    public partial class Analiza : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=192.168.0.20;Initial Catalog=A30;User ID=SA;Password=sp@sic123.");

        public Analiza()
        {
            InitializeComponent();
            graph.ChartAreas[0].AxisX.Interval = 1;
            graph.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 25; i++)
            {
                cbTimeDO.Items.Add(i);
                cbTimeOD.Items.Add(i);
            }
        }

        private void Analiza_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tereni f = new Tereni();
            f.Show();
            this.Hide();
        }

        private void buttonPrikaz_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter a = new SqlDataAdapter(@"SELECT partijaID AS PartijaID,
                                                        (SELECT teren FROM Teren WHERE terenID = Partija.terenID) AS Teren, datum AS Datum,
                                                        (SELECT ((DATEPART(HOUR,Partija.vreme_zavrsetka)*60+DATEPART(HOUR,Partija.vreme_zavrsetka))-(DATEPART(HOUR,Partija.vreme_pocetka)*60+DATEPART(HOUR,Partija.vreme_pocetka)))) AS Trajanje
                                                        FROM Partija 
                                                        WHERE vreme_pocetka BETWEEN '12:00' AND '14:00'
                                                        ORDER BY Trajanje DESC, Teren ASC, partijaID ASC", conn);
                if (a != null)
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    GV.DataSource = t;
                    GV.Refresh();
                    for (int i = 0; i < GV.Rows.Count - 1; i++)
                    {
                        graph.Series[0].Points.AddXY(GV.Rows[i].Cells[1].Value, GV.Rows[i].Cells[3].Value);
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Tereni f = new Tereni();
            f.Show();
            this.Hide();
        }

        


    }
}
