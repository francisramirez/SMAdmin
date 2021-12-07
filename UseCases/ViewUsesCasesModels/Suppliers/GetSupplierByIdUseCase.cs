using System;
using CoreBusiness.Entities;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;

namespace UseCases.ViewUsesCasesModels.Suppliers
{
    public class GetSupplierByIdUseCase : IGetSupplierByIdUseCase
    {
        private readonly ISupplierRepository _supplierRepository;
        public GetSupplierByIdUseCase(ISupplierRepository supplierRepository) => _supplierRepository = supplierRepository;
        public Supplier GetEntityById(int entityId) => _supplierRepository.GetById(entityId);
    }
}
