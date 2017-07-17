using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class SupplierDataAccessLayer
    {
        private MySqlDbConnection _mySqlDbConnection;

        public SupplierDataAccessLayer()
        {
            _mySqlDbConnection = MySqlDbConnection.GetConnection();
        }

        public DataTable GetAllSupplier()
        {
            const string query = "select * from suppliers";
            return _mySqlDbConnection.ExecuteSelectQuery(query);
        }

        public bool CreateNewSupplier(string name, string addr, string mail, string phone)
        {
            const string query = "INSERT INTO suppliers (name, addr, phone, email) VALUES(@name, @add, @phone, @mail)";
            var sqlParameters = new MySqlParameter[4];
            sqlParameters[0] = new MySqlParameter("@name", MySqlDbType.VarChar) {Value = name};
            sqlParameters[1] = new MySqlParameter("@add", MySqlDbType.VarChar) { Value = addr };
            sqlParameters[2] = new MySqlParameter("@mail", MySqlDbType.VarChar) { Value = mail };
            sqlParameters[3] = new MySqlParameter("@phone", MySqlDbType.VarChar) { Value = phone };
            return _mySqlDbConnection.ExecuteInsertQuery(query,sqlParameters);
        }

        public bool UpdateSupplier(int? supplierId, string supplierName, string supplierAddress, string supplierEmail, string supplierPhone)
        {
            const string query = "UPDATE suppliers set name = @name, addr = @addr, email= @mail, phone =@phone where id = @id";
            var sqlParameters = new MySqlParameter[5];
            sqlParameters[0] = new MySqlParameter("@name", MySqlDbType.VarChar) { Value = supplierName };
            sqlParameters[1] = new MySqlParameter("@addr", MySqlDbType.VarChar) { Value = supplierAddress };
            sqlParameters[2] = new MySqlParameter("@mail", MySqlDbType.VarChar) { Value = supplierEmail };
            sqlParameters[3] = new MySqlParameter("@phone", MySqlDbType.VarChar) { Value = supplierPhone };
            sqlParameters[4] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = supplierId };
            return _mySqlDbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }

        public bool DeleteSupplier(int id)
        {
            const string query = "Delete from suppliers where id = @id";
            var sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("@id", MySqlDbType.String) { Value = id };
            return _mySqlDbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }

        public DataTable GetDetailSupplier(int id)
        {
            const string query = "select * from suppliers where id = @id limit 1";
            var sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = id };
            return _mySqlDbConnection.ExecuteSelectQuery(query,sqlParameters);
        }
    }
}
