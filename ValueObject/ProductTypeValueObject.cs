using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class ProductTypeValueObject
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public ProductTypeValueObject(int? id, string name, string img = "")
        {
            this.Id = id;
            this.Name = name;
            this.Image = img;
        }
    }
}
