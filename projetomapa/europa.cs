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
            portugal portugal = new portugal();
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
    }
}
