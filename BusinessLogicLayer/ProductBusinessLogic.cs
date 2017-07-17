using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DAO;
using ValueObject;
using Winform_ShopGao;

namespace BusinessLogicLayer
{

    public class ProductBusinessLogic
    {
        private readonly ProductDataAccessLayer _productDataAccessLayer;
        private readonly ImportDataAccessLayer importDataAccessLayer;
        private readonly ImageDataAccessLayer imageDataAccessLayer;

        public ProductBusinessLogic()
        {
            _productDataAccessLayer = new ProductDataAccessLayer();
            importDataAccessLayer = new ImportDataAccessLayer();
            imageDataAccessLayer = new ImageDataAccessLayer();
        }

        public List<ProductValueObject> GetAllProduct()
        {
            var data = _productDataAccessLayer.GetAllProduct();
            return (from DataRow row in data.Rows
                    select new ProductValueObject(int.Parse(row["id"].ToString()),
                    row["name"].ToString(), int.Parse(row["id_type"].ToString()), uint.Parse(row["price"].ToString()),
                    row["description"].ToString(), int.Parse(row["new"].ToString()),
                    uint.Parse(row["unitInStock"].ToString()), uint.Parse(row["unitOnBill"].ToString()))).ToList();

        }

        public bool CreateNewProduct(ProductValueObject productValueObject, ImageValueObject image)
        {
            try
            {
                var listProduct = GetAllProduct();
                if (listProduct.Any(x => x.IdType == productValueObject.IdType && x.Name.Trim() == productValueObject.Name.Trim()))
                {
                    return false;
                }
                _productDataAccessLayer.CreateNewProduct(productValueObject.Name, productValueObject.IdType, productValueObject.Price,
                    productValueObject.Description, productValueObject.Inew);

                listProduct = GetAllProduct();
                var insertedProduct =
                    listProduct.First(x => x.IdType == productValueObject.IdType && x.Name == productValueObject.Name);
                image.idSp = insertedProduct.Id;

                imageDataAccessLayer.CreateImage(image.link, image.idSp);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public ProductValueObject GetProductById(int? rowId)
        {
            var data = _productDataAccessLayer.GetProductById(rowId);
            return (from DataRow row in data.Rows
                    select new ProductValueObject(int.Parse(row["id"].ToString()),
                     row["name"].ToString(), int.Parse(row["id_type"].ToString()),
                     uint.Parse(row["price"].ToString()), row["description"].ToString(), int.Parse(row["new"].ToString()), uint.Parse(row["unitInStock"].ToString()), uint.Parse(row["unitOnBill"].ToString()))).First();
        }

        public bool UpdateProduct(ProductValueObject productValueObject, ImageValueObject image = null)
        {
            if (image == null)
                return _productDataAccessLayer.UpdateProduct(productValueObject.Id, productValueObject.Name,
                    productValueObject.IdType, productValueObject.Price, productValueObject.Description,
                    productValueObject.Inew);

            var x = imageDataAccessLayer.UpdateImage(image.idSp, image.link);
            if (!x)
            {
                throw new Exception("Cannot update image.");
            }
            return _productDataAccessLayer.UpdateProduct(productValueObject.Id, productValueObject.Name,
                productValueObject.IdType, productValueObject.Price, productValueObject.Description,
                productValueObject.Inew);
        }

        public bool UpdateUnitInStock(ProductValueObject product)
        {
            return _productDataAccessLayer.UpdateUnitInStock(product.Id, product.unitInStock);
        }

        public bool UpdateUnitOnBill(ProductValueObject product)
        {
            return _productDataAccessLayer.UpdateUnitOnBill(product.Id, product.unitOnBill);
        }

        public string GetImageFileName(int? id)
        {
            var data = imageDataAccessLayer.GetImageFileNameByProductId(id);
            var rows = data.Rows.Cast<DataRow>().ToArray();
            return rows.First().ItemArray.First().ToString();
        }

        public List<ProductValueObject> Search(List<string> column, string value)
        {
            var data = Utility.Search("Product", column, value);
            return (from DataRow row in data.Rows
                    select new ProductValueObject(int.Parse(row["id"].ToString()),
                 row["name"].ToString(), int.Parse(row["id_type"].ToString()),
                 uint.Parse(row["price"].ToString()), row["description"].ToString(), int.Parse(row["new"].ToString()), uint.Parse(row["unitInStock"].ToString()), uint.Parse(row["unitOnBill"].ToString()))).ToList();
        }
    }
}
