using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class ShipperValueObject
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ShipperValueObject(int? id, string name, string mail, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Email = mail;
            this.Phone = phone;
        }
    }
}
