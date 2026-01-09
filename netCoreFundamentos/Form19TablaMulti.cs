namespace netCoreFundamentos;

public partial class Form19TablaMulti : Form
{
    private List<TextBox> lista = new List<TextBox>();
    private List<Button> boton = new List<Button>();
    private int contador = 0;
    public Form19TablaMulti()
    {
        InitializeComponent();
        contador = 0;
        
        Random rd=new Random();
        foreach (Control c in Controls){
            if (c is TextBox){
                lista.Add((TextBox)c );
                
            }else if (c is Button){
                c.Text=rd.Next(0,10).ToString();
                boton.Add((Button)c );
                c.Click+=tablamulti;
                
            }
        }
        
    }

    void tablamulti(object sender, EventArgs e)
    {
        Button click=sender as Button;
        this.lista.Reverse();
        foreach (TextBox tb in lista)
        {
            if (tb.Text != "") {
                tb.Text = "";
                contador = 0;
            } 
        }
   
        foreach (TextBox tb in lista){
            
                tb.Text = "";
                contador++;
                tb.Text = (contador * int.Parse(click.Text)).ToString();
        }
        

        
        
        
       
        


    }

  
    
}