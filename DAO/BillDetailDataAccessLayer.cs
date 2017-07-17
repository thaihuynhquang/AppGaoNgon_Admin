using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillDetailDataAccessLayer
    {
        private readonly MySqlDbConnection _mySqlDbConnection;

        public BillDetailDataAccessLayer()
        {
            _mySqlDbConnection = MySqlDbConnection.GetConnection();
        }

        public DataTable GetBillDetailsByBillId(int? id)
        {
            const string query = "SELECT p.id, p.name, p.price, bd.quantity FROM `bill_detail` bd INNER JOIN `product` p WHERE bd.id_product = p.id AND bd.id_bill = @id GROUP BY p.id";
            var sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = id };
            return _mySqlDbConnection.ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
