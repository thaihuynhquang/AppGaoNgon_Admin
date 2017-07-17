using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAO
{
   public class ShipperDataAccessLayer
    {
        private MySqlDbConnection _mySqlDbConnection;

        public ShipperDataAccessLayer()
        {
            _mySqlDbConnection = MySqlDbConnection.GetConnection();
        }

        public DataTable GetAllShippers()
        {
            const string query = "select * from shippers";
            return _mySqlDbConnection.ExecuteSelectQuery(query);
        }

        public bool CreateNewShipper(string name, string phone, string mail)
        {
            const string query = "INSERT INTO shippers (name, phone, email) VALUES(@name, @phone, @mail)";
            var sqlParameters = new MySqlParameter[3];
            sqlParameters[0] = new MySqlParameter("@name", MySqlDbType.VarChar) { Value = name };
            sqlParameters[1] = new MySqlParameter("@mail", MySqlDbType.VarChar) { Value = mail };
            sqlParameters[2] = new MySqlParameter("@phone", MySqlDbType.VarChar) { Value = phone };
            return _mySqlDbConnection.ExecuteInsertQuery(query, sqlParameters);
        }

        public bool UpdateShipper(int? shipperId, string shipperName, string shipperEmail, string shipperPhone)
        {
            const string query = "UPDATE shippers set name = @name, email= @mail, phone =@phone where id = @id";
            var sqlParameters = new MySqlParameter[4];
            sqlParameters[0] = new MySqlParameter("@name", MySqlDbType.VarChar) { Value = shipperName };
            sqlParameters[1] = new MySqlParameter("@mail", MySqlDbType.VarChar) { Value = shipperEmail };
            sqlParameters[2] = new MySqlParameter("@phone", MySqlDbType.VarChar) { Value = shipperPhone };
            sqlParameters[3] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = shipperId };
            return _mySqlDbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }

        public DataTable GetDetailShipper(int id)
        {
            const string query = "select * from shippers where id = @id limit 1";
            var sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = id };
            return _mySqlDbConnection.ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
