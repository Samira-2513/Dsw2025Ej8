using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cuentas = new List<CuentaBancaria>();

            CuentaCorriente c1 = new CuentaCorriente("4586621", 5000, new string[] { "Gonzalez", "Garcia" })
            {
                LimiteDeDescubierto = 1000,
            };
            CajaAhorro c2 = new CajaAhorro("456987", 6000, new string[] { "Ruiz" })
            {
                TasaDeInteres = 0.30m
            };
            CajaAhorro c3 = new CajaAhorro("6574252", 6500, new string[] { "Alonso" })
            {
                TasaDeInteres = 0.50m
            };
            CuentaCorriente c4 = new CuentaCorriente("456665", 5500, new string[] { "Herrera" })
            {
                LimiteDeDescubierto = 500,
            };


            Console.WriteLine("\t\t\t\t\tMOVIMIENTOS\n");
            try
            {
                c3.Depositar(1000); 
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Error: {exc.Message}");
            }
            try
            {
                c1.Depositar(0); //Error monto no valido 
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Error: {exc.Message}");
            }


            try
            {
                c2.Retirar(7000);//Error no hay dinero suficiente
            }
            
            catch (Exception exc)
            {
                Console.WriteLine($"Error: {exc.Message}");
            }

            try
            {
                c2.Depositar(500);//Error cuenta suspendida
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Error: {exc.Message}");
            }
            try
            {
                c2.AplicarInteres();
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Error: {exc.Message}");
            }
            try
            {
                c3.AplicarInteres();
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Error: {exc.Message}");
            }
            try
            {
                c4.Retirar(4900);
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Error: {exc.Message}");
            }





            Console.WriteLine("\n\n\n\t\t\t\t\tCUENTAS\n");

            cuentas.Add(c1);
            cuentas.Add(c2);
            cuentas.Add(c3);
            cuentas.Add(c4);

            foreach (var c in cuentas)
            {
                c.mostrar();
            }

        }
    }
}
