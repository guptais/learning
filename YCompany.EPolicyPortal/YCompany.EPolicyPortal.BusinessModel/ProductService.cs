using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using YCompany.EPolicyPortal.DataModel;
using YCompany.EPolicyPortal.PersistenceLayer.Entities;

namespace YCompany.EPolicyPortal.BusinessModel
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public ProductService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<LifeInsurancePolicy, InsurancePolicyModel>();
            });
        }

        public IEnumerable<InsurancePolicyModel> ViewAllPolicies()
        {
            using (var uow = _unitOfWorkFactory.Create())
            {   
                var products = uow.Repository<LifeInsurancePolicy>().Get();
                return products.Select(product => Mapper.Map<LifeInsurancePolicy, InsurancePolicyModel>(product)).ToList();
            }
        }

        public InsurancePolicyModel GetPolicy(int id)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var product = uow.Repository<LifeInsurancePolicy>().GetByID(id);
                return Mapper.Map<LifeInsurancePolicy, InsurancePolicyModel>(product);
            }
        }

        public void InsertPolicy(InsurancePolicyModel policyModel)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {  
                var product = Mapper.Map<InsurancePolicyModel, LifeInsurancePolicy>(policyModel);
                uow.Repository<LifeInsurancePolicy>().Insert(product);
            }
        }

        public void UpdatePolicy(int id)
        {
            
        }

        public void DeletePolicy(int id)
        {
            
        }
    }
}