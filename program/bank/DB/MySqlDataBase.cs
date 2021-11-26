using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Bank.DB
{
    class MySqlDataBase
    {
        [Obsolete]
        private static string _DBConnString = System.Configuration.ConfigurationSettings.AppSettings["DBConnectionString"];

        public static string DBConnString
        {
            get
            {
                return _DBConnString;
            }
        }

        public MySqlConnection connection()
        {
            MySqlConnection conn = new MySqlConnection(DBConnString);
            conn.Open();        //打开数据库连接
            return conn;
        }

        public MySqlCommand command(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, connection());
            return cmd;
        }

        //用于 delete update insert, 返回受影响的行数S
        public int Excute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        //用于select, 返回MySqlDataReader对象,包含select数据
        public MySqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
    }
}
