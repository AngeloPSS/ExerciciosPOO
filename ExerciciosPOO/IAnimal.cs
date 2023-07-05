namespace ExerciciosPOO
{
    interface IAnimal
    {
        string Especie { get; set; }
        string Nome { get; set; }
    }
    interface IFerramentas
    {
        public Animal[] FiltraEspecie(Animal[] completo, string especieFiltrar);
        public string[] ClassificaEspecie(Animal[] completo);
    }

    public class Animal : IFerramentas, IAnimal
    {
        public string Especie { get; set; }
        public string Nome { get; set; }

        public Animal(string nome, string especie)
        {
            Nome = nome;
            Especie = especie;
        }

        public Animal[] FiltraEspecie(Animal[] completo, string especieFiltrar)
        {
            List<Animal> filtrado = new();
            foreach (Animal animal in completo)
            {
                if (animal.Especie == especieFiltrar)
                {
                    filtrado.Append(animal);
                }
            }
            return filtrado.ToArray();
        }

        public string[] ClassificaEspecie(Animal[] completo)
        {
            List<string> listaEspecies = new();
            for (int i = 0; i <= completo.Length; i++)
            {
                if (listaEspecies.Find(x => x == completo[i].Especie) == null)
                {
                    listaEspecies.Append(completo[i].Especie);
                }
            }
            return listaEspecies.ToArray();
        }

        public static Resultado[] ContaEspecie(Animal[] animais)
        {
            List<Resultado> ajuda = new();
            int cont;

            foreach (Animal especie in animais)
            {
                Animal[] temp = Array.FindAll(animais, animal => animal.Especie == especie.Especie);
                cont = temp.Length;
                Resultado contagem = new Resultado(especie.Especie, cont);
                ajuda.Add(contagem);
            }
            List<Resultado> resultado = new();

            Resultado[] auxiliar = ajuda.ToArray();
            foreach (Resultado animal in auxiliar)
            {
                if (ajuda.RemoveAll(x => x.nomeEspecie == animal.nomeEspecie) != 0)
                {
                    ajuda.RemoveAll(x => x.nomeEspecie == animal.nomeEspecie);
                    resultado.Add(animal);
                }
            }
            return resultado.ToArray();
        }

    }
}

