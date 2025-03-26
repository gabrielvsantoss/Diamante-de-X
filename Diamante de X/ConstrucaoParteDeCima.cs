

using System.Text;


namespace Diamante_de_X
{
    public class ConstrucaoParteDeCima
    {

        public static StringBuilder ConstrucaoParteDeCimaFuncao(int numero)
        {

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
            return X;

        }
    }
}
