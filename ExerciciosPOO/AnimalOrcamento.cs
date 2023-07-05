using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO {
    interface IAnimalOrcamento : IAnimal {
        public ItemOrcamentoComplexo orcamentoGastosAnimal();

    }

    public class AnimalOrcamento : ItemOrcamento {

        public Animal AnimalInstance;
        public AnimalOrcamento(Animal animal, string historico, float valor) : base(historico, valor) {
            AnimalInstance = animal;
            Historico = historico;
            Valor = valor;
        }

        public static AnimalOrcamento[] RetornaRegistroHistorico(AnimalOrcamento[] orcamento, string registro) {
            List<AnimalOrcamento> Animais = new();
            foreach (AnimalOrcamento entrada in orcamento) {
                if (entrada.Historico == registro) {
                    Animais.Add(entrada);
                }
            }
            AnimalOrcamento[] AnimaisEncontrados = Animais.ToArray();;
            return AnimaisEncontrados;
        }
    }
}
