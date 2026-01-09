namespace ProyectoClases;

public class CuentaBancaria{
    public string nombre;
    public string apellido;
    public string numerocuenta;
    public decimal saldo{get;  private  set;}

    public CuentaBancaria(){
        
    }

    public decimal retirar(decimal montoaretirar)
    {
        if (this.saldo < montoaretirar)
        { throw new Exception("NO TIENE SUFICIENTE SALDO");
        }
        else
        {
            this.saldo -= montoaretirar;
            return saldo;
        }
    }
    public decimal ingresar(decimal montoaingresar)
    {

        if (montoaingresar > 0)
        {
            this.saldo += montoaingresar;
            return saldo;
        }
        else
        {
            throw new Exception("ingrese una cantidad mayor");
        }

     
    }
    
    
}