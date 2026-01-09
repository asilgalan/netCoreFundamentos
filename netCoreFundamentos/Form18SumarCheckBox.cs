namespace netCoreFundamentos;

public partial class Form18SumarCheckBox : Form
{
    List<CheckBox> checkBoxes = new List<CheckBox>();
    int suma = 0;
    public Form18SumarCheckBox()
    {
        InitializeComponent();

        foreach (CheckBox checkBox in this.panel1.Controls)
        {
            this.checkBoxes.Add(checkBox);
            
                checkBox.CheckedChanged += sumarCheckbox;
                
        }

        
    }

    void sumarCheckbox(object sender, EventArgs e)
    {
       Random random = new Random();
        CheckBox checkBox = (CheckBox)sender;

        if (checkBox.Checked==true)
        {
            suma+=int.Parse(checkBox.Text);
            this.txtSuma.Text=suma.ToString(); 
        }
        else
        {
            suma-=int.Parse(checkBox.Text);
            this.txtSuma.Text=suma.ToString(); 
        }

  
    }

    private void btnIniciar_Click(object sender, EventArgs e)
    {
          
        if (suma != 0) {
            this.txtSuma.Text ="";
            suma = 0;
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.Checked = false;
            }
           

        }
        
        Random random = new Random();
        
        foreach (CheckBox check in checkBoxes)
        {
            int aleatorio=random.Next(0,100);
            check.Text = aleatorio.ToString();
            
        }
    
    }
}