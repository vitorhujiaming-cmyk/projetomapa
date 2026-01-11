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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            europa europa = new europa();             // Criar um novo forms "europa"
            europa.Show();    // Mostrar o forms "europa" ao utilizador
            this.Hide();   // Ocultar o forms atual
        }

        private void voos_Click(object sender, EventArgs e)
        {
            Voos voos = new Voos();        // Criar um novo forms "Voos"
            voos.Show();         // Mostrar o forms "Voos" ao utilizador
            this.Hide();       // Ocultar o forms atual
        }



        // Devido à quantidade de forms existentes e à repetição dos códigos, decidimos comentar em apenas uma cidade (Aarhus) e um país (Albânia), pois os outros serão iguais em termos de código.
    }
}
