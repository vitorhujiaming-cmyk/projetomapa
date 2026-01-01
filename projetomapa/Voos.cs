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
    public partial class Voos : Form
    {
        Dictionary<string, int> tabelaPrecos = new Dictionary<string, int>();

        Random random = new Random();
        public Voos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Voos_Load(object sender, EventArgs e)
        {
            string[] paises =
{
        "Albânia","Alemanha","Andorra","Áustria","Bélgica",
        "Bósnia e Herzegovina","Bulgária","Chipre","Chéquia",
        "Croácia","Dinamarca","Eslováquia","Eslovénia","Espanha",
        "Estónia","Finlândia","França","Grécia","Hungria",
        "Irlanda","Islândia","Itália","Kosovo","Letónia",
        "Liechtenstein","Lituânia","Luxemburgo",
        "Macedónia do Norte","Malta","Moldávia","Mónaco",
        "Montenegro","Noruega","Países Baixos","Polónia",
        "Portugal","Reino Unido","Roménia","San Marino",
        "Sérvia","Suécia","Suíça","Ucrânia","Vaticano"
    };
            GerarTodosOsPrecos(paises);
        }


        private void GerarTodosOsPrecos(string[] paises)
        {
            for (int i = 0; i < paises.Length; i++)
            {
                for (int j = i + 1; j < paises.Length; j++)
                {
                    int preco = CalcularPreco(paises[i], paises[j]);
                    AdicionarPreco(paises[i], paises[j], preco);
                }
            }
        }

        private int CalcularPreco(string pais1, string pais2)
        {
            int basePreco = 100;

            int fator1 = pais1.Length * 7;
            int fator2 = pais2.Length * 9;

            return basePreco + fator1 + fator2;
        }


        private void AdicionarPreco(string pais1, string pais2, int preco)
        {
            tabelaPrecos[pais1 + "-" + pais2] = preco;
            tabelaPrecos[pais2 + "-" + pais1] = preco;
        }





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
         menu menu = new menu();
            menu.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Selecione os dois países.");
                return;
            }

            string partida = comboBox1.SelectedItem.ToString();
            string chegada = comboBox2.SelectedItem.ToString();

            if (partida == chegada)
            {
                MessageBox.Show("O ponto de partida não pode ser igual ao de chegada.");
                return;
            }

            if (!dateTimePicker1.Checked)
            {
                MessageBox.Show("Selecione uma data para o voo.");
                return;
            }

            int preco = tabelaPrecos[partida + "-" + chegada];


            // ----- Label 1 -----
            int numero1 = random.Next(1, 51);
            char letraAF = (char)random.Next('A', 'G');

            label1.Text = numero1 + " " + letraAF.ToString();
            // ----- Label 2 -----
            char letra1 = (char)random.Next('A', 'Z' + 1);
            char letra2 = (char)random.Next('A', 'Z' + 1);
            int numero2 = random.Next(1000, 10000);

            label2.Text = letra1.ToString() + letra2.ToString() + " " + numero2;

            label3.Text = "O preço do bilhete de avião é " + preco + " euros";

            pictureBox4.Enabled = false;
        }



        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pictureBox4.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox4.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
