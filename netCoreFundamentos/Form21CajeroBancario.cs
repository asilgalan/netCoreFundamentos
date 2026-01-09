
using ProyectoClases;
namespace netCoreFundamentos;

public partial class Form21CajeroBancario : Form
{
    CuentaBancaria cuentaBancaria = new CuentaBancaria();
    public Form21CajeroBancario()
    {
        InitializeComponent();


    }

    private void btnIngresar_Click(object sender, EventArgs e)
    {
        try
        {
            cuentaBancaria.ingresar(int.Parse(textBox1.Text));
          this.saldo.Text=this.cuentaBancaria.saldo.ToString();
            this.listadoOperaciones.Items.Add("Ingresado :"+int.Parse(textBox1.Text) );
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
    
    }

    private void btnRetirar_Click(object sender, EventArgs e)
    {
        try
        {
            cuentaBancaria.retirar(int.Parse(textBox1.Text));
            this.saldo.Text=this.cuentaBancaria.saldo.ToString();
            this.listadoOperaciones.Items.Add("Retirar :"+int.Parse(textBox1.Text));
        }
        catch (Exception exception)
        {
         
            MessageBox.Show(exception.Message);
        }
     
    }
}