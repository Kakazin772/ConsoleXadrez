using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            int i, j;

            for (i = 0; i < tab.Linhas; i++)
            {
                for (j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write($"{tab.peca(i, j)} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
