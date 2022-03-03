using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distância percorrida: ");
            string distanciaTotal = Console.ReadLine();

            Console.WriteLine("Informe a quantidade combustível consumido :");
            string gastoCombustivel = Console.ReadLine();

            decimal distanciaFinal = 0.00m;
            decimal combustivelFinal = 0.00m;

            decimal.TryParse(distanciaTotal, out distanciaFinal);
            decimal.TryParse(gastoCombustivel, out combustivelFinal);

            decimal resultado = (distanciaFinal / combustivelFinal);

            Console.WriteLine($"A média de consumo do veículo é de {resultado} Km/L");

        }
    }
}
