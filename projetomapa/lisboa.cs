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
    public partial class lisboa : Form
    {
        public lisboa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            button1.Visible = false;
            button5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            button6.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button5.Visible = false;
            button1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            portugal portugal = new portugal();
            portugal.Show();
            this.Hide();
        }
    }
}
