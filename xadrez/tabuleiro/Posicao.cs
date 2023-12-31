using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xadrez.tabuleiro
{
    public class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(){}
        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return $"Linha:" + Linha +
                 "Coluna: " + Coluna;
        }
    }
}