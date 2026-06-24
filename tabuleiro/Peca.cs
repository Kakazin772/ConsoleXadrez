using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao Pos { get; protected set; }
        public Cor Cores { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public int QteMovimentos { get; protected set; }

        public Peca(Posicao pos, Cor cor, Tabuleiro tab)
        {
            Pos = pos;
            Cores = cor;
            Tab = tab;
            QteMovimentos = 0;
        }
    }
}
