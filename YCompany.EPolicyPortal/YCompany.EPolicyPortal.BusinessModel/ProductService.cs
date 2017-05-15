using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using YCompany.EPolicyPortal.DTO;
using YCompany.EPolicyPortal.PersistenceLayer.Entities;

namespace YCompany.EPolicyPortal.BusinessModel
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        //private readonly IMapper _mapper;

        public ProductService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            //var config = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<Product, InsurancePolicy>();
            //    cfg.AddProfile<FooProfile>();
            //});
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