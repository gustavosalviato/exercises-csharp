using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor em R$: ");
            string value = Console.ReadLine();

            decimal convertValue = 0.0m;

            decimal valorCambio = 0.1932m;

            decimal.TryParse(value, out convertValue);

            decimal valorCambioConvertido = convertValue * valorCambio;

            Console.WriteLine($"Valor em $ : {valorCambioConvertido}");

            Console.WriteLine();
        }
    }
}
