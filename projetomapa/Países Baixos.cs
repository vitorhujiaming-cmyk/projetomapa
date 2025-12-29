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
    public partial class Países_Baixos : Form
    {
        public Países_Baixos()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string cidade = comboBox1.Text;

            if (cidade == "Amesterdão")
            {
                Amesterdão Amesterdão = new Amesterdão();
                Amesterdão.Show();
                this.Hide();
            }
            else if (cidade == "Roterdão")
            {
                Roterdão Roterdão = new Roterdão();
                Roterdão.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            europa europa = new europa();
            europa.Show();
            this.Hide();
        }
    }
}
