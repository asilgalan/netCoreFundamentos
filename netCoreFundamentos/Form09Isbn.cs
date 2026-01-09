using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace netCoreFundamentos
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void Form09Isbn_Load(object sender, EventArgs e)
        {

        }


        private void btnComprobar_Click(object sender, EventArgs e)
        {
            string isbn = this.txtISBN.Text;

            if (isbn.Length != 10) {
                MessageBox.Show("Ingrese una ISBN de 10 caracteres");
                WriteLine("Ingrese una ISBN de 10 caracteres");
            }
            else
            {

                int suma = 0;

                for (int i = 0; i < isbn.Length; i++)
                {
                    char letra = isbn[i];
                    int numero = int.Parse(letra.ToString());
                    int multi = numero * (i + i);
                    suma += multi;
                    
                }

                if (suma % 11 == 0)
                {
                    MessageBox.Show("BUEN ISBN");
                }
                else
                {
                    MessageBox.Show("MAL ISBN");
                    
                }

            }
        }
    }
}
