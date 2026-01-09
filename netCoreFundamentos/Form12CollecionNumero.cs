namespace netCoreFundamentos;

public partial class Form12CollecionNumero : Form
{
    public Form12CollecionNumero()
    {
        InitializeComponent();
    }


    private void btnGenerar_Click(object sender, EventArgs e)
    {
    
        this.listBox1.Items.Clear();
        Random random = new Random();

        for (int i = 0; i < 10; i++)
            
        {
            
            this.listBox1.Items.Add(random.Next(100));
            
        }
    }

    private void btnMostrar_Click(object sender, EventArgs e)
    {


        int suma = 0;
        int sumapar = 0;
        int sumainpar = 0;


        foreach (int i  in this.listBox1.Items)
        {
            if (i % 2 == 0)
            {
                sumapar += i;
            }
            else
            {
                sumainpar += i;
            }

            suma += i;
        }
     

        
        this.txtsuma.Text=suma.ToString();
        this.txtPar.Text=sumapar.ToString();
        this.txtImpare.Text=sumainpar.ToString();
   
    }
}