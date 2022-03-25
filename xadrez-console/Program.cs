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
                Tabuleiro tab = new Tabuleiro(8,8);
                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 2));
                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(7, 7));
                tab.colocarPeca(new Rei(Cor.Branca, tab), new Posicao(3, 5));

                Tela.imprimirTabuleiro(tab);
                
                
            }catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
