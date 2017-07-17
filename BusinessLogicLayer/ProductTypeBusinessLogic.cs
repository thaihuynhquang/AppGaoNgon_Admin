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
    public class ProductTypeBusinessLogic
    {
        private ProductTypeDataAccessLayer _productTypeDataAccessLayer;

        public ProductTypeBusinessLogic()
        {
            _productTypeDataAccessLayer = new ProductTypeDataAccessLayer();
        }

        public List<ProductTypeValueObject> GetAllProductTypes()
        {
            var dataTable = _productTypeDataAccessLayer.GetAllProductTypes();
            return (from DataRow row in dataTable.Rows
                    select new ProductTypeValueObject( int.Parse(row["id"].ToString()), row["name"].ToString(), row["image"].ToString() )).ToList();
        }

        public bool CreateProductType(ProductTypeValueObject productType)
        {
            try
            {
                var listProductType = GetAllProductTypes();
                if (listProductType.Any(x => x.Name.Trim() == productType.Name.Trim()))
                {
                    return false;
                }
                return _productTypeDataAccessLayer.CreateNewProductType(productType.Name, productType.Image);
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool UpdateProductType(ProductTypeValueObject productType)
        {
            if(productType.Image == "")
            {
                return _productTypeDataAccessLayer.UpdateProductTypeNotImage(productType.Id, productType.Name);
            }
            return _productTypeDataAccessLayer.UpdateProductType(productType.Id, productType.Name, productType.Image);
        }

        public ProductTypeValueObject GetDetailProductType(int id)
        {
            var dataTable = _productTypeDataAccessLayer.GetDetailProductType(id);
            return (from DataRow row in dataTable.Rows
                    select new ProductTypeValueObject(int.Parse(row["id"].ToString()), row["name"].ToString(), row["image"].ToString())).ToList().First();
        }

        public List<ProductTypeValueObject> Search(List<string> column, string value)
        {
            var data = Utility.Search("product_type", column, value);
            return (from DataRow row in data.Rows
                    select new ProductTypeValueObject(int.Parse(row["id"].ToString()), row["name"].ToString(), row["image"].ToString())).ToList();
        }

        public string GetImageFileName(int? id)
        {
            var data = _productTypeDataAccessLayer.GetImageFileNameByProductTypeId(id);
            var rows = data.Rows.Cast<DataRow>().ToArray();
            return rows.First().ItemArray.First().ToString();
        }
    }
}
