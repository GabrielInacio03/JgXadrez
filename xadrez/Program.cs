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
                PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();
                partidaDeXadrez.iniciarTabuleiro();

                while(!partidaDeXadrez.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partidaDeXadrez.tab);

                    System.Console.WriteLine("Origem");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    System.Console.WriteLine("Destino");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partidaDeXadrez.ExecutaMovimento(origem, destino);

                }
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