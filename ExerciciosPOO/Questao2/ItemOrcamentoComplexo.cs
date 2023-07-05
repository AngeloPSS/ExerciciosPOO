using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO.Questao2 {
    public class ItemOrcamentoComplexo : ItemOrcamento {
        public ItemOrcamento[] Itens;
        private string HistoricoComplexo { get; set; }
        public float ValorComplexo { get ; set; }
        public ItemOrcamentoComplexo(ItemOrcamento[] itens, string historico, float valor) : base(historico, valor){
            this.HistoricoComplexo = historico;
            this.ValorComplexo = valor;
            this.Itens = itens;
        }

        public float GetValorTotal() {
            float ValorTotal = this.Valor;
            foreach (ItemOrcamento item in this.Itens) {
                ValorTotal += item.Valor;
            }
            return ValorTotal;
        }

        public ItemOrcamento? EncontraItem(string HistoricoBusca) {
            foreach (ItemOrcamento item in this.Itens) {
                if (item.Historico == HistoricoBusca) {
                    return item;
                }
            }
            return null;
        }
    }
}
