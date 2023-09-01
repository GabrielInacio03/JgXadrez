using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xadrez.tabuleiro
{
    public class Peca
    {
        
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdeMovimentos { get; protected set; } 
        public Tabuleiro tabuleiro{ get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor) 
        {
            this.posicao = posicao;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            this.qtdeMovimentos = 0;
        }
    }
}