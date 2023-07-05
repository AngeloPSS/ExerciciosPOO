using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class ItemOrcamento
    {
        public string Historico { get; set; }
        public float Valor { get; set; }
        public ItemOrcamento(string historico, float valor)
        {
            Historico = historico;
            Valor = valor;
        }
    }
}
