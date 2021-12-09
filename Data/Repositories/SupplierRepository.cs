using CoreBusiness.Entities;
using System.Collections.Generic;
using UseCases.Contracts;
using System.Linq;
using UseCases.Exceptions;
using System.Linq.Expressions;
using System;

namespace DataInMemory.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        public List<Supplier> Entities { get; set; }

        public SupplierRepository()
        {
            this.Entities = new List<Supplier>()
            {
                new Supplier()
                {
                   SupplierId =1,
                   CompanyName="Supplier SWRXU",
                   ContactName="Adolphi, Stephan",
                   ConctatTitle="Purchasing Manager",
                   Address="2345 Gilbert St.",
                   City="London",
                   Country="UK",
                   Fax="(313) 555-0112",
                   Phone="(313) 555-0109",
                   PostalCode="10029",
                   Region="Asturias"
                },
                new Supplier()
                {
                   SupplierId = 2,
                   CompanyName="Supplier VHQZD",
                   ContactName="Hance, Jim",
                   ConctatTitle="Order Administrator",
                   Address="P.O. Box 5678",
                   City="New Orleans",
                   Country="LA",
                   Fax="(100) 555-0111",
                   Phone="031-678 90 12",
                   PostalCode="10034",
                   Region="Victoria"
                }
            };
        }
        public void Add(Supplier supplier)
        {
            if (Exists(sp => sp.CompanyName.Equals(supplier.CompanyName, System.StringComparison.OrdinalIgnoreCase)))
                throw new SupplierException("Supplier exists..");

            if (Entities != null && Entities.Count > 0)
            {
                var supplierId = Entities.Max(sp => sp.SupplierId);
                supplier.SupplierId = supplierId + 1;
            }
            else
                supplier.SupplierId = 1;

            this.Entities.Add(supplier);

        }

        public IEnumerable<Supplier> GetAll() => this.Entities;

        public Supplier GetById(int supplierId) => this.Entities.SingleOrDefault(sp => sp.SupplierId == supplierId);

        public void Remove(int supplierId)
        {
            var supplier = GetById(supplierId);
            this.Entities.Remove(supplier);
        }

        public void Update(Supplier supplier)
        {
            var supplierUpdate = GetById(supplier.SupplierId);

            if (supplierUpdate != null)
            {
                supplierUpdate.CompanyName = supplier.CompanyName;
                supplierUpdate.ContactName = supplier.ContactName;
                supplierUpdate.ConctatTitle = supplier.ConctatTitle;
                supplierUpdate.Address = supplier.Address;
                supplierUpdate.City = supplier.City;
                supplierUpdate.Region = supplier.Region;
                supplierUpdate.PostalCode = supplier.PostalCode;
                supplierUpdate.Country = supplier.Country;
                supplierUpdate.Phone = supplier.Phone;
                supplierUpdate.Fax = supplier.Fax;

            }
        }

        public bool Exists(Func<Supplier, bool> predicate)
        {
            return Entities.Any(predicate);
        }
    }
}
