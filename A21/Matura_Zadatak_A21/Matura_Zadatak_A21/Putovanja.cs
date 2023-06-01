using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matura_Zadatak_A21
{
    public partial class Putovanja : Form
    {
        public Putovanja()
        {
            InitializeComponent();
        }

        private void btnEkskurzija_Click(object sender, EventArgs e)
        {
            Ekskurzija f = new Ekskurzija();
            if (f == null)
                f.Parent = this;
            f.Show();
            this.Hide();
        }

        private void btnAnaliza_Click(object sender, EventArgs e)
        {
            Analiza f = new Analiza();
            if (f == null)
                f.Parent = this;
            f.Show();
            this.Hide();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputstvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        
    }
}
