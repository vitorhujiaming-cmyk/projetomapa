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
    public partial class Dinamarca : Form
    {
        public Dinamarca()
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

            if (cidade == "Copenhaga")
            {
                Copenhaga Copenhaga = new Copenhaga();
                Copenhaga.Show();
                this.Hide();
            }
            else if (cidade == "Aarhus")
            {
                Aarhus Aarhus = new Aarhus();
                Aarhus.Show();
                this.Hide();
            }
        }
    }
}
