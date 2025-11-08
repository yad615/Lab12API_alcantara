namespace Lab12API_alcantara.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }

        public ICollection<Invoice> Invoices { get; set; }


    }
}
