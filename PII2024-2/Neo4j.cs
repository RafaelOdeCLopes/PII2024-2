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
        private IDriver driver;

        public void Conectar()
        {
            string uri = "neo4j+s://fa112349.databases.neo4j.io";
            string user = "neo4j";
            string password = "dO-DzFf-io_S_ln8kPIqR-_bfBnlPjGVIqfjOO0QINA";
            driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
        }

        public async Task ExecutarComandoAsync(string query)
        {
            Conectar();
            var session = driver.AsyncSession();
            await session.RunAsync(query);
            await session.CloseAsync();
            Dispose();
        }

        public async Task<IResultCursor> ExecutarConsultaAsync(string query)
        {
            Conectar();
            var session = driver.AsyncSession();
            var result = await session.RunAsync(query);
            return result;
        }

        public async Task<DataTable> DTConsulta(string query)
        {
            var dt = new DataTable();
            var result = await ExecutarConsultaAsync(query);
            var records = await result.ToListAsync();
            if (records == null || records.Count == 0)
            {
                return dt;
            }
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
            driver?.Dispose();
        }
    }
}
