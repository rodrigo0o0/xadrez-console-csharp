using xadrez_console.tabuleiro.Exceptions;

namespace xadrez_console.tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;


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

        public Peca peca(Posicao pos)
        {
            validarPosicao(pos);
            return pecas[pos.Linha, pos.Coluna];
        }
        public void colocarPeca(Peca peca, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição.");

            }
            

            pecas[pos.Linha, pos.Coluna] = peca;
            peca.posicao = pos;


        }
        public Peca retirarPeca(Posicao pos)
        {
            if(peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos.Linha, pos.Coluna);
            pecas[pos.Linha, pos.Coluna] = null;
            return aux;

        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public bool posicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }

            return true;

        }
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posicao Inválida");
            }
        }
    }
}