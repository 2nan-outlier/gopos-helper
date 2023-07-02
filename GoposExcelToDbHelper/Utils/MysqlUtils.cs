using GoposExcelToDbHelper.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoposExcelToDbHelper.Utils
{
    public class MysqlUtils
    {
        private readonly string host;
        private readonly int port;
        private readonly string schema;
        private readonly string id;
        private readonly string pw;

        public MysqlUtils(string host, int port, string schema, string id, string pw)
        {
            this.host = host;
            this.port = port;
            this.schema = schema;
            this.id = id;
            this.pw = pw;
        }

        private MySqlConnection GetMysqlConnection() => new MySqlConnection(GetConnectionString());

        private string GetConnectionString()
        {
            var sql = new MySqlConnectionStringBuilder();
            sql.Server = host;
            sql.Port = (uint)port;
            sql.Database = schema;
            sql.UserID = id;
            sql.Password = pw;

            return sql.ConnectionString;
        }

        public bool DatabaseTestConnection()
        {
            try
            {
                using (var conn = GetMysqlConnection())
                {
                    conn.Open();
                    if (conn.State != ConnectionState.Open) return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool CreateTable(string query)
        {
            try
            {
                using (var conn = GetMysqlConnection())
                {
                    conn.Open();
                    if (conn.State != ConnectionState.Open) return false;

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool SelectTable(string tableNm)
        {
            try
            {
                using (var conn = GetMysqlConnection())
                {
                    conn.Open();
                    if (conn.State != ConnectionState.Open) return false;

                    var schema = Settings.Default.dbSchema;
                    var query = string.Empty;
                    query += $@"SELECT 1 FROM Information_schema.tables";
                    query += $@" WHERE table_schema = '{schema}'";
                    query += $@" AND table_name = '{tableNm}'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    
                    var result = cmd.ExecuteReader().Cast<object>().Count();
                    if (result > 0) return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
