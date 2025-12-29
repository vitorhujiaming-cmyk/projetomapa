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
    public partial class Roménia : Form
    {
        public Roménia()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string cidade = comboBox1.Text;

            if (cidade == "Bucareste")
            {
                Bucareste Bucareste = new Bucareste();
                Bucareste.Show();
                this.Hide();
            }
            else if (cidade == "Cluj-Napoca")
            {
                Cluj_Napoca Cluj_Napoca = new Cluj_Napoca();
                Cluj_Napoca.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            europa europa = new europa();
            europa.Show();
            this.Hide();
        }
    }
}
