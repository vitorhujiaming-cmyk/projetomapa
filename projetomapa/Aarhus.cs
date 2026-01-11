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
    public partial class Aarhus : Form
    {
        public Aarhus()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Dinamarca Dinamarca = new Dinamarca();   // Criar um novo forms "Dinamarca"
            Dinamarca.Show();       // Mostrar o forms "Dinamarca"
            this.Hide();        // Ocultar o forms atual
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ocultar as pictureBox e labels associados
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label2.Visible = false;
            label1.Visible = false;

            // Mostrar o botão 5 e oculta o botão 2
            button5.Visible = true;
            button2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Tornar visíveis as pictureBox e labels anteriormente ocultos
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            label2.Visible = true;
            label1.Visible = true;

            // Ocultar o botão 5 e volta a mostrar o botão 2
            button5.Visible = false;
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ocultar as pictureBox e labels associados
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            // Mostrar o botão 6 e oculta o botão 3
            button6.Visible = true;
            button3.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Tornar visíveis as pictureBox e labels anteriormente ocultos
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            // Ocultar o botão 6 e volta a mostrar o botão 3
            button6.Visible = false;
            button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Ocultar as pictureBox e labels associados
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            // Mostrar o botão 1 e oculta o botão 4
            button1.Visible = true;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tornar visíveis as pictureBox e labels anteriormente ocultos
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            // Ocultar o botão 1 e volta a mostrar o botão 4
            button1.Visible = false;
            button4.Visible = true;
        }

        private void Aarhus_Load(object sender, EventArgs e)
        {

        }
    }
}
