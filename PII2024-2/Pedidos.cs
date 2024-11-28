using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PII2024_2
{
    internal class Pedidos
    {
        SQLServer sql = new SQLServer();
        Neo4j Neo4 = new Neo4j();
        public int Id { get; set; }
        public string NomePedido { get; set; }
        public int IdFamilia { get; set; }
        public int IdAlimento { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataPedido { get; set; }

        public void Inserir()
        {
            string query = @"INSERT INTO pedidos 
                ( id_familia, id_alimento, quantidade, data_pedido, nome_pedido)
                VALUES 
                (@IdFamilia, @IdAlimento, @Quantidade, @DataPedido, @NomePedido)";

            var parametros = new Dictionary<string, object>
       {
            {"@IdFamilia", IdFamilia},
           {"@IdAlimento", IdAlimento},
           {"@Quantidade", Quantidade},
           {"@DataPedido", DataPedido},
           {"@NomePedido", NomePedido},

       };
            sql.ExecutarComParametros(query, parametros);
        }
    }
}