using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2024_2
{
    internal class Entregas
    {
        SQLServer sql = new SQLServer();
        Neo4j Neo4 = new Neo4j();
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdEmpresaEntregadora { get; set; }
        public DateTime DataEntrega { get; set; }
        public string Status { get; set; }



        public void Inserir()
        {
            string query = @"INSERT INTO entregas 
                ( id_pedido, id_empresa_entregadora, data_entrega, status)
                VALUES 
                (@IdPedido, @IdEmpresaEntregadora, @DataEntrega, @Status)";

            var parametros = new Dictionary<string, object>
       {
            {"@IdPedido", IdPedido},
           {"@IdEmpresaEntregadora", IdEmpresaEntregadora},
           {"@DataEntrega", DataEntrega},
           {"@Status", Status},

       };
            sql.ExecutarComParametros(query, parametros);
        }
    }
}
