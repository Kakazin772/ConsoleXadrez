using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Pos { get; set; }
        public Cor Cores { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public int QteMovimentos { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Pos = null;
            Cores = cor;
            Tab = tab;
            QteMovimentos = 0;
        }
    }
}
