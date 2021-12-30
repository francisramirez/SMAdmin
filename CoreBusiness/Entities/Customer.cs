namespace CoreBusiness.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public int  CountryId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

    }
}
