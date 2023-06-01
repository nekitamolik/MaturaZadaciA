using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matura_Zadatak_A23
{
    public partial class Pozoriste : Form
    {
        public Pozoriste()
        {
            InitializeComponent();
        }

        private void toolStripButtonRegistracija_Click(object sender, EventArgs e)
        {
            Logovanje f = new Logovanje();
            f.Show();
            this.Hide();
        }

        private void toolStripButtonRepertoar_Click(object sender, EventArgs e)
        {
            Repertoar f = new Repertoar();
            f.Show();
            this.Hide();
        }

        private void toolStripButtonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uputstvo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
