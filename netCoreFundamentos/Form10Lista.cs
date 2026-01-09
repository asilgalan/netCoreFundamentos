namespace netCoreFundamentos;

public partial class Form10Lista : Form
{
    public Form10Lista()
    {
        InitializeComponent();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
   
     
    }


    private void btnEliminar_Click(object sender, EventArgs e)
    {
        string elem = this.txtaddLis.Text;

        int index = this.textList.SelectedIndex;
        
        this.textList.Items.RemoveAt(index);
    }

    private void btnBorrar_Click(object sender, EventArgs e)
    {
        string elem = this.txtaddLis.Text;
        this.textList.Items.Clear();
      
    }

    private void btnInsertar_Click(object sender, EventArgs e)
    {
        string elem = this.txtaddLis.Text;
        this.textList.Items.Add(elem);
      
    }
}