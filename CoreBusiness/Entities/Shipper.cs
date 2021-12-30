namespace CoreBusiness.Entities
{
    public class Shipper
    {
        public int Name { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public int CountryId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

    }
}
