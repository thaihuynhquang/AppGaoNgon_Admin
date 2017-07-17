using System.Data;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class UserDataAccessLayer
    {
        private MySqlDbConnection _mySqlDbConnection;

        public UserDataAccessLayer()
        {
            _mySqlDbConnection = MySqlDbConnection.GetConnection();
        }
        
        public DataTable GetAllUser()
        {
            const string query = "select * from users";
            return _mySqlDbConnection.ExecuteSelectQuery(query);
        }

        public DataTable GetDetailUser(int id)
        {
            const string query = "select * from users where id = @id limit 1";
            var sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = id };
            return _mySqlDbConnection.ExecuteSelectQuery(query, sqlParameters);
        }

    }
}
