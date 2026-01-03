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
    public partial class europa : Form
    {
        public europa()
        {
            InitializeComponent();
        }

        private void europa_Load(object sender, EventArgs e)
        {

        }

        private void portugal_Click(object sender, EventArgs e)
        {
            Portugal portugal = new Portugal();
            portugal.Show();
            this.Hide();
        }

        private void espanha_Click(object sender, EventArgs e)
        {
            Espanha Espanha = new Espanha ();
            Espanha.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide ();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Suécia Suécia = new Suécia();
            Suécia.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Grécia Grécia = new Grécia();
            Grécia.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Irlanda Irlanda = new Irlanda();
            Irlanda.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Hungria hungria = new Hungria();
            hungria.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Bélgica Bélgica = new Bélgica();
            Bélgica.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Croácia Croácia = new Croácia();
            Croácia.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Noruega Noru = new Noruega();
            Noru.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Bulgária Bulgária = new Bulgária();
            Bulgária.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Estónia Estónia = new Estónia();
            Estónia.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Bósnia_e_Herzegovina bósnia_E_Herzegovina = new Bósnia_e_Herzegovina();
            bósnia_E_Herzegovina.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Dinamarca Dinamarca = new Dinamarca();
            Dinamarca.Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Roménia Roménia = new Roménia();
            Roménia.Show();
            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Letónia Letónia = new Letónia();
            Letónia.Show();
            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Áustria Áustria = new Áustria();
            Áustria.Show();
            this.Hide();
        }
    }
}
