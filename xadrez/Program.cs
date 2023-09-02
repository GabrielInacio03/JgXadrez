using System;
using System.Reflection.PortableExecutable;
using xadrez.tabuleiro;
using xadrez.tabuleiro;
using xadrez.xz;

namespace xadrez // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                Tela.iniciarTabuleiro(tabuleiro);
                Tela.imprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException ex)
            {
                System.Console.WriteLine(ex.Message);
            }finally
            {
                Console.ReadLine();
            }
           

        }
    }
}