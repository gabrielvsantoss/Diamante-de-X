using System.Drawing;
using System.Text;

namespace Diamante_de_X
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int numero = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escreva um numero Impar");
                bool ConseguiuConverter = int.TryParse(Console.ReadLine(), out numero);

                if (ConseguiuConverter && numero % 2 != 0)
                {
                    break;
                }

                else
                    continue;
            }


            


            StringBuilder X = new StringBuilder("X");

            string x = "X";
            int quantidadeDeXPorLinha = 0;
           

            
                int quantidadeEspacos = numero / 2;
                StringBuilder espacosParteDeCima = new StringBuilder("");

                for (int i = 0; i < quantidadeEspacos; i++)
                {
                    espacosParteDeCima.Append(" ");
                }

            Console.Write(espacosParteDeCima);

            quantidadeDeXPorLinha = quantidadeEspacos - 1;

            for (int i = 1; i <= numero; i += 2)
            {
                if (i != numero)
                {
                    Console.Write($"{X} \n");
                    X.Append(x);
                    X.Append(x);
                    espacosParteDeCima.Length = quantidadeDeXPorLinha;
                    Console.Write(espacosParteDeCima);
                    quantidadeDeXPorLinha--;
                }

                else
                {
                    Console.Write($"{X}");
                }

            }

            Console.WriteLine("");
            StringBuilder espacosParteDeBaixo = new StringBuilder("");

            
             quantidadeDeXPorLinha = X.Length;


            for (int i = 1; i < numero; i += 2)
            {
                quantidadeDeXPorLinha -= 2;
                X.Length = quantidadeDeXPorLinha;
                espacosParteDeBaixo.Append(" ");
                Console.Write(espacosParteDeBaixo);
                Console.Write($"{X} \n");
            }

            Console.ReadLine();
        }
    }
}