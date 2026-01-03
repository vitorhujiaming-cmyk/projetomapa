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
    public partial class Islândia : Form
    {
        public Islândia()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string cidade = comboBox1.Text;

            if (cidade == "Reiquiavique")
            {
                Reiquiavique Reiquiavique = new Reiquiavique();
                Reiquiavique.Show();
                this.Hide();
            }
            else if (cidade == "Akureyri")
            {
                Akureyri Akureyri = new Akureyri();
                Akureyri.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            europa europa = new europa();
            europa.Show();
            this.Hide();
        }

        private void Islândia_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
