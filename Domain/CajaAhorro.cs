using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    internal class CajaAhorro : CuentaBancaria
    {

        private decimal _tasaDeInteres;


        public CajaAhorro(string numero, decimal saldo, string[] titulares)
        : base(numero, saldo, titulares) { }
        public override void Depositar(decimal monto)
        {
                saldo += monto;
        }

        public override void Retirar(decimal monto)
        {
                saldo -= monto;
        }

        public void AplicarInteres()
        {
                saldo += saldo * _tasaDeInteres;
        }
    }
}