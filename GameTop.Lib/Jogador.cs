using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador : IJogador
    {
        public readonly string _nome;

        public Jogador(string nome)
        {
            _nome = nome;
        }

        public string Chutar(){
            return $"{_nome} deu um chute";
        }

        public string Correr(){
            return $"{_nome} correu";
        }

        public string Passar(){
            return $"{_nome} deu um passe";
        }
    }

    
}