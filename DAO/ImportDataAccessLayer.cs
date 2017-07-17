using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ValueObject;

namespace DAO
{
    public class ImportDataAccessLayer
    {
        private MySqlDbConnection _mySqlDbConnection;

        public ImportDataAccessLayer()
        {
            _mySqlDbConnection = MySqlDbConnection.GetConnection();
        }

        public bool CreateImportProduct(int supplierId, string supplierName, int productId, string productName, uint quantity, uint unitPrice)
        {
            const string query = "INSERT INTO import (supplierId, supplierName, productId, productName, quantity, unitPrice, totalPrice) VALUES (@supplierId, @supplierName, @productId, @productName, @quantity, @unitPrice, @totalPrice)";

            var sqlParameters = new MySqlParameter[7];
            sqlParameters[0] = new MySqlParameter("@supplierId", MySqlDbType.Int32) { Value = supplierId };
            sqlParameters[1] = new MySqlParameter("@supplierName", MySqlDbType.VarChar) { Value = supplierName };
            sqlParameters[2] = new MySqlParameter("@productId", MySqlDbType.Int32) { Value = productId };
            sqlParameters[3] = new MySqlParameter("@productName", MySqlDbType.VarChar) { Value = productName };
            sqlParameters[4] = new MySqlParameter("@quantity", MySqlDbType.Int32) { Value = quantity };
            sqlParameters[5] = new MySqlParameter("@unitPrice", MySqlDbType.Int32) { Value = unitPrice };
            sqlParameters[6] = new MySqlParameter("@totalPrice", MySqlDbType.Int32) { Value = quantity * unitPrice };

            return _mySqlDbConnection.ExecuteInsertQuery(query, sqlParameters);
        }

        public bool UpdateImportProduct(int? Id, int supplierId, string supplierName, int productId, string productName, uint quantity, uint unitPrice)
        {
            const string query = "UPDATE import set supplierId = @supplierId, supplierName = @supplierName, productId = @productId, productName = @productName, quantity = @quantity, unitPrice = @unitPrice, totalPrice = @totalPrice  where id = @id";

            var sqlParameters = new MySqlParameter[8];
            sqlParameters[0] = new MySqlParameter("@supplierId", MySqlDbType.Int32) { Value = supplierId };
            sqlParameters[1] = new MySqlParameter("@supplierName", MySqlDbType.VarChar) { Value = supplierName };
            sqlParameters[2] = new MySqlParameter("@productId", MySqlDbType.Int32) { Value = productId };
            sqlParameters[3] = new MySqlParameter("@productName", MySqlDbType.VarChar) { Value = productName };
            sqlParameters[4] = new MySqlParameter("@quantity", MySqlDbType.Int32) { Value = quantity };
            sqlParameters[5] = new MySqlParameter("@unitPrice", MySqlDbType.Int32) { Value = unitPrice };
            sqlParameters[6] = new MySqlParameter("@totalPrice", MySqlDbType.Int32) { Value = quantity * unitPrice };
            sqlParameters[7] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = Id };
            return _mySqlDbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }

        public DataTable GetAllImportProducts()
        {
            const string query = "select * from import";
            return _mySqlDbConnection.ExecuteSelectQuery(query);
        }

        public DataTable GetUnitInStockByProductId(int productId)
        {
            const string query = "SELECT pro.id, pro.name, pro.id_type, pro.price, pro.description, pro.new, SUM(quantity) as unitInStock, pro.unitOnBill FROM product pro INNER JOIN import im ON pro.id=im.productId Where im.productId = @productId";
            var sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("@productId", MySqlDbType.Int32) { Value = productId };
            return _mySqlDbConnection.ExecuteSelectQuery(query, sqlParameters);
        }
    }
}