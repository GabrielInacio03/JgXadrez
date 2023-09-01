using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xadrez.tabuleiro;

namespace xadrez.xz
{
    public class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public override string ToString()
        {
            return "T";
        }
    }
}