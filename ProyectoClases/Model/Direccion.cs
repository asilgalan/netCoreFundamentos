using System.Diagnostics;

namespace ProyectoClases;

public class Direccion
{

    #region PROPERTIES

    


    public string Calle;
    public string Ciudad;
    public String tipo;
    public int CodigoPostal;
    #endregion
    
    
    #region CONSTRUCTOR

    public Direccion()
    {
        Debug.WriteLine("Constructing out parameter");
    }

    public Direccion(string calle, string ciudad, int codigoPostal,string tipo)
    {
        this.tipo = tipo;
        this.Calle = calle;
        this.Ciudad = ciudad;
        this.CodigoPostal = codigoPostal;
    }
    #endregion
}