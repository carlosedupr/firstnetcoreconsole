using GameTop.Interface;

namespace GameTop
{
    public class Jogo
    {
        private readonly IJogador _jogador1;
        private readonly IJogador _jogador2;

        public Jogo(IJogador jogador1, IJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }

        public string IniciarJogo(){
            string retorno = string.Empty;
             retorno = string.Concat(_jogador1.Chutar(), "\n", _jogador1.Correr(), "\n", _jogador1.Passar(), "\n\n",
              _jogador2.Chutar(), "\n", _jogador2.Correr(), "\n", _jogador2.Passar());
            return retorno;
        }
    }
}