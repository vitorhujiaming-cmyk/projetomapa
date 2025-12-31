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
    public partial class Irlanda : Form
    {
        public Irlanda()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            europa Europa = new europa();
            Europa.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string cidade = comboBox1.Text;

            if (cidade == "Dublin")
            {
               Dublin Dublin = new Dublin();
                Dublin.Show();
                this.Hide();
            }
            else if (cidade == "Cork")
            {
                Cork Cork= new Cork();
                Cork.Show();
                this.Hide();
            }
        }
    }
}
