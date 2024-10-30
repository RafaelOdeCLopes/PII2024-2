using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2024_2
{
    internal class Doacoes
    {
        public int Id { get; set; }
        public int IdDoador { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDoacao { get; set; }
        public int IdEmpresaFabricante { get; set; }
    }
}
