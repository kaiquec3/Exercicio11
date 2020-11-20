using System;

namespace Exercício_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Pessoa();
            double k;

            do
            {
                Console.Write("Informe o peso da pessoa em quilogramas: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetPeso(k);
            }
            while (k <= 0);

            do
            {
                Console.Write("Informe a altura da pessoa em metros: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetAltura(k);
            }
            while (k <= 0);

            Console.WriteLine($"Esta pessoa está com status de {a1.ExibirMsg()}");
        }
    }
}
