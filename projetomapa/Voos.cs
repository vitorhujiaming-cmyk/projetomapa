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
            dateTimePicker2.MinDate = dateTimePicker1.Value;

            // Lista de países disponíveis para seleção de partida e chegada
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
                    // Calcula o preço entre dois países
                    int preco = CalcularPreco(paises[i], paises[j]);

                    // Adiciona o preço à tabela de preços (para ida e volta)
                    AdicionarPreco(paises[i], paises[j], preco);
                }
            }
        }

        private int CalcularPreco(string pais1, string pais2)
        {
            int basePreco = 100;

            // Fatores baseados no comprimento do nome do país
            int fator1 = pais1.Length * 7;
            int fator2 = pais2.Length * 9;

            // Retorna o preço total somando base + fatores
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
            // Obtém o número de adultos e crianças a partir dos NumericUpDowns
            int numAdultos = (int)numericUpDown1.Value;
            int numCriancas = (int)numericUpDown2.Value;
            int numPassageiros = numAdultos + numCriancas;

            // Verifica se pelo menos um passageiro foi selecionado
            if (numAdultos + numCriancas == 0)
            {
                MessageBox.Show("Selecione pelo menos um passageiro.");
                return; // Interrompe a execução se não houver passageiros
            }

            // Verifica se a classe de voo foi selecionada no ComboBox
            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Selecione a classe de voo.");
                return;
            }

            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Selecione pelo menos uma opção: Ida e volta ou Só ida.");
                return; // impede que o cálculo continue
            }

            // Verifica se os dois países (partida e chegada) foram selecionados
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Selecione os dois países.");
                return;
            }

            // Converte os itens selecionados em strings
            string partida = comboBox1.SelectedItem.ToString();
            string chegada = comboBox2.SelectedItem.ToString();

            // Evita que o voo tenha mesma origem e destino
            if (partida == chegada)
            {
                MessageBox.Show("O ponto de partida não pode ser igual ao de chegada.");
                return;
            }

            // Verifica se a data do voo foi selecionada
            if (!dateTimePicker1.Checked)
            {
                MessageBox.Show("Selecione uma data para o voo.");
                return;
            }

            if (checkBox1.Checked && !dateTimePicker2.Checked)
            {
                MessageBox.Show("Selecione a data de retorno.");
                return;
            }

            // Obtém a data selecionada
            DateTime dataVoo = dateTimePicker1.Value;

            // Obtém o preço base do voo usando uma tabela de preços
            int preco = tabelaPrecos[partida + "-" + chegada];

            // Calcula preço total dos adultos
            double precoAdultos = numAdultos * preco;

            // Calcula preço das crianças (45% do preço do adulto)
            double precoCriancas = numCriancas * preco * 0.45;

            // Soma o total
            double precoTotal = precoAdultos + precoCriancas;

            // Multiplicador baseado na classe de voo
            string classe = comboBox3.SelectedItem.ToString();
            double multiplicadorClasse;

            // Define multiplicador conforme a classe
            switch (comboBox3.SelectedItem.ToString())
            {
                case "Económica":
                    multiplicadorClasse = 1.0;
                    break;
                case "Económica Premium":
                    multiplicadorClasse = 1.45;
                    break;
                case "Executiva":
                    multiplicadorClasse = 2.0;
                    break;
                case "Primeira Classe":
                    multiplicadorClasse = 4.0;
                    break;
                default:
                    multiplicadorClasse = 1.0;
                    break;
            }

            // Aplica multiplicador da classe ao preço total
            precoTotal *= multiplicadorClasse;

            // Fator de ajuste baseado na data (alta/baixa temporada)
            double fatorData = 1.0;

            // Define períodos de alta e média temporada
            DateTime ano2026 = new DateTime(2026, 1, 1);
            DateTime inicioAlta1 = new DateTime(2026, 1, 10);
            DateTime fimAlta1 = new DateTime(2026, 2, 10);

            DateTime inicioMedia1 = new DateTime(2026, 2, 11);
            DateTime fimMedia1 = new DateTime(2026, 5, 31);

            DateTime inicioAlta2 = new DateTime(2026, 6, 1);
            DateTime fimAlta2 = new DateTime(2026, 9, 1);

            DateTime inicioMedia2 = new DateTime(2026, 9, 2);
            DateTime fimMedia2 = new DateTime(2026, 11, 30);

            DateTime inicioAlta3 = new DateTime(2026, 12, 1);
            DateTime fimAlta3 = new DateTime(2027, 1, 10);

            // Ajusta fator de preço conforme a temporada
            if (dataVoo >= inicioAlta1 && dataVoo <= fimAlta1)
                fatorData = 2.0; // alta temporada (200%)
            else if (dataVoo >= inicioMedia1 && dataVoo <= fimMedia1)
                fatorData = 1.0; // média temporada (100%)
            else if (dataVoo >= inicioAlta2 && dataVoo <= fimAlta2)
                fatorData = 2.25; // alta temporada 2 (225%)
            else if (dataVoo >= inicioMedia2 && dataVoo <= fimMedia2)
                fatorData = 1.0; // média temporada 2 (100%)
            else if (dataVoo >= inicioAlta3 && dataVoo <= fimAlta3)
                fatorData = 2.0; // alta temporada 3 (200%)

            // Aplica fator de data ao preço total
            precoTotal *= fatorData;

            // Verifica se é Ida e Volta
            if (checkBox1.Checked)
            {
                precoTotal *= 1.85; // 185%

                if (dateTimePicker2.Value < dateTimePicker1.Value)
                {
                    MessageBox.Show("A data de volta não pode ser anterior à data de ida.");
                    return;
                }

            }

            // -------------------------------
            // Geração dos lugares dos passageiros
            // -------------------------------

            List<string> lugares = new List<string>(); // lista para armazenar os lugares

            // Gera um lugar para cada passageiro
            for (int i = 0; i < numPassageiros; i++)
            {
                int numero = random.Next(1, 51);         // número da fila 1 a 50
                char letra = (char)random.Next('A', 'G'); // letra do assento A-F

                string lugar = numero.ToString() + letra;

                // Garante que não haja lugares duplicados
                while (lugares.Contains(lugar))
                {
                    numero = random.Next(1, 51);
                    letra = (char)random.Next('A', 'G');
                    lugar = numero.ToString() + letra;
                }

                lugares.Add(lugar);
            }

            // Converte a lista de lugares em uma string separada por espaços
            string lugaresStr = string.Join(" | ", lugares);

            // Exibe os lugares no Label1
            label1.Text = lugaresStr;

            // -------------------------------
            // Geração do código do voo
            // -------------------------------

            char letra1 = (char)random.Next('A', 'Z' + 1);
            char letra2 = (char)random.Next('A', 'Z' + 1);
            int numero2 = random.Next(1000, 10000);

            // Exibe no Label2
            label2.Text = letra1.ToString() + letra2.ToString() + " " + numero2;

            // -------------------------------
            // Exibição do preço total
            // -------------------------------

            label3.Text = Math.Round(precoTotal, 1) + " €";

            // Desativa o botão/ícone após gerar os dados
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
            pictureBox4.Enabled = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox4.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox4.Enabled = true;
            // Garante que a data de volta não seja antes da data de ida
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            pictureBox4.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;  // desmarca a outra
                dateTimePicker2.Visible = true; // mostra segunda data
                label9.Visible=true;
            }
            else
            {
                dateTimePicker2.Visible = false; // esconde se não estiver marcada
            }
            pictureBox4.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false; // desmarca a outra
                dateTimePicker2.Visible = false;  // esconde segunda data
                label9.Visible = false;
            }
            pictureBox4.Enabled = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            pictureBox4.Enabled= true;
        }
    }
}
