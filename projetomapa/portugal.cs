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
    public partial class Portugal : Form
    {
        public Portugal()
        {
            InitializeComponent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }


        private void label1_Click(object sender, EventArgs e)
        {

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

            if (cidade == "Lisboa")
            {
                Lisboa lisboa = new Lisboa();
                lisboa.Show();
                this.Hide();
            }
            else if (cidade == "Porto")
            {
                Porto porto = new Porto();
                porto.Show();
                this.Hide();
            }
        }

        private void portugal_Load(object sender, EventArgs e)
        {

        }
    }
}
