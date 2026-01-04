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
    public partial class Liechtenstein : Form
    {
        public Liechtenstein()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            europa europa = new europa();
            europa.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string cidade = comboBox1.Text;

            if (cidade == "Vaduz")
            {
                Vaduz Vaduz = new Vaduz();
                Vaduz.Show();
                this.Hide();
            }
            else if (cidade == "Schaan")
            {
                Schaan Schaan = new Schaan();
                Schaan.Show();
                this.Hide();
            }
        }
    }
}
