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
            sql.Port = 3301;
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
    }
}
