namespace Dsw2025Ej8.Domain;

public abstract class CuentaBancaria
{
    private string _numero;
    private Estado _estado;
    private decimal _tasaDeInteres;
    private string[] _titulares;
    protected decimal saldo { get; set; }

    public CuentaBancaria(string numero, decimal saldo, string[] titulares)
    {
        _numero = numero;
        this.saldo = saldo;
        _estado = Estado.Activa;
        _titulares = titulares;
    }
    #region Getters/Setters
    public string GetNumero()
    {
        return _numero;
    }

    public decimal GetSaldo()
    {
        return saldo;
    }
    public Estado GetEstado()
    {
        return _estado;
    }

    public void SetEstado(Estado estado)
    {
        _estado = estado;
    }

    public decimal GetTasaDeInteres()
    {
        return _tasaDeInteres;
    }

    public void SetTasaDeInteres(decimal tasaDeInteres)
    {
        _tasaDeInteres = tasaDeInteres;
    }

    public string[] GetTitulares()
    {
        return _titulares;
    }
    #endregion

    public abstract void Depositar(decimal monto);
    public abstract void Retirar(decimal monto);
}
