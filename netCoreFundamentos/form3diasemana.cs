using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace netCoreFundamentos
{
    public partial class form3diasemana : Form
    {
        public form3diasemana()
        {
            InitializeComponent();
        }

        private void mostrarDia_Click(object sender, EventArgs e)
        {
           
          
                int dia = int.Parse(txtdia.Text);
                int mes = int.Parse(txtmes.Text);
                int anio = int.Parse(txtanio.Text);

                DateTime fecha = new DateTime(anio, mes, dia);

         
                List<string> dias = new List<string>() {
                    "DOMINGO", "LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO"
                };
                int indice = (int)fecha.DayOfWeek;
                valordia.Text = dias[indice];
       
            
        }
    }
}