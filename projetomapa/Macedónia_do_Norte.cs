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
    public partial class Macedónia_do_Norte : Form
    {
        public Macedónia_do_Norte()
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

            if (cidade == "Skopje")
            {
                Skopje Skopje = new Skopje();
                Skopje.Show();
                this.Hide();
            }
            else if (cidade == "Bitola")
            {
                Bitola Bitola = new Bitola();
                Bitola.Show();
                this.Hide();
            }
        }
    }
}
