using System.Text;

namespace Diamante_de_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                int numero = 0;
                numero = ValidacaoEntrada.ValidacaoEntradaFuncao(numero);
                StringBuilder X = new StringBuilder("");
                X = ConstrucaoParteDeCima.ConstrucaoParteDeCimaFuncao(numero);
                ConstrucaoParteDeBaixo.ConstrucaoParteDeBaixoFuncao(X, numero);
            }
        }
    }
}