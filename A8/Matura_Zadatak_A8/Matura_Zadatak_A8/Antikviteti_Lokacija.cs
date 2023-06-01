using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matura_Zadatak_A8
{
    public partial class Antikviteti_Lokacija : Form
    {
        public Antikviteti_Lokacija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipAntikviteta f = new TipAntikviteta();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Statistika f = new Statistika();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputstvo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
