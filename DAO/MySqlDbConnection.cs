using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MySqlDbConnection
    {
        private MySqlDataAdapter _myAdapter;
        private readonly MySqlConnection _conn;
        private static readonly MySqlDbConnection _singleton = new MySqlDbConnection();
        private MySqlDbConnection()
        {
            _conn = new MySqlConnection("server=localhost;database=appgao_db;uid=root;pwd=;Convert Zero Datetime=True;charset=utf8");
        }

        public static MySqlDbConnection GetConnection()
        {
            return _singleton;
        }

        private MySqlConnection OpenConnection()
        {

            if (_conn.State == ConnectionState.Closed || _conn.State == ConnectionState.Broken)
            {
                _conn.Open();
            }
            return _conn;
        }

        public DataTable ExecuteSelectQuery(string query, MySqlParameter[] sqlParameter = null)
        {
            var myCommand = new MySqlCommand();
            DataTable dataTable;
            _myAdapter = new MySqlDataAdapter();
            var ds = new DataSet();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = query;
                if (sqlParameter != null)
                {
                    myCommand.Parameters.AddRange(sqlParameter);
                }
                myCommand.ExecuteNonQuery();
                _myAdapter.SelectCommand = myCommand;
                _myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (MySqlException e)
            {

                return null;
            }
            finally
            {
                myCommand.Connection.Close();
            }
            return dataTable;
        }

        public bool ExecuteInsertQuery(string query, MySqlParameter[] sqlParameter)
        {
            var myCommand = new MySqlCommand();
            _myAdapter = new MySqlDataAdapter();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = query;
                myCommand.Parameters.AddRange(sqlParameter);
                _myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                return false;
            }
            finally
            {
                myCommand.Connection.Close();
            }
            return true;
        }

        public bool ExecuteUpdateQuery(string query, MySqlParameter[] sqlParameter)
        {
            var myCommand = new MySqlCommand();
            _myAdapter = new MySqlDataAdapter();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = query;
                myCommand.Parameters.AddRange(sqlParameter);
                _myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                return false;
            }
            finally
            {
                myCommand.Connection.Close();
            }
            return true;
        }
    }
}
