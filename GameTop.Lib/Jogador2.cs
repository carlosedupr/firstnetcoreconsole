using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chutar()
        {
            return "Maradona deu um chute";
        }

        public string Correr()
        {
            return "Maradona correu";
        }

        public string Passar()
        {
            return "Maradona deu um passe";
        }
    }
}