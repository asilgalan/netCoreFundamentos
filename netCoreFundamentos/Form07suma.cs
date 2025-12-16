using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace netCoreFundamentos
{
    public partial class Form07suma : Form
    {
        public Form07suma()
        {
            InitializeComponent();
        }

        private void Form07suma_Load(object sender, EventArgs e)
        {

        }

        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder cadena = new StringBuilder(this.txtBox.Text);

            Console.WriteLine(Invertir(cadena).ToString());

            this.txtBox.Text = Invertir(cadena).ToString();
        }
        static StringBuilder Invertir(StringBuilder cadena, int cont = 0)
        {
            char temp;

            if (cont == cadena.Length / 2)
            {
                return cadena;
            }
            else
            {
                temp = cadena[cont];
                cadena[cont] = cadena[cadena.Length - 1 - cont];
                cadena[cadena.Length - 1 - cont] = temp;
                return Invertir(cadena, cont + 1);
            }


        }



        private void btnString_Click(object sender, EventArgs e)
        {

            Stopwatch krono = new Stopwatch();
            string cadena = this.txtBox.Text;
            int longitud = cadena.Length;
            krono.Start();
            for (int i = 0; i < longitud; i++){
                 char letra = cadena[longitud - 1];
                   cadena = cadena.Remove(longitud - 1, 1);

                cadena = cadena.Insert(i,letra.ToString());
            }
            this.txtBox.Text = cadena;
        }
    }
}
