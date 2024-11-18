using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace PII2024_2
{
    internal class Alimentos
    {
        SQLServer sql = new SQLServer();
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataValidade { get; set; }
        public int Quantidade { get; set; }
        public string Origem { get; set; }
        public int IdEmpresaFabricante { get; set; }
        public SqlInt16 IdDoacao { get; set; }
        public void Inserir()
        {
            string query = @"INSERT INTO alimentos 
                     (nome, descricao, data_validade, quantidade, origem, id_empresa_fabricante, id_doacao)
                     VALUES 
                     (@Nome, @Descricao, @DataValidade, @Quantidade, @Origem, @IdEmpresaFabricante, @IdDoacao)";

            var parametros = new Dictionary<string, object>
            {
                {"@Nome", Nome},
                {"@Descricao", Descricao},
                {"@DataValidade", DataValidade},
                {"@Quantidade", Quantidade},
                {"@Origem", Origem},
                {"@IdEmpresaFabricante", IdEmpresaFabricante},
                {"@IdDoacao", IdDoacao.IsNull ? (object)DBNull.Value : IdDoacao.Value}
            };
            sql.ExecutarComParametros(query, parametros);
        }

    }
}
