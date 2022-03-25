using System;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int linhas = 0; linhas < tab.Linhas; linhas++)
            {
                Console.Write(tab.Linhas - linhas + " ");

                for (int colunas = 0; colunas < tab.Colunas; colunas++)
                {
                    if (tab.peca(linhas, colunas) == null)
                    {
                        Console.Write(" -");
                    }
                    else
                    {
                        Console.Write(" ");
                        imprimirPeca(tab.peca(linhas, colunas));
                        
                    }
                }
                Console.WriteLine();
            }
            Console.Write("   ");
            for (int colunas = 0; colunas < tab.Colunas; colunas++)
            {
                int ascii = 65;
                ascii += colunas;
                char column = (char)ascii;
                Console.Write(column + " ");
            }


        }
        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
