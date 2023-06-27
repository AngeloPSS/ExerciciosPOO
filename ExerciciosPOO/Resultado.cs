namespace ExerciciosPOO
{
    public class Resultado
    {
        public string nomeEspecie; // nome da especie
        public int quantidade; // quantidade de animais da especie
        public Resultado(string nomeEspecie, int quantidade)
        {
            this.nomeEspecie = nomeEspecie;
            this.quantidade = quantidade;
        }

        public string getNomeEspecie()
        {
            return nomeEspecie;
        }
        public int getQuantidade()
        {
            return quantidade;
        }
    }
}

