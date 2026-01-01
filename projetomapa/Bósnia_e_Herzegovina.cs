using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetomapa
{
    public partial class Bósnia_e_Herzegovina : Form
    {
        public Bósnia_e_Herzegovina()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string cidade = comboBox1.Text;

            if (cidade == "Sarajevo")
            {
                Sarajevo Sarajevo = new Sarajevo();
                Sarajevo.Show();
                this.Hide();
            }
            else if (cidade == "Mostar")
            {
                Mostar Mostar = new Mostar();
                Mostar.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            europa europa = new europa();
            europa.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
