using System;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab) {
            for (int linhas = 0; linhas < tab.Linhas; linhas++)
            {
                for (int colunas = 0; colunas < tab.Colunas; colunas++)
                {
                    if (tab.peca(linhas, colunas) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.WriteLine(" "+tab.peca(linhas,colunas).ToString());
                    }
                }
                Console.WriteLine();
            }
        
        
        }
    }
}
