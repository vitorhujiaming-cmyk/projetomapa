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
    public partial class Alemanha : Form
    {
        public Alemanha()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string cidade = comboBox1.Text;

            if (cidade == "Berlim")
            {
                Berlim Berlim = new Berlim();
                Berlim.Show();
                this.Hide();
            }
            else if (cidade == "Munique")
            {
                Munique Munique = new Munique();
                Munique.Show();
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
    
