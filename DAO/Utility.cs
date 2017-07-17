using System.Collections.Generic;
using System.Data;
using DAO;
using MySql.Data.MySqlClient;

namespace Winform_ShopGao
{
    public class Utility
    {
        private static readonly MySqlDbConnection _mySqlDbConnection = MySqlDbConnection.GetConnection();
        public static DataTable Search(string table, List<string> column,string value)
        {
            var query = $"select * from {table} where CONCAT_WS('',{string.Join(",", column)}) LIKE '%{value}%'";
            return _mySqlDbConnection.ExecuteSelectQuery(query);
        }
    }
}
