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
    public partial class Polónia : Form
    {
        public Polónia()
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

            if (cidade == "Varsóvia")
            {
                Varsóvia Varsóvia = new Varsóvia();
                Varsóvia.Show();
                this.Hide();
            }
            else if (cidade == "Cracóvia")
            {
                Cracóvia Cracóvia = new Cracóvia();
                Cracóvia.Show();
                this.Hide();
            }
        }
    }
}
