using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matura_Zadatak_A27
{
    public partial class Osiguranje : Form
    {
        public Osiguranje()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemModeli_Click(object sender, EventArgs e)
        {
            Modeli f = new Modeli();
            f.Show();
            this.Hide();
        }

        private void toolStripMenuItemPolise_Click(object sender, EventArgs e)
        {
            Polisa f = new Polisa();
            f.Show();
            this.Hide();
        }

        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputstvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void krajRadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
