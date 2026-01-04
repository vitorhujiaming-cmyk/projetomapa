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
    public partial class Malta : Form
    {
        public Malta()
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

            if (cidade == "Valeta")
            {
                Valeta Valeta = new Valeta();
                Valeta.Show();
                this.Hide();
            }
            else if (cidade == "Mdina")
            {
                Mdina Mdina = new Mdina();
                Mdina.Show();
                this.Hide();
            }
        }
    }
}
