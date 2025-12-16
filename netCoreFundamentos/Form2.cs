using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace netCoreFundamentos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            Double numero1 = Double.Parse(this.txtNumero1.Text);
            Double numero2 = Double.Parse(this.txtNumero2.Text);

            Double suma = numero1 + numero2;

            this.resultado.Text = suma.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
