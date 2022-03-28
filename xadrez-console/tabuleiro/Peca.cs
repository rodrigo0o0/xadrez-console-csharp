using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    internal abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca() { }
        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.qtdMovimentos = 0;
            this.tab = tab;
        }
        public abstract bool[,] movimentosPossiveis();

        public void incrementarMovimentos()
        {
            qtdMovimentos++;
        }
        public void decrementarMovimentos()
        {
            qtdMovimentos--;
        }
        public bool existeMovimentosPossiveis()
        {
            bool [,] mat = movimentosPossiveis();
            for (int linhas = 0; linhas < tab.Linhas; linhas++)
            {
                for (int colunas = 0; colunas < tab.Colunas; colunas++)
                {
                    if (mat[linhas, colunas])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }
    }
}
