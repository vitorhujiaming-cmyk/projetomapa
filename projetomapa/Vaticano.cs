using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace projetomapa
{
    public partial class Vaticano : Form
    {
        public Vaticano()
        {
            InitializeComponent();
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

            if (cidade == "Cidade do Vaticano")
            {
                Cidade_do_Vaticano Cidade_do_Vaticano = new Cidade_do_Vaticano();
                Cidade_do_Vaticano.Show();
                this.Hide();
            }
        }

        private void Vaticano_Load(object sender, EventArgs e)
        {

        }
    }
}
