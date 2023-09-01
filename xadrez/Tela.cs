using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xadrez.tabuleiro;

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
        
    }
}