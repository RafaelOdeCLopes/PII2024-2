using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2024_2
{
    internal class EmpresasFabricantes
    {
        SQLServer sql = new SQLServer();
        public int Id { get; set; }
        public string NomeEmpresa { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    
     public void Inserir()
        {
            string query = @"INSERT INTO empresas_fabricantes 
                     (nome_empresa, endereco, telefone)
                     VALUES 
                     (@NomeEmpresa, @Endereco, @Telefone)";

            var parametros = new Dictionary<string, object>
            {
                {"@NomeEmpresa", NomeEmpresa},
                {"@Endereco", Endereco},
                {"@Telefone", Telefone},

            };
            sql.ExecutarComParametros(query, parametros);
        }
    }
}
