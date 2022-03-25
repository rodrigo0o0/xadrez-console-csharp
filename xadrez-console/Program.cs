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

                Tabuleiro tab = new Tabuleiro(10, 10);


                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));
                tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 10));
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
