namespace MHG.Mapper {
    public class Customer {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
    }

    public class CustomerDto {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
