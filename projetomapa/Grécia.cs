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
    public partial class Grécia : Form
    {
        public Grécia()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            europa europa = new europa();
            europa.Show();
            this.Hide();
        }

        private void Grécia_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string cidade = comboBox1.Text;

            if (cidade == "Atenas")
            {
                Atenas Atenas= new Atenas();
                Atenas.Show();
                this.Hide();
            }
            else if (cidade == "Salónica")
            {
               Salónica Salónica = new Salónica();
                Salónica.Show();
                this.Hide();
            }
        }
    }
}
