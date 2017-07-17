using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class ProductTypeDataAccessLayer
    {
        private MySqlDbConnection _mySqlDbConnection;

        public ProductTypeDataAccessLayer()
        {
            _mySqlDbConnection =  MySqlDbConnection.GetConnection();
        }

        public DataTable GetAllProductTypes()
        {
            const string query = "select * from product_type";
            return _mySqlDbConnection.ExecuteSelectQuery(query);
        }

        public bool CreateNewProductType(string name, string image)
        {
            const string query = "INSERT INTO product_type(name, image) values (@name, @img)";
            var sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("@name", MySqlDbType.String) { Value = name };
            sqlParameters[1] = new MySqlParameter("@img", MySqlDbType.String) { Value = image };
            return _mySqlDbConnection.ExecuteInsertQuery(query, sqlParameters);
        }

        public bool UpdateProductType(int? productTypeId, string productTypeName, string productTypeImage)
        {
            const string query = "UPDATE product_type set name = @name, image = @image where id = @id";
            var sqlParameters = new MySqlParameter[3];
            sqlParameters[0] = new MySqlParameter("@name", MySqlDbType.VarChar) { Value = productTypeName };
            sqlParameters[1] = new MySqlParameter("@image", MySqlDbType.VarChar) { Value = productTypeImage };
            sqlParameters[2] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = productTypeId };
            return _mySqlDbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }

        public bool UpdateProductTypeNotImage(int? productTypeId, string productTypeName)
        {
            const string query = "UPDATE product_type set name = @name where id = @id";
            var sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("@name", MySqlDbType.VarChar) { Value = productTypeName };
            sqlParameters[1] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = productTypeId };
            return _mySqlDbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }

        public DataTable GetDetailProductType(int id)
        {
            const string query = "select * from product_type where id = @id limit 1";
            var sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = id };
            return _mySqlDbConnection.ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable GetImageFileNameByProductTypeId(int? id)
        {
            const string query = "SELECT image FROM product_type WHERE product_type.id = @id";
            var sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = id };
            return _mySqlDbConnection.ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
