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
    public partial class San_Marino : Form
    {
        public San_Marino()
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

            if (cidade == "San Marino")
            {
                cidade_San_Marino cidade_San_Marino = new cidade_San_Marino();
                cidade_San_Marino.Show();
                this.Hide();
            }
            else if (cidade == "Serravalle")
            {
                Serravalle Serravalle = new Serravalle();
                Serravalle.Show();
                this.Hide();
            }
        }
    }
}
