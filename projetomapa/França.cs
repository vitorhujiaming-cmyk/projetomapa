using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetomapa
{
    public partial class França : Form
    {
        public França()
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

            if (cidade == "Paris")
            {
                Paris Paris = new Paris();
                Paris.Show();
                this.Hide();
            }
            else if (cidade == "Lyon")
            {
                Lyon Lyon = new Lyon();
                Lyon.Show();
                this.Hide();
            }
        }
    }
}
