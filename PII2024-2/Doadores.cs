using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2024_2
{
    internal class Doadores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }


        public async Task InserirNoNeo4j(Neo4j neo4j)
        {
            // Comando Cypher utilizando parâmetros
            string query = @"
    MATCH (counter:Counter1 {type: 'doadores'})
    SET counter.count = counter.count + 1
    WITH counter.count AS id
    CREATE (f:doadores {
        id: id,
        nome: $nome,
        contato: $contato
    })";

            // Dicionário de parâmetros que serão passados para o Cypher
            var parametros = new Dictionary<string, object>
    {
        { "nome", Nome },
        { "contato", Contato },
    };

            // Passando os parâmetros para o comando
            await neo4j.ExecutarComandoAsync(query, parametros);
        }
    }
}
