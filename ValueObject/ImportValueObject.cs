using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
   public class ImportValueObject
    {
        public int? Id { get; set; }
        public int supplierId { get; set; }
        public string supplierName { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public uint quantity { get; set; }
        public uint unitPrice { get; set; }
        public int totalPrice { get; set; }

    public ImportValueObject(int? id, int supplierId, string supplierName, int productId, string productName, uint quantity, uint unitPrice, int totalPrice)
        {
            this.Id = id;
            this.supplierId = supplierId;
            this.supplierName = supplierName;
            this.productId = productId;
            this.productName = productName;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.totalPrice = totalPrice;

        }
    }
}
