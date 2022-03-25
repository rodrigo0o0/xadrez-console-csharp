using xadrez_console.tabuleiro.Exceptions;

namespace xadrez_console.tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca [,] pecas;
        

        public Tabuleiro(int linha, int colunas)
        {
            Linhas = linha;
            Colunas = colunas;
            pecas = new Peca[linha, colunas];
            
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public void colocarPeca(Peca peca,Posicao pos)
        {
            if(pecas[pos.Linha, pos.Coluna] == null)
            {
                pecas[pos.Linha, pos.Coluna] = peca;
                peca.posicao = pos;
            }
            else
            {
                throw new DomainException("A casa está ocupada.");
            }
        }
    }
}