namespace ValueObject
{
    public class SupplierValueObject
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public SupplierValueObject(int? id,string name, string add, string mail, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Address = add;
            this.Email = mail;
            this.Phone = phone;
        }
    }
}
