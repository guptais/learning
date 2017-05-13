using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.Practices.ObjectBuilder2;
using YCompany.EPolicyPortal.DTO;
using YCompany.EPolicyPortal.PersistenceLayer.Entities;
using YCompany.EPolicyPortal.PersistenceLayer.UnitOfWork;

namespace YCompany.EPolicyPortal.BusinessModel
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public ProductService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public IEnumerable<InsurancePolicy> GetAllProducts()
        {
            using (var uow = _unitOfWorkFactory.Create())
            {   
                var products = uow.Repository<Product>().Get();
                return products.Select(product => Mapper.Map<Product, InsurancePolicy>(product)).ToList();
            }
        }

        public InsurancePolicy GetPolicy(int id)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var product = uow.Repository<Product>().GetByID(id);
                return Mapper.Map<Product, InsurancePolicy>(product);
            }
        }

        public void AddPolicy(InsurancePolicy policy)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {  
                var product = Mapper.Map<InsurancePolicy, Product>(policy);
                uow.Repository<Product>().Insert(product);
            }
        }
    }
}