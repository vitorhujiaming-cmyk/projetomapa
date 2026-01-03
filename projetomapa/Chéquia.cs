using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projetomapa
{
    public partial class Chéquia : Form
    {
        public Chéquia()
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

            if (cidade == "Praga")
            {
                Praga Praga = new Praga();
                Praga.Show();
                this.Hide();
            }
            else if (cidade == "Brno")
            {
                Brno Brno = new Brno();
                Brno.Show();
                this.Hide();
            }
        }
    }
}
