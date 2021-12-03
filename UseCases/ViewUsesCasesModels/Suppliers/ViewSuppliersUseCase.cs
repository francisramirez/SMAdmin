using CoreBusiness.Entities;
using System.Collections.Generic;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;
using System.Linq;
namespace UseCases.ViewUsesCasesModels.Suppliers
{
    public class ViewSuppliersUseCase : IViewSuppliersUseCase
    {
        private readonly ISupplierRepository _supplierRepository;

        public ViewSuppliersUseCase(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        public List<Supplier> GetSuppliers()
        {
            return _supplierRepository.GetAll().ToList();
        }
    }
}
