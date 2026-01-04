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
    public partial class Ucrânia : Form
    {
        public Ucrânia()
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

            if (cidade == "Kiev")
            {
                Kiev Kiev = new Kiev();
                Kiev.Show();
                this.Hide();
            }
            else if (cidade == "Lviv")
            {
                Lviv Lviv = new Lviv();
                Lviv.Show();
                this.Hide();
            }
        }
    }
}
