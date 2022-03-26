using System;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

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
        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + " ");
            return new PosicaoXadrez(coluna,linha);
            
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
