using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    internal class CajaAhorro : CuentaBancaria
    {

        public decimal TasaDeInteres{ get; init; }


        public CajaAhorro(string numero, decimal saldo, string[] titulares)
        : base(numero, saldo, titulares) { }
        public override void Depositar(decimal monto)
        {
                Saldo += monto;
        }

        public override void Retirar(decimal monto)
        {
                Saldo -= monto;
        }

        public void AplicarInteres()
        {
                Saldo += Saldo * TasaDeInteres;
        }
    }
}