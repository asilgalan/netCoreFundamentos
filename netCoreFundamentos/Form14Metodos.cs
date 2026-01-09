namespace netCoreFundamentos;

public partial class Form14Metodos : Form
{
    public Form14Metodos()
    {
        InitializeComponent();
    }

    int getDoble(int numero)
    {
        return numero * 2;
    }

    void cambiarColor(Button b)
    {
        b.BackColor = Color.Red;
    }

    void DoblePorReferencia(ref int numero)
    {
        numero = getDoble(numero);
    }


    private void btnDoble_Click(object sender, EventArgs e)
    {
        int numero = int.Parse(txtNumero.Text);
        
     
        
        this.resultado.Text= this.getDoble(numero).ToString();
        
    }

    private void btnObjecRef_Click(object sender, EventArgs e)
    {
 
        this.cambiarColor(this.btnDoble);
    }

    private void btnDobleRef_Click(object sender, EventArgs e) {
        int numero = int.Parse(txtNumero.Text);
        this.DoblePorReferencia(ref numero);
        
        this.resultado.Text= numero.ToString();
        
    }


    private void lblRaton_MouseMove(object sender, MouseEventArgs e)
    {
        this.lblRaton.Text="X: "+e.X+", Y:"+e.Y;
    }

    private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
    {
        char teclaBorrar=(char)Keys.Back;
        if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
        {
            e.Handled = true;
        }
    }

    private void txtSoloNumero_KeyPress(object sender, KeyPressEventArgs e)
    {
      char teclaBorrar=(char)Keys.Back;
      if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
      {
          e.Handled = true;
      }
    }
}