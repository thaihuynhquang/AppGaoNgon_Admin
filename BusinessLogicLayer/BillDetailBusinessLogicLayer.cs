using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class BillDetailBusinessLogicLayer
    {
        private BillDetailDataAccessLayer _billDetailDataAccessLayer;

        public BillDetailBusinessLogicLayer()
        {
            _billDetailDataAccessLayer = new BillDetailDataAccessLayer();
        }

        public List<BillDetailValueObject> GetBillDetailsByBillId(int? id)
        {
            var dataTable = _billDetailDataAccessLayer.GetBillDetailsByBillId(id);
            return (from DataRow row in dataTable.Rows
                    select new BillDetailValueObject(int.Parse(row[0].ToString()), row[1].ToString(),
                        int.Parse(row[2].ToString()), int.Parse(row[3].ToString()))).ToList();
        }
    }
}
