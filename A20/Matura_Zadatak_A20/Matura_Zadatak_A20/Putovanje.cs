using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matura_Zadatak_A20
{
    public partial class Putovanje : Form
    {
        public Putovanje()
        {
            InitializeComponent();
        }

        private void btnUplata_Click(object sender, EventArgs e)
        {
            Uplata f = new Uplata();
            if (f == null)
                f.Parent = this;
            f.Show();
            this.Hide();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            Pregled f = new Pregled();
            if (f == null)
                f.Parent = this;
            f.Show();
            this.Hide();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputstvo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
