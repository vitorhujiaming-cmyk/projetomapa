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
    public partial class Albânia : Form
    {
        public Albânia()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            // Obter o texto atualmente selecionado na comboBox1 (nome da cidade)
            string cidade = comboBox1.Text;

            // Verificar se a cidade selecionada é "Tirana"
            if (cidade == "Tirana")
            {
                Tirana Tirana = new Tirana();  // Criar um novo forms "Tirana"
                Tirana.Show();    // Mostrar o forms "Tirana"
                this.Hide();   // Ocultar o forms atual
            }

            // Verificar se a cidade selecionada é "Durrës"
            else if (cidade == "Durrës")
            {
                Durrës Durrës = new Durrës();   // Cria um novo forms "Durrës"
                Durrës.Show();   // Mostrar o forms "Durrës"
                this.Hide();    // Ocultar o forms atual
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            europa europa = new europa();    // Criar um novo forms "europa"
            europa.Show();     // Mostrar o forms "europa"
            this.Hide();    // Ocultar o forms atual
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Albânia_Load(object sender, EventArgs e)
        {

        }
    }
}
