using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    internal class CuentaCorriente : CuentaBancaria
    {
        public decimal LimiteDeDescubierto { get; init; }
        public decimal Comision { get; set; }


        public CuentaCorriente(string numero, decimal saldo, string[] titulares)
       : base(numero, saldo, titulares) { }     

        public override void Depositar(decimal monto)
        {
            if (Estado != Estado.Activa)
            {
                throw new CuentaNoActiva($"No se puede operar con la cuenta {Estado}");
            }
            if (monto <= 0)
            {
                throw new MontoNoValido("El monto ingresado no es válido para la operación solicitada");
            }
            monto -= monto * Comision;
            Saldo += monto;
        }

        public override void Retirar(decimal monto)
        {
            if (Estado != Estado.Activa)
            {
                throw new CuentaNoActiva($"No se puede operar con la cuenta {Estado}");
            }
            if (monto <= 0)
            {
                throw new MontoNoValido("El monto ingresado no es válido para la operación solicitada");
            }
            if (Saldo - monto < LimiteDeDescubierto || Saldo < 0)
            {
                Estado = Estado.Suspendida;
                throw new SaldoInsuficiente("La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.");
            }
            Saldo -= monto;
        }
    }
}
