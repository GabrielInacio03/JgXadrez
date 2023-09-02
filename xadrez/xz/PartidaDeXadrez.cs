using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xadrez.tabuleiro;

namespace xadrez.xz
{
    public class PartidaDeXadrez
    {
        public Tabuleiro tab {get; set;}
        private int turno;
        private Cor jogadorAtual;
        public bool terminada {get; set;}

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8,8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
        }
        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarMovimento();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }
        public void iniciarTabuleiro()
        {
            try
            {
                 //Jogador 1
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0,0));
                tab.colocarPeca(new Cavalo(tab, Cor.Preta), new Posicao(0,1));
                tab.colocarPeca(new Bispo(tab, Cor.Preta), new Posicao(0,2));
                tab.colocarPeca(new Rainha(tab, Cor.Preta), new Posicao(0,3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0,4));
                tab.colocarPeca(new Bispo(tab, Cor.Preta), new Posicao(0,5));
                tab.colocarPeca(new Cavalo(tab, Cor.Preta), new Posicao(0,6));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0,7));

                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1,0));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1,1));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1,2));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1,3));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1,4));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1,5));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1,6));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1,7));

                //Jogador 2
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7,0));
                tab.colocarPeca(new Cavalo(tab, Cor.Branca), new Posicao(7,1));
                tab.colocarPeca(new Bispo(tab, Cor.Branca), new Posicao(7,2));
                tab.colocarPeca(new Rainha(tab, Cor.Branca), new Posicao(7,3));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(7,4));
                tab.colocarPeca(new Bispo(tab, Cor.Branca), new Posicao(7,5));
                tab.colocarPeca(new Cavalo(tab, Cor.Branca), new Posicao(7,6));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7,7));

                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6,0));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6,1));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6,2));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6,3));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6,4));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6,5));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6,6));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6,7));
            }
            catch (TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }
           
        }
    }
} 