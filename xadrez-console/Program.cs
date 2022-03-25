using System;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Tabuleiro tab = new Tabuleiro(10, 10);
            Tela.imprimirTabuleiro(tab);
            
            Console.ReadKey();
        }
    }
}
