using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2024_2
{
    internal class EmpresasEntregadoras
    {
        SQLServer sql = new SQLServer();
        public int Id { get; set; }
        public string NomeEmpresa { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public void Inserir()
        {



            string query = @"INSERT INTO empresas_entregadoras 
               (nome_empresa, endereco, telefone)
               VALUES 
               (@NomEmpresa, @Endereco, @Telefone)";

            var parametros = new Dictionary<string, object>
            {
            {"@nomeEmpresa", NomeEmpresa},
            {"@Endereco", Endereco},
            {"@Telefone", Telefone},


     };
            sql.ExecutarComParametros(query, parametros);
        }
    }

}
