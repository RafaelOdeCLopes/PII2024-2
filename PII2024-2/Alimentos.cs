using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2024_2
{
    internal class Alimentos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataValidade { get; set; }
        public int Quantidade { get; set; }
        public string Origem { get; set; }
        public int IdEmpresaFabricante { get; set; }
        public int IdDoacao { get; set; }
    }
}
