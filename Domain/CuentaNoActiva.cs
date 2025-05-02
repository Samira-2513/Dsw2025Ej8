using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    internal class CuentaNoActiva : Exception
    {
        public CuentaNoActiva(string mensaje) : base(mensaje)
        {
        }
    }
}
