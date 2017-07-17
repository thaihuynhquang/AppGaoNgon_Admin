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
    public class SupplierBusinessLogic
    {
        private SupplierDataAccessLayer _supplierDataAccessLayer;

        public SupplierBusinessLogic()
        {
            _supplierDataAccessLayer = new SupplierDataAccessLayer();
        }

        public List<SupplierValueObject> GetallSupplier()
        {
            var dataTable = _supplierDataAccessLayer.GetAllSupplier();
            return (from DataRow row in dataTable.Rows select new SupplierValueObject( int.Parse(row["id"].ToString()), row["name"].ToString(), row["addr"].ToString(), row["email"].ToString(), row["phone"].ToString() )).ToList();
        }

        public bool CreateSupplier(SupplierValueObject supplier)
        {
            try
            {
                var listSuppliers = GetallSupplier();
                if(listSuppliers.Any(el => el.Email == supplier.Email && el.Phone == supplier.Phone))
                {
                    return false;
                }
                return _supplierDataAccessLayer.CreateNewSupplier(supplier.Name, supplier.Address, supplier.Email, supplier.Phone);
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool UpdateSupplier(SupplierValueObject supplier)
        {
            return _supplierDataAccessLayer.UpdateSupplier(supplier.Id, supplier.Name, supplier.Address, supplier.Email,
                supplier.Phone);
        }

        public SupplierValueObject GetDetailSupplier(int id)
        {
            var dataTable = _supplierDataAccessLayer.GetDetailSupplier(id);
            return (from DataRow row in dataTable.Rows
                    select new SupplierValueObject(int.Parse(row["id"].ToString()), row["name"].ToString(), row["addr"].ToString(), row["email"].ToString(), row["phone"].ToString())).ToList().First();
        }

        public bool DeleteSupplier(int id)
        {
            return _supplierDataAccessLayer.DeleteSupplier(id);
        }

        public List<SupplierValueObject> Search(List<string> column, string value)
        {
            var data = Utility.Search("suppliers", column, value);
            return (from DataRow row in data.Rows
                    select new SupplierValueObject(int.Parse(row["id"].ToString()), row["name"].ToString(), row["addr"].ToString(), row["email"].ToString(), row["phone"].ToString())).ToList();
        }
    }
}