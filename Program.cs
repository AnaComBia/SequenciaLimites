using System;

namespace SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Sequência Limites---");

            Console.Write("\nMe fale o número em que a contagem irá iniciar: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Me fale o número em que a contagem irá acabar: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            do
            {

                Console.WriteLine($"\n{number1}");

                number1 = number1 + 1;

            }
            while (number1 <= number2);



        }
    }
}
