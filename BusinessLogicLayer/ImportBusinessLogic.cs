using DAO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using Winform_ShopGao;

namespace BusinessLogicLayer
{
    public class ImportBusinessLogic
    {
        private readonly ImportDataAccessLayer _importDataAccessLayer;

        public ImportBusinessLogic()
        {
            _importDataAccessLayer = new ImportDataAccessLayer();
        }

        public List<ImportValueObject> GetAllImportProducts()
        {
            var data = _importDataAccessLayer.GetAllImportProducts();
            return (from DataRow row in data.Rows
                    select new ImportValueObject( int.Parse(row[0].ToString()), int.Parse(row[1].ToString()), row[2].ToString(),
                    int.Parse(row[3].ToString()), row[4].ToString(), uint.Parse(row[5].ToString()), uint.Parse(row[6].ToString()),
                    int.Parse(row[7].ToString()) )).ToList();
        }

        public ProductValueObject GetUnitInStock(int productId)
        {
            var data = _importDataAccessLayer.GetUnitInStockByProductId(productId);
            return (from DataRow row in data.Rows
                    select new ProductValueObject(int.Parse(row["id"].ToString()),
                     row["name"].ToString(), int.Parse(row["id_type"].ToString()),
                     uint.Parse(row["price"].ToString()), row["description"].ToString(), int.Parse(row["new"].ToString()), uint.Parse(row["unitInStock"].ToString()), uint.Parse(row["unitOnBill"].ToString()))).First();
        }

        public bool ImportProduct(ImportValueObject import)
        {
            return _importDataAccessLayer.CreateImportProduct(import.supplierId, import.supplierName, import.productId, import.productName, import.quantity, import.unitPrice);
                   
        }

        public bool UpdateImportProduct(ImportValueObject import)
        {
            return _importDataAccessLayer.UpdateImportProduct(import.Id, import.supplierId, import.supplierName, import.productId, import.productName, import.quantity, import.unitPrice);
        }

        public List<ImportValueObject> Search(List<string> column, string value)
        {
            var data = Utility.Search("import", column, value);
            return (from DataRow row in data.Rows
                    select new ImportValueObject(int.Parse(row[0].ToString()), int.Parse(row[1].ToString()), row[2].ToString(),
                    int.Parse(row[3].ToString()), row[4].ToString(), uint.Parse(row[5].ToString()), uint.Parse(row[6].ToString()),
                    int.Parse(row[7].ToString()))).ToList();
        }
    }
}