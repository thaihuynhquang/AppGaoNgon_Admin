using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class UserValueObject
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Pass { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Addr { get; set; }

        public UserValueObject(int id, string name, string mail, string pass, string phone, string addr)
        {
            this.Id = id;
            this.Mail = mail;
            this.Pass = pass;
            this.Name = name;
            this.Phone = phone;
            this.Addr = addr;
        }
    }
}
