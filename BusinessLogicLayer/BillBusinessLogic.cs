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
    public class BillBusinessLogic
    {
        private BillDataAccessLayer _billDataAccessLayer;

        public BillBusinessLogic()
        {
            _billDataAccessLayer = new BillDataAccessLayer();
        }

        public List<BillValueObject> GetAllBill()
        {
            var data = _billDataAccessLayer.GetAllBill();
            return (from DataRow row in data.Rows
                    select new BillValueObject(int.Parse(row[0].ToString()), int.Parse(row[1].ToString()),
                        DateTime.Parse(row[2].ToString()), DateTime.Parse(row[3].ToString()), int.Parse(row[4].ToString()), row[5].ToString(),
                        row[6].ToString(), row[7].ToString(), row[8].ToString(), int.Parse(row[9].ToString()),
                        int.Parse(row[10].ToString()))).ToList();
        }

        public bool UpdateBillNote(int? BillId, string note)
        {
            return _billDataAccessLayer.UpdateBillNote(BillId, note);
        }

        public bool UpdateBillStatus(int? BillId, int status)
        {
            return _billDataAccessLayer.UpdateBillStatus(BillId, status);
        }

        public bool UpdateBillShipper(int? BillId, int shipperId)
        {
            return _billDataAccessLayer.UpdateBillShipper(BillId, shipperId);
        }

        public BillValueObject GetBillById(int? id)
        {
            var dataTable = _billDataAccessLayer.GetBillById(id);
            return (from DataRow row in dataTable.Rows
                    select new BillValueObject(int.Parse(row[0].ToString()), int.Parse(row[1].ToString()),
                        DateTime.Parse(row[2].ToString()), DateTime.Parse(row[3].ToString()), int.Parse(row[4].ToString()), row[5].ToString(),
                        row[6].ToString(), row[7].ToString(), row[8].ToString(), int.Parse(row[9].ToString()),
                        int.Parse(row[10].ToString()))).ToList().First();
        }

        public List<BillValueObject> Search(List<string> column, string value)
        {
            var data = Utility.Search("Bill", column, value);
            return (from DataRow row in data.Rows
                select new BillValueObject(int.Parse(row[0].ToString()), int.Parse(row[1].ToString()),
                    DateTime.Parse(row[2].ToString()), DateTime.Parse(row[3].ToString()), int.Parse(row[4].ToString()),
                    row[5].ToString(),
                    row[6].ToString(), row[7].ToString(), row[8].ToString(), int.Parse(row[9].ToString()),
                    int.Parse(row[10].ToString()))).ToList();
        }
    }
}
