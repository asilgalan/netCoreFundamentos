using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace netCoreFundamentos
{
    public partial class Form03ColoresPosicion : Form
    {
        public Form03ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnMover_Click(object sender, EventArgs e)
        {

            int x = int.Parse(this.txtPosicionx.Text);
            int y = int.Parse(this.txtPosiciony.Text);
            this.cambiando.Location = new Point(x, y);


        }

        private void btnColor_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(int.Parse(this.textBox1.Text), int.Parse(this.txtVerde.Text), int.Parse(this.textBox2.Text));

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form03ColoresPosicion_Load(object sender, EventArgs e)
        {

        }
    }
}
