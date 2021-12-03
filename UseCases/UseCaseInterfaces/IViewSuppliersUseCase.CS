using CoreBusiness.Entities;
using System.Collections.Generic;
namespace UseCases.UseCaseInterfaces
{
    public interface IViewSuppliersUseCase 
    {
        public List<Supplier> GetSuppliers();
    }
}
