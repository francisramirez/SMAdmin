
using System;

namespace CoreBusiness.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public int JobTitleId { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public int? ManagerId { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string Region { get; set; }
    }
}
