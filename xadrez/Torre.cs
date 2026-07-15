using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);

            return p != null || p.Cores != Cores;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //Cima
            pos.DefinirValores(Pos.Linha - 1, Pos.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[Pos.Linha, Pos.Coluna] = true;

                if (Tab.peca(pos) != null && Tab.peca(pos).Cores != Cores)
                {
                    break;
                }

                Pos.Linha = Pos.Linha - 1;
            }

            //Baixo
            pos.DefinirValores(Pos.Linha + 1, Pos.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[Pos.Linha, Pos.Coluna] = true;

                if (Tab.peca(pos) != null && Tab.peca(pos).Cores != Cores)
                {
                    break;
                }

                Pos.Linha = Pos.Linha + 1;
            }

            //Direita
            pos.DefinirValores(Pos.Linha, Pos.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[Pos.Linha, Pos.Coluna] = true;

                if (Tab.peca(pos) != null && Tab.peca(pos).Cores != Cores)
                {
                    break;
                }

                Pos.Linha = Pos.Coluna + 1;
            }

            //Esquerda
            pos.DefinirValores(Pos.Linha, Pos.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[Pos.Linha, Pos.Coluna] = true;

                if (Tab.peca(pos) != null && Tab.peca(pos).Cores != Cores)
                {
                    break;
                }

                Pos.Linha = Pos.Coluna + 1;
            }

            return mat;
        }
    }
}
