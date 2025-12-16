using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace netCoreFundamentos
{
    public partial class Form06email : Form
    {
        public Form06email()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            error.Text = "";
            string email = txtEmail.Text;
            int largo = email.Length;
            var arrobas = email.Where(c => c == '@').ToList();
            int punto = email.IndexOf(".");
            int arroba = email.IndexOf("@");

            int comprobarpunto = (largo - punto)-1;

            if (email.StartsWith("@") || email.EndsWith("@")){

                error.Text = "no puede comenzar ni terminar con @";

                return;
            }else if (!email.Contains("@")) {
                error.Text = "falta el @";
                return;

            } else if (arrobas.Count > 1) {
                error.Text = "demasiados @ solo tiene que ser 1";

                return;
            } else if (!email.Contains(".")) {
                error.Text = "falta el punto";

            } else if (comprobarpunto < 2 || comprobarpunto > 3) {
                error.Text = "dominio mal" +comprobarpunto;
                return;

            } else if (arroba > punto) {
                error.Text = "punto mal colocado";
                return;

            } 
        
        }
    }
}
