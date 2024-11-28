using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2024_2
{
    internal class Neo4j : IDisposable
    {
        public IDriver driver;

        public void Conectar()
        {
            if (driver == null)
            {
                string uri = "neo4j+s://8f8e1f98.databases.neo4j.io";
                string user = "neo4j";
                string password = "Noh5JL8vhG2qKFfzHu4R7zKOjdSdjKTU-Xo-NTWAlT4";
                driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
            }
        }

        public async Task ExecutarComandoAsync(string query, Dictionary<string, object> parametros)
        {
            Conectar();
            var session = driver.AsyncSession();
            await session.RunAsync(query, parametros);
            await session.CloseAsync();
            Dispose();
        }

        public async Task<IResultCursor> ExecutarConsultaAsync(string query)
        {
            Conectar();
            var session = driver.AsyncSession(); // Abre uma nova sessão
            try
            {
                return await session.RunAsync(query); // Retorna o resultado da consulta
            }
            finally
            {
                await session.CloseAsync(); // Garante o fechamento da sessão
            }
        }

        public async Task<DataTable> DTConsulta(string query)
        {
            Conectar(); // Garante que a conexão está ativa
            var dt = new DataTable();

            using (var session = driver.AsyncSession()) // Usa 'using' para fechar a sessão corretamente
            {
                try
                {
                    var result = await session.RunAsync(query); // Executa a consulta
                    var records = await result.ToListAsync();   // Consome todos os registros antes de fechar

                    // Verifica se há registros retornados
                    if (records.Count > 0)
                    {
                        // Adiciona as colunas com base nas chaves do primeiro registro
                        foreach (var key in records[0].Keys)
                        {
                            dt.Columns.Add(key);
                        }

                        // Adiciona os valores das colunas ao DataTable
                        foreach (var record in records)
                        {
                            var row = dt.NewRow();
                            foreach (var key in record.Keys)
                            {
                                row[key] = record[key]?.ToString(); // Adiciona o valor da célula
                            }
                            dt.Rows.Add(row);
                        }
                    }
                }
                finally
                {
                    await session.CloseAsync(); // Fecha a sessão corretamente
                }
            }

            return dt;
        }

        public async Task<DataSet> DSConsulta(string query)
        {
            var ds = new DataSet();
            var result = await ExecutarConsultaAsync(query);
            var records = await result.ToListAsync();
            var dt = new DataTable();
            foreach (var key in records[0].Keys)
            {
                dt.Columns.Add(key);
            }
            foreach (var record in records)
            {
                var row = dt.NewRow();
                foreach (var key in record.Keys)
                {
                    row[key] = record[key].ToString();
                }
                dt.Rows.Add(row);
            }
            ds.Tables.Add(dt);
            return ds;
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver = null; // Certifique-se de que o driver é redefinido
            }
        }
    }
}