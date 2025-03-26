using System.Text;

namespace Diamante_de_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero");
            int numero = Convert.ToInt32(Console.ReadLine());


            StringBuilder X = new StringBuilder("X");

            string x = "X";
            int quantidade = 0;
           

            
                int quantidadeEspacos = numero / 2;
                StringBuilder espacos = new StringBuilder("");

                for (int i = 0; i < quantidadeEspacos; i++)
                {
                    espacos.Append(" ");
                }

            Console.Write(espacos);

            quantidade = quantidadeEspacos - 1;

            for (int i = 1; i <= numero; i += 2)
            {
                if (i != numero)
                {
                    Console.Write($"{X} \n");
                    X.Append(x);
                    X.Append(x);
                    espacos.Length = quantidade;
                    Console.Write(espacos);
                    quantidade--;
                }

                else
                {
                    Console.Write($"{X}");
                }

            }

            Console.WriteLine("");



            StringBuilder espacosParteDeBaixo = new StringBuilder("");


            int quantidade2 = X.Length;


            for (int i = 1; i < numero; i += 2)
            {

                quantidade2 -= 2;
                X.Length = quantidade2;
                espacosParteDeBaixo.Append(" ");
                Console.Write(espacosParteDeBaixo);
                Console.Write($"{X} \n");



                

            }



            Console.ReadLine();
        }
    }
}