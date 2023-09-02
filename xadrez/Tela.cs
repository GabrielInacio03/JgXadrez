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
                System.Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if(tabuleiro.peca(i, j) != null)
                    {
                        //System.Console.Write(tabuleiro.peca(i,j) + " ");
                        Tela.imprimirPeca(tabuleiro.peca(i,j));
                    }else
                    {
                        System.Console.Write("- ");
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");
        }
        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Preta)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.Write(peca  + " ");
                Console.ForegroundColor = aux;
            } else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.Write(peca  + " ");
                Console.ForegroundColor = aux;
            }
        }
        
    }
}