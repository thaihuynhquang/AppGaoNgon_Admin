using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using Winform_ShopGao;

namespace BusinessLogicLayer
{
    public class ShipperBussinessLogic
    {
        private ShipperDataAccessLayer _shipperDataAccessLayer;

        public ShipperBussinessLogic()
        {
            _shipperDataAccessLayer = new ShipperDataAccessLayer();
        }

        public List<ShipperValueObject> GetAllShippers()
        {
            var dataTable = _shipperDataAccessLayer.GetAllShippers();
            return (from DataRow row in dataTable.Rows select new ShipperValueObject(int.Parse(row["id"].ToString()), row["name"].ToString(), row["email"].ToString(), row["phone"].ToString())).ToList();
        }

        public bool CreateShipper(ShipperValueObject shipper)
        {
            try
            {
                var listShippers = GetAllShippers();
                if (listShippers.Any(el => el.Email == shipper.Email && el.Phone == shipper.Phone))
                {
                    return false;
                }
                return _shipperDataAccessLayer.CreateNewShipper(shipper.Name, shipper.Phone, shipper.Email);
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool UpdateSupplier(ShipperValueObject shipper)
        {
            return _shipperDataAccessLayer.UpdateShipper(shipper.Id, shipper.Name, shipper.Email, shipper.Phone);
        }

        public ShipperValueObject GetDetailShipper(int id)
        {
            var dataTable = _shipperDataAccessLayer.GetDetailShipper(id);
            return (from DataRow row in dataTable.Rows
                    select new ShipperValueObject(int.Parse(row["id"].ToString()), row["name"].ToString(), row["email"].ToString(), row["phone"].ToString())).ToList().First();
        }

        public List<ShipperValueObject> Search(List<string> column, string value)
        {
            var data = Utility.Search("shippers", column, value);
            return (from DataRow row in data.Rows
                    select new ShipperValueObject(int.Parse(row["id"].ToString()), row["name"].ToString(), row["email"].ToString(), row["phone"].ToString())).ToList();
        }
    }
}
