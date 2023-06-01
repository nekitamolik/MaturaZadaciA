using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matura_Zadatak_A28
{
    public partial class Stovariste : Form
    {
        public Stovariste()
        {
            InitializeComponent();
        }

        private void btnKupovina_Click(object sender, EventArgs e)
        {
            Kupovina f = new Kupovina();
            f.Show();
            this.Hide();
        }

        private void btnIsporuka_Click(object sender, EventArgs e)
        {
            Magacin f = new Magacin();
            f.Show();
            this.Hide();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputstvo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
