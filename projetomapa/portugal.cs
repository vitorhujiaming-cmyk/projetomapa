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
    public partial class portugal : Form
    {
        public portugal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cidade = comboBox1.Text;

            if (cidade == "Lisboa")
            {
                lisboa lisboa = new lisboa();
                lisboa.Show();
                this.Hide();
            }
            else if (cidade == "Porto")
            {
                porto porto = new porto();
                porto.Show();
                this.Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
           europa europa = new europa();
            europa.Show();
            this.Hide();
        }
    }
}
