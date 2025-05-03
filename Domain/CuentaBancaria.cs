namespace Dsw2025Ej8.Domain;

public abstract class CuentaBancaria
{


    public string Numero { get; }
    public decimal Saldo { get; protected set; }
    public string[] Titulares { get; }
    public Estado Estado { get; set; }

    public CuentaBancaria(string numero, decimal saldo, string[] titulares)
    {
        Numero = numero;
        Saldo = saldo;
        Estado = Estado.Activa;
        Titulares = titulares;
    }

    public virtual void mostrar()
    {
        Console.WriteLine($"NUMERO DE CUENTA: {Numero}");
        Console.WriteLine($"SALDO: {Saldo}");
        Console.WriteLine("TITULARES DE LA CUENTA:");
        foreach (var titular in Titulares)
        {
            Console.WriteLine($"- {titular}");
        }
        Console.WriteLine();
    }

    public abstract void Depositar(decimal monto);
    public abstract void Retirar(decimal monto);
}
