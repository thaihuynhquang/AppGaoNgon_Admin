using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class ImageDataAccessLayer
    {
        private readonly MySqlDbConnection mySqlDbConnection;

        public ImageDataAccessLayer()
        {
            mySqlDbConnection =  MySqlDbConnection.GetConnection();
        }

        public bool CreateImage(string link, int? sp)
        {
            const string query = "insert into images(link,id_product) values (@link, @sp)";
            var sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("@link", MySqlDbType.VarChar) { Value = link };
            sqlParameters[1] = new MySqlParameter("@sp", MySqlDbType.Int32) { Value = sp };

            return mySqlDbConnection.ExecuteInsertQuery(query, sqlParameters);
        }

        public DataTable GetImageFileNameByProductId(int? id)
        {
            const string query = "select link from images, product where images.id_product = product.id and product.id = @id";
            var sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = id };
            return mySqlDbConnection.ExecuteSelectQuery(query, sqlParameters);
        }

        public bool UpdateImage( int? idSp, string imageLink)
        {
          const string query = "UPDATE images SET link=@link WHERE id_product = @idSp";
            var sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("@link", MySqlDbType.String) { Value = imageLink };
            sqlParameters[1] = new MySqlParameter("@idSp", MySqlDbType.String) { Value = idSp };
            return mySqlDbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }
    }
}
