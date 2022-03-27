using System;
using System.Collections.Generic;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    internal class Tela
    {
        public static void imprimirPartida(PartidaDeXadrez partida)
        {
            imprimirTabuleiro(partida.tab);
            Console.WriteLine();
            imprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.turno);
            Console.WriteLine("Aguardando a jogada : " + partida.jogadorAtual);
            if (partida.xeque)
            {
                Console.WriteLine("XEQUE!");
            }

        }

        private static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas : ");
            Console.Write("Brancas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.WriteLine();
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Pretas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;


        }

        private static void imprimirConjunto(HashSet<Peca> pecas)
        {
            Console.Write("[");
            foreach (Peca peca in pecas)
            {
                Console.Write(peca + " ");
            }

            Console.Write("]");
        }

        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int linhas = 0; linhas < tab.Linhas; linhas++)
            {
                Console.Write(tab.Linhas - linhas + " ");

                for (int colunas = 0; colunas < tab.Colunas; colunas++)
                {

                    imprimirPeca(tab.peca(linhas, colunas));

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
            return new PosicaoXadrez(coluna, linha);

        }

        internal static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            for (int linhas = 0; linhas < tab.Linhas; linhas++)
            {
                Console.Write(tab.Linhas - linhas + " ");

                for (int colunas = 0; colunas < tab.Colunas; colunas++)
                {
                    if (posicoesPossiveis[linhas, colunas])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    imprimirPeca(tab.peca(linhas, colunas));
                    Console.BackgroundColor = fundoOriginal;

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
            if (peca == null)
            {
                Console.Write(" -");
            }
            else
            {

                if (peca.cor == Cor.Branca)
                {
                    Console.Write(" " + peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" " + peca);
                    Console.ForegroundColor = aux;
                }
            }
        }
    }
}
