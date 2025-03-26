

namespace Diamante_de_X
{
    public class ValidacaoEntrada
    {
        public static int ValidacaoEntradaFuncao(int numero)
        {
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

            return numero;
        }
    }
}
