using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xadrez.tabuleiro;
using xadrez.xz;

namespace xadrez
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if(tabuleiro.peca(i, j) != null)
                    {
                        System.Console.Write(tabuleiro.peca(i,j) + " ");
                    }else
                    {
                        System.Console.Write("- ");
                    }
                }
                System.Console.WriteLine();
            }
        }
        public static void iniciarTabuleiro(Tabuleiro tabuleiro)
        {
            //Jogador 1
            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0,0));
            tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Preta), new Posicao(0,1));
            tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Preta), new Posicao(0,2));
            tabuleiro.colocarPeca(new Rainha(tabuleiro, Cor.Preta), new Posicao(0,3));
            tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0,4));
            tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Preta), new Posicao(0,5));
            tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Preta), new Posicao(0,6));
            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0,7));

            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1,0));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1,1));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1,2));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1,3));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1,4));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1,5));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1,6));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1,7));

            //Jogador 2
            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(7,0));
            tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Preta), new Posicao(7,1));
            tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Preta), new Posicao(7,2));
            tabuleiro.colocarPeca(new Rainha(tabuleiro, Cor.Preta), new Posicao(7,3));
            tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(7,4));
            tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Preta), new Posicao(7,5));
            tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Preta), new Posicao(7,6));
            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(7,7));

             tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(6,0));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(6,1));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(6,2));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(6,3));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(6,4));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(6,5));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(6,6));
            tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(6,7));
        }
    }
}