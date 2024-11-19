using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2024_2
{
    internal class Familias
    {

        SQLServer sql = new SQLServer();
        public int Id { get; set; }
        public string NomeResponsavel { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int NumeroMembros { get; set; }

        public void Inserir()
        {
            string query = @"INSERT INTO familias 
                     (nome_responsavel, endereco, telefone, numero_membros)
                     VALUES 
                     (@NomeResponsavel, @Endereco, @Telefone, @NumeroMembros)";

            var parametros = new Dictionary<string, object>
            {
                {"@NomeResponsavel", NomeResponsavel},
                {"@Endereco", Endereco},
                {"@Telefone", Telefone},
                {"@NumeroMembros", NumeroMembros},

            };
            sql.ExecutarComParametros(query, parametros);
        }


        public async Task InserirNoNeo4j(Neo4j neo4j)
        {
            // Comando Cypher utilizando parâmetros
            string query = @"
    CREATE (f:Familia {
        nomeResponsavel: $nomeResponsavel,
        endereco: $endereco,
        telefone: $telefone,
        numeroMembros: $numeroMembros
    })";

            // Dicionário de parâmetros que serão passados para o Cypher
            var parametros = new Dictionary<string, object>
    {
        { "nomeResponsavel", NomeResponsavel },
        { "endereco", Endereco },
        { "telefone", Telefone },
        { "numeroMembros", NumeroMembros }
    };

            // Passando os parâmetros para o comando
            await neo4j.ExecutarComandoAsync(query, parametros);
        }

    }
}
