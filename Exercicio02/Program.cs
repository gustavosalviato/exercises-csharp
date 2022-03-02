using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor em USD:");
            String valorDigitado = Console.ReadLine();

            decimal valorConvertido = 0.00m;

            decimal valorCambio = 5.22m;

            decimal.TryParse(valorDigitado, out valorConvertido);

            decimal valorCambioConvertido = valorConvertido / valorCambio;

            Console.WriteLine($"Valor R$: {valorCambioConvertido}");

        }
    }
}
