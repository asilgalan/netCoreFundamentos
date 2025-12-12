namespace netCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)

        {

            Console.WriteLine("Hola " + textBox1.Text);
            this.textBox1.Location = new Point(159,30);
      
            this.textBox1.Width = 220;

        }

    }
}
