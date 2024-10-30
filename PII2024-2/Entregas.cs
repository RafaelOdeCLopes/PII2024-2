using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2024_2
{
    internal class Entregas
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdEmpresaEntregadora { get; set; }
        public DateTime DataEntrega { get; set; }
        public string Status { get; set; }
    }
}
