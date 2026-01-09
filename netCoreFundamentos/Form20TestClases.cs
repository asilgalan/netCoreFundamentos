
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using ProyectoClases;

namespace netCoreFundamentos;

public partial class Form20TestClases : Form
{
    public Form20TestClases()
    {
        InitializeComponent();
    }

    private void btncreate_Click(object sender, EventArgs e)
    {
     Persona persona = new Persona();
     persona.Nombre = "Asil";
     persona.Apellido = "Galan";
     persona.Edad = 24;
     persona.Genero = TipoGenero.Masculino;
     List<Direccion> dirCasa = new List<Direccion>();
    dirCasa.Add(new Direccion("hermanos gomez","rd",28017,"casa"));
    dirCasa.Add(new Direccion("hermanos gomez","madrid",28017,"campo"));


    foreach (Direccion dir in dirCasa)
    {
        persona.direcciones.Add(dir);
    }

     this.listapersonaje.Items.Add("Genero " + persona.Genero);
     this.listapersonaje.Items.Add(
         "Nombre: "+ persona.Nombre+" edad: "+persona.Edad+" apellido: "+persona.Apellido);
     
     this.listapersonaje.Items.Add(
         persona.getNombreCompleto());


     foreach (Direccion dir in persona.direcciones){
         this.listapersonaje.Items.Add(dir.Calle + " " + dir.Ciudad+" " +dir.CodigoPostal+" "+dir.tipo);
         
         
         
     }

    }


    private void btnEmpleado_Click(object sender, EventArgs e)
    {
     Empleado empleado = new Empleado();
     empleado.Nombre = "Asil";
     empleado.Apellido = "Galan Castro";
     empleado.Edad = 24;
     
     this.listapersonaje.Items.Add(empleado);
    }
}