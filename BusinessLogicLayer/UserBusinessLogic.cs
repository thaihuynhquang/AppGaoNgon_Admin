using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ValueObject;
using Winform_ShopGao;

namespace BusinessLogicLayer
{
    public class UserBusinessLogic
    {
        private UserDataAccessLayer _userDataAccessLayer;

        public UserBusinessLogic()
        {
            _userDataAccessLayer = new UserDataAccessLayer();
        }

        public List<UserValueObject> GetAllUser()
        {
            var data = _userDataAccessLayer.GetAllUser();
            return  (from DataRow row in data.Rows select new UserValueObject(int.Parse(row[0].ToString()), row[3].ToString(), 
                row[1].ToString(), row[2].ToString(), row[4].ToString(), row[5].ToString())).ToList();
           
        }

        public UserValueObject GetDetailUser(int id)
        {
            var dataTable = _userDataAccessLayer.GetDetailUser(id);
            return (from DataRow row in dataTable.Rows
                    select new UserValueObject(int.Parse(row[0].ToString()), row[3].ToString(),
                row[1].ToString(), row[2].ToString(), row[4].ToString(), row[5].ToString())).ToList().First();
        }

        public List<UserValueObject> Search(List<string> column, string value)
        {
            var data = Utility.Search("users", column, value);
            return (from DataRow row in data.Rows
                    select new UserValueObject(int.Parse(row[0].ToString()), row[3].ToString(),
                row[1].ToString(), row[2].ToString(), row[4].ToString(), row[5].ToString())).ToList();
        }
    }
}
