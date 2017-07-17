using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class BillDataAccessLayer
    {
        private readonly MySqlDbConnection _mySqlDbConnection;

        public BillDataAccessLayer()
        {
            _mySqlDbConnection = MySqlDbConnection.GetConnection();
        }

        public DataTable GetAllBill()
        {
            const string query = "select * from bill";
            return _mySqlDbConnection.ExecuteSelectQuery(query);
        }

        public bool CreateNewBill(int idCus, DateTime dateOrder, DateTime expectedDateOrder, int total, string addr, string dis, string city, string note, int status, int idShipper)
        {
            const string query = "INSERT INTO bill (id_customer, date_order, expected_date_order, total, address, district, city, note, status, id_shipper) VALUES (@cus, @dateOrder, @expDateOrder, @total, @addr, @dis, @city, @note, @stt, @shipper)";
            var sqlParameters = new MySqlParameter[6];
            sqlParameters[0] = new MySqlParameter("@cus", MySqlDbType.Int32) { Value = idCus };
            sqlParameters[1] = new MySqlParameter("@dateOrder", MySqlDbType.DateTime) { Value = dateOrder };
            sqlParameters[2] = new MySqlParameter("@expDateOrder", MySqlDbType.DateTime) { Value = expectedDateOrder };
            sqlParameters[3] = new MySqlParameter("@total", MySqlDbType.String) { Value = total };
            sqlParameters[4] = new MySqlParameter("@addr", MySqlDbType.String) { Value = addr };
            sqlParameters[5] = new MySqlParameter("@dis", MySqlDbType.String) { Value = dis };
            sqlParameters[6] = new MySqlParameter("@city", MySqlDbType.String) { Value = city };
            sqlParameters[7] = new MySqlParameter("@note", MySqlDbType.Text) { Value = note };
            sqlParameters[8] = new MySqlParameter("@stt", MySqlDbType.Int32) { Value = status };
            sqlParameters[9] = new MySqlParameter("@shipper", MySqlDbType.Int32) { Value = idShipper };
            return _mySqlDbConnection.ExecuteInsertQuery(query, sqlParameters);
        }

        public bool UpdateBillNote(int? BillId, string note)
        {
            const string query = "UPDATE bill set note = @note where id = @id";
            var sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("@note", MySqlDbType.VarChar) { Value = note };
            sqlParameters[1] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = BillId };
            return _mySqlDbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }

        public bool UpdateBillStatus(int? BillId, int status)
        {
            const string query = "UPDATE bill set status = @status where id = @id";
            var sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("@status", MySqlDbType.Int32) { Value = status };
            sqlParameters[1] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = BillId };
            return _mySqlDbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }

        public bool UpdateBillShipper(int? BillId, int shipperId)
        {
            const string query = "UPDATE bill set id_shipper = @shipperId where id = @id";
            var sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("@shipperId", MySqlDbType.Int32) { Value = shipperId };
            sqlParameters[1] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = BillId };
            return _mySqlDbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }

        public DataTable GetBillById(int? id)
        {
            const string query = "select * from bill where id = @id limit 1";
            var sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = id };
            return _mySqlDbConnection.ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
