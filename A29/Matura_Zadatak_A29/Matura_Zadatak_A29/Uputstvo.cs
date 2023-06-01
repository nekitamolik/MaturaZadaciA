using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matura_Zadatak_A29
{
    public partial class Uputstvo : Form
    {
        public Uputstvo()
        {
            InitializeComponent();
        }

        private void Uputstvo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Igraci f = new Igraci();
            f.Show();
            this.Hide();
        }
    }
}
