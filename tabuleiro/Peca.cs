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

        public Peca(Tabuleiro tab, Cor cor)
        {
            Pos = null;
            Cores = cor;
            Tab = tab;
            QteMovimentos = 0;
        }
    }
}
