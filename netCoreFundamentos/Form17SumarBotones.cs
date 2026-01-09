using System.Windows.Forms.VisualStyles;

namespace netCoreFundamentos;

public partial class Form17SumarBotones : Form
{
    List<Button> botones = new List<Button>();
    int suma = 0;
    private Boolean iniciado=false;

    public Form17SumarBotones()
    {
        

        InitializeComponent();
        foreach (Button btn in this.panel1.Controls) {
            this.botones.Add(btn);
        
                btn.Click += SumarNumeros;
            
         

        
        }
    }

    public void SumarNumeros(object sender, EventArgs e)
    {
      Button btnPulsado= (Button)sender;
      
      suma+=int.Parse(btnPulsado.Text);
      this.txtSuma.Text=suma.ToString();
  
    }
    private void btnIniciar_Click(object sender, EventArgs e) {
     iniciado = true;
        
     
        if (suma != 0) {
            this.txtSuma.Text ="";
            suma = 0;
            
        }
        
        Random random = new Random();
        
        foreach (Button btn in botones)
        {
            int aleatorio=random.Next(0,100);
            btn.Text = aleatorio.ToString();
            
        }
     
    }


}