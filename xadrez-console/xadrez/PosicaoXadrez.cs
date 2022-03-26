using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    internal class PosicaoXadrez
    {
        public int Linha { get; set; }
        public char Coluna { get; set; }
        
        public PosicaoXadrez(char coluna,int linha)
        {
            Coluna = char.ToLower(coluna);
            Linha = linha;
        }
        public Posicao toPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 97 );
        }
        public override string ToString()
        {
            return "" + Coluna + Linha;
        }

    }
}
