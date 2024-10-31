using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2024_2
{
    internal class Pedidos
    {
        public int Id { get; set; }
        public int IdFamilia { get; set; }
        public int IdAlimento { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataPedido { get; set; }
    }
}
