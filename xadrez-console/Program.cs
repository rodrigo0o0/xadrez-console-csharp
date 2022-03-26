using System;
using xadrez_console.tabuleiro;
using xadrez_console.tabuleiro.Exceptions;
using xadrez_console.xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //PosicaoXadrez px = new PosicaoXadrez('f', 1);
                Tabuleiro tab = new Tabuleiro(8, 8);

                PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();

                while (!partidaDeXadrez.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partidaDeXadrez.tab);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();


                    bool [,] posicoesPossiveis = partidaDeXadrez.tab.peca(origem).movimentosPossiveis();
                    Console.Clear();
                    Tela.imprimirTabuleiro(partidaDeXadrez.tab,posicoesPossiveis);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();


                    partidaDeXadrez.executaMovimento(origem, destino);

                    
                }

            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
