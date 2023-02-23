using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tania
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] botao = new int[2, 3] { { 3, 1, 3 }, { 6, 5, 5 } };
            int[,] camisa = new int[3, 2] { { 100, 50 }, { 50, 100 }, { 50, 50 } };
            int[,] totalBotao = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        totalBotao[i, j] += botao[i, k] * camisa[k, j];
                    }
                }
            }

            Console.WriteLine("Tabela que dá o total de botões usados em maio e junho:");
            Console.WriteLine("          | Maio | Junho |");
            Console.WriteLine($"Botões p | {totalBotao[0, 0],6} | {totalBotao[0, 1],6} |");
            Console.WriteLine($"Botões G | {totalBotao[1, 0],6} | {totalBotao[1, 1],6} |");
        }
    }
}
