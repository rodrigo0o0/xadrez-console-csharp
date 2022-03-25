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
                PosicaoXadrez px = new PosicaoXadrez('f', 1);
                Console.WriteLine(px.toPosicao());
                
                
            }catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
