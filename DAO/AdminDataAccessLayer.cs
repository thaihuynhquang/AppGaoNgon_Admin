using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AdminDataAccessLayer
    {
        private MySqlDbConnection _mySqlDbConnection;

        public AdminDataAccessLayer()
        {
            _mySqlDbConnection = MySqlDbConnection.GetConnection();
        }

        public bool Login(string user, string pass)
        {
            const string query = "select * from user_administrator where username = @user and password = @pass";
            var sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("@user", MySqlDbType.VarChar) { Value = user };
            sqlParameters[1] = new MySqlParameter("@pass", MySqlDbType.VarChar) { Value = pass };

            return _mySqlDbConnection.ExecuteSelectQuery(query, sqlParameters).Rows.Count > 0;
        }

        public bool ChangePassword(string pass)
        {
            const string query = "UPDATE user_administrator SET user_administrator.password = @pass";
            var sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("@pass", MySqlDbType.VarChar) { Value = pass };

            return _mySqlDbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }
    }
}
