using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class BillValueObject
    {
        public int? Id { get; set; }
        public int IdCus { get; set; }
        public DateTime DateOrder { get; set; }
        public DateTime ExpectedDateOrder { get; set; }
        public int Total { get; set; }
        public string Addr { get; set; }
        public string Dis { get; set; }
        public string City { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public int IdShipper { get; set; }

        public BillValueObject(int? id, int idCus, DateTime dateOrder, DateTime expectedDateOrder, int total, string addr, string dis, string city, string note, int status, int idShipper)
        {
            this.Id = id;
            this.IdCus = idCus;
            this.DateOrder = dateOrder;
            this.ExpectedDateOrder = expectedDateOrder;
            this.Total = total;
            this.Addr = addr;
            this.Dis = dis;
            this.City = city;
            this.Note = note;
            this.Status = status == 1 ? "Đã xong" : "Đang chờ";
            this.IdShipper = idShipper;
        }
    }
}
