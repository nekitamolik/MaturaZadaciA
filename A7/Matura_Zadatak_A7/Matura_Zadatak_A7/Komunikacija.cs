using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matura_Zadatak_A7
{
    public partial class Komunikacija : Form
    {
        public Komunikacija()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputstvo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            Grafik f = new Grafik();
            f.Show();
            this.Hide();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteForm f = new DeleteForm();
            f.Show();
            this.Hide();
        }
    }
}
