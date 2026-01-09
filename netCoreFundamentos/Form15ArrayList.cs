using System.Collections;

namespace netCoreFundamentos;

public partial class Form15ArrayList : Form
{
    public Form15ArrayList()
    {
        InitializeComponent();

        List<Control> botones = new List<Control>();
        botones.Add(this.button1);
        botones.Add(this.button2);
        botones.Add(this.button3);
        botones.Add(this.label1);
     

        ArrayList collection = new ArrayList();
        collection.Add(this.button1);
        collection.Add(this.button2);
        collection.Add(this.button3);
        collection.Add(this.label1);
        ((Button)collection[0]).BackColor = Color.Red;

        foreach (Control button in collection)
        {
            button.BackColor = Color.LightBlue;
            if (button is TextBox)
            {
                ((TextBox)button).Paste();
            }
         
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}