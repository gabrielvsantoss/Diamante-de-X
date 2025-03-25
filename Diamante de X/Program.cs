using System.ComponentModel;

namespace Diamante_de_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero");
            double numero = Convert.ToInt32(Console.ReadLine());
            double metade = (numero / 2) + 0.5;

            int quantidade = 1;
            for(int i = 1; i <= numero; i++)
            {
                quantidade++;
                += quantidade;
                Console.Write("X");
                if(quantidade == 2)
                {
                    Console.WriteLine("");
                    quantidade = 0;
                }
            }

            Console.WriteLine(metade);
            Console.ReadLine();
        }
    }
}