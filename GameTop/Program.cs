using System;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo(new Jogador("Ronaldo"), new Jogador2());

            Console.WriteLine(jogo.IniciarJogo());
        }
    }
}
