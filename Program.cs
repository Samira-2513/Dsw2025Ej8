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
                LimiteDeDescubierto = 30000,
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
                LimiteDeDescubierto = 60000,
            };

            cuentas.Add(c1);
            cuentas.Add(c2);
            cuentas.Add(c3);
            cuentas.Add(c4);


            Console.WriteLine("\t\t\t\t\tMOVIMIENTOS\n");
            foreach (var c in cuentas)
            {
                try
                {
                    c.Depositar(1000);
                    c.Retirar(500);
                    c.Depositar(0);
                    c.Retirar(0);
                }
                catch (MontoNoValido exc)
                {
                    Console.WriteLine($"Error: {exc.Message}");
                }
                catch (CuentaNoActiva exc)
                {
                    Console.WriteLine($"Error: {exc.Message}");
                }
                catch (SaldoInsuficiente exc)
                {
                    Console.WriteLine($"Error: {exc.Message}");
                }
            }
            Console.WriteLine("\n\n\n\t\t\t\t\tCUENTAS\n");

            foreach (var c in cuentas)
            {
                c.mostrar();
            }

        }
    }
}
