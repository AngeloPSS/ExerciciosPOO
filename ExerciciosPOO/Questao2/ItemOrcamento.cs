using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO.Questao2 {
    public class ItemOrcamento {
        private string historico { get; }
        public string Historico { get => historico; set => Historico = value; }
        private float valor { get; }
        public float Valor { get => valor; set => Valor = value; }
        public ItemOrcamento(string historico, float valor) {
            this.Historico = historico;
            this.Valor = valor;
        }
    }
}
