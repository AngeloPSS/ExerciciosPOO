using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class ItemOrcamentoComplexo : ItemOrcamento
    {
        public ItemOrcamento[] Itens;
        private string HistoricoComplexo { get; set; }
        public float ValorComplexo { get; set; }
        public ItemOrcamentoComplexo(ItemOrcamento[] itens, string historico, float valor) : base(historico, valor)
        {
            HistoricoComplexo = historico;
            ValorComplexo = valor;
            Itens = itens;
        }

        public float GetValorTotal()
        {
            float ValorTotal = Valor;
            foreach (ItemOrcamento item in Itens)
            {
                ValorTotal += item.Valor;
            }
            return ValorTotal;
        }

        public ItemOrcamento? EncontraItem(string HistoricoBusca)
        {
            foreach (ItemOrcamento item in Itens)
            {
                if (item.Historico == HistoricoBusca)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
