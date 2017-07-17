using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class ProductValueObject
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public int IdType { get; set; }
        public uint Price { get; set; }
        public string Description { get; set; }
        public int Inew { get; set; }
        public uint unitInStock { get; set; }
        public uint unitOnBill { get; set; }

        public ProductValueObject(int? id, string name, int idType, uint price, string desc, int inew, uint unitInStock, uint unitOnBill)
        {
            this.Id = id;
            this.Name = name;
            this.IdType = idType;
            this.Price = price;
            this.Description = desc;
            this.Inew = inew;
            this.unitInStock = unitInStock;
            this.unitOnBill = unitOnBill;
        }
    }
}
