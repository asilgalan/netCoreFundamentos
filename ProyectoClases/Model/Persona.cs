using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ProyectoClases
{
    
    public enum TipoGenero
    {
        Masculino,
        Feminino
    };

    public enum Paises
    {
        España,
        Francia,
        Alemania,
        RD,
        Colombia
    }


public class Persona {
    
    #region Propiedades

    public List<Direccion> direcciones { get; set; } = new List<Direccion>();
    public  string Nombre{get;set;}
    public string Apellido{get;set;}
  
 
    private int _Edad;

    public int Edad 
    {
        get { return _Edad; }
        set 
        {
        
            if (value < 0 || value > int.MaxValue)
            {
           
                throw new ArgumentOutOfRangeException("La edad no puede ser negativa.");
            }
            _Edad = value;
        }
    }

    public TipoGenero Genero{get;set;}
    public Paises Pais{get;set;}
    
    #endregion
    
    #region Constructor


    public Persona()
    {
       Debug.WriteLine("Hola Mundo");
    }
  
    #endregion
    
    #region Metodos

    
    public string getNombreCompleto()
    {
        return Nombre + " " + Apellido;
    }

    public string getNombreCompletoDelReves()
    {
        return Apellido + " " + Nombre;
    }
    public string getNombreCompletoMayusculas()
    {
        return (Nombre + " " + Apellido).ToUpper();
    }
    
    public string getNombreCompletoMinusculas()
    {
        return getNombreCompleto().ToLower();
    }

    #endregion
}

}