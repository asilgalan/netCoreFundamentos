using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;

namespace netCoreFundamentos;

public partial class Form16ListDelegado : Form
{
     protected int contador;
     int contadorbotones = 0;
     int contadorganador=0;
     List<Button> botones = new List<Button>();
     public Form16ListDelegado()
     {

         contador = 0;
         InitializeComponent();
      

         foreach (Control c in this.Controls)
         {
             if (c is Button && this.btnReset.Name!=c.Name)
             {
                 c.Text="Presiona";
                 botones.Add((Button)c);
             }
         }
    
         foreach (Button boton in botones)
         {
             boton.Click += PulsarButton_Click;
         }
     }

     private void PulsarButton_Click(object sender, EventArgs e){
            
         Button botonPresionado = (Button)sender;
         
         if(botonPresionado.BackColor == Color.Blue ||  botonPresionado.BackColor == Color.Red)return;
         
            this.contador++;
            this.contadorbotones++;
            
     
            
            
            List<Button> botonesList =new List<Button>()
            {
                botonPresionado
            };
         

            foreach (Button boton in botonesList)
            {
                if (contadorbotones % 2 == 0)
                {
                    boton.BackColor = Color.Red;
                    boton.Text = "X";
                }
                else{
                    foreach (Control control in this.Controls){
                        if (boton == control){
                            boton.Text = "Y";
                            control.BackColor = Color.Blue;
                        }
                        
                       
                    }
                 
                   
                }
                
             Ganador();


                if (contadorbotones == this.botones.Count+1)
                {
                  
                    foreach (Control control in this.Controls)
                    {
                        control.BackColor = Color.White;
                       
                    }

                        this.contadorbotones = 0;
                }
            }
            

        }


        public void Ganador()
        {
            int[,] posicionesganadoras = new int[,]
            {
                {0,1,2},{3,4,5},{6,7,8},
                {0,3,6},{1,4,7},{2,5,8},
                {0,4,8},{2,4,6}
            };

            for (int i = 0; i < posicionesganadoras.GetLength(0); i++) {
                
                int a=posicionesganadoras[i, 0];
                int b=posicionesganadoras[i, 1];
                int c=posicionesganadoras[i, 2];

                if (botones[a].BackColor != SystemColors.Control && botones[a].BackColor == botones[b].BackColor &&
                    botones[a].BackColor == botones[c].BackColor && botones[a].BackColor.Name!="White" )
                {
                    this.label1.Text=" El Color " + botones[a].BackColor.Name+" es el ganador";

                    foreach (Control control in this.Controls)
                    {
                        if (control.Name != this.btnReset.Name)
                        {
                            control.Enabled=false;
                        }
                    }
                }
                
            }

        }

        private void btnReset_Click(object sender, EventArgs e){
            foreach (Control control in this.Controls) {
                if (control.Name != this.btnReset.Name) {
                    control.Enabled=true;
                    control.BackColor = Color.White;
                    this.contador=0;
                    this.contadorbotones=0;
                     control.Text = "Presiona";
                    this.label1.Text = "";
                }
            }

          
        }

      
}