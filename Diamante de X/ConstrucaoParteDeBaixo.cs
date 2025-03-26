
using System.Text;

namespace Diamante_de_X
{
    public class ConstrucaoParteDeBaixo
    {
        public static void ConstrucaoParteDeBaixoFuncao(StringBuilder X, int numero)
        {
            StringBuilder espacosParteDeBaixo = new StringBuilder("");

            int quantidadeDeXPorLinha = X.Length;


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

