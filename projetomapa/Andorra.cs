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
    public partial class Andorra : Form
    {
        public Andorra()
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

            if (cidade == "Andorra la Vella")
            {
                Andorra_la_Vella Andorra_la_Vella = new Andorra_la_Vella();
                Andorra_la_Vella.Show();
                this.Hide();
            }
            else if (cidade == "Escaldes-Engordany")
            {
                Escaldes_Engordany Escaldes_Engordany = new Escaldes_Engordany();
                Escaldes_Engordany.Show();
                this.Hide();
            }
        }
    }
}
