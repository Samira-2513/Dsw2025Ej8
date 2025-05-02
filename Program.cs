using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CajaAhorro c = new CajaAhorro("20", 1000, new string[]{ "Fernando" })
            {
                TasaDeInteres = 0.5m,
            };
        }
    }
}
