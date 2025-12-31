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
    public partial class Croácia : Form
    {
        public Croácia()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            europa europa = new europa();
            europa.Show();
            this.Hide();
        }

        private void Croácia_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string cidade = comboBox1.Text;

            if (cidade == "Zagreb")
            {
                Zagreb zagreb = new Zagreb();
                zagreb.Show();
                this.Hide();
            }
            else if (cidade == "Split")
            {
                Split split = new Split();
                split.Show();
                this.Hide();
            }
        }
    }
    }

