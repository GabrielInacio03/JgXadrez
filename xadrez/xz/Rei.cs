using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xadrez.tabuleiro;

namespace xadrez.xz
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public override string ToString()
        {
            return "*";
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];
        }
    }
}