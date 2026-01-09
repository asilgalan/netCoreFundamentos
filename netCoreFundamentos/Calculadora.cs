using System.Globalization;

namespace netCoreFundamentos;

public partial class Calculadora : Form
{
    
    List<string> listaNumeros=new List<string>();

    string numeroActual = "";
    public Calculadora()
    {
        InitializeComponent();
        foreach (Button btn in this.panel1.Controls.OfType<Button>()){
      
            if (btn.Text != "=") 
            {
                btn.Click += clickButton;
            }
            
            
        }
   
    }

    public void clickButton(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        string texto = btn.Text; 

      
        if (texto == "C"){
            this.listaNumeros.Clear();
            this.txtNumero.Text = "";
            this.numeroActual = "";
        }
    
        else if (texto == "+" || texto == "-" || texto == "*" || texto == "/")
        {
            if (numeroActual != "")
            {
                listaNumeros.Add(numeroActual);
                numeroActual = "";
            }
            
            listaNumeros.Add(texto);
            this.txtNumero.Text += texto;
        }
 
        else
        {
          
            numeroActual += texto;
            this.txtNumero.Text += texto;
        }
    }
    
    private void button11_Click(object sender, EventArgs e) {
        if (numeroActual != "") 
        {
            listaNumeros.Add(numeroActual);
            numeroActual = "";
        }
        double resultado = 0;
        for (int i = 1; i < listaNumeros.Count - 1; i++){
            string simbolo = listaNumeros[i];


         
            if (simbolo == "+" || simbolo == "-" || simbolo == "*" || simbolo == "/") {
     
                double numero1 = double.Parse(listaNumeros[i - 1],CultureInfo.InvariantCulture);
                double numero2 = double.Parse(listaNumeros[i + 1],CultureInfo.InvariantCulture); 

                switch (simbolo) {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        break;
                    case "/":
               
                        resultado = numero1 / numero2;
                        break;
                }
            
         
                listaNumeros.RemoveAt(i + 1); 
                listaNumeros.RemoveAt(i);
                listaNumeros.RemoveAt(i - 1);
                listaNumeros.Insert(i - 1, resultado.ToString(CultureInfo.InvariantCulture));
                
               
            
           
                i = i - 1;
            }
        }
        
    
        if (listaNumeros.Count > 0)
        {
            
            this.txtNumero.Text =listaNumeros[0]; 
        }
    }

    

    
    }
    
  

