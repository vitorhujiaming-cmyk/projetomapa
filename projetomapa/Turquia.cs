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
    public partial class Turquia : Form
    {
        public Turquia()
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

            if (cidade == "Istambul")
            {
                Istambul Istambul = new Istambul();
                Istambul.Show();
                this.Hide();
            }
            else if (cidade == "Ancara")
            {
                Ancara Ancara = new Ancara();
                Ancara.Show();
                this.Hide();
            }
        }
    }
}
