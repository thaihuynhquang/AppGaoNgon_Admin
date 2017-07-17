using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class BillDetailValueObject
    {
        public int? Id { get; set; }
        public string Product_Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public BillDetailValueObject(int? id, string productName, int price, int quantity)
        {
            this.Id = id;
            this.Product_Name = productName;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
