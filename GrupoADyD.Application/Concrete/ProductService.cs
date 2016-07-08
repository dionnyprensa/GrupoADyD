using GrupoADyD.Domain.Interfaces;
using GrupoADyD.Domain.Entities;
using GrupoADyD.Application.Interfaces;
using GrupoADyD.Application.Validators;
using System.Collections.Generic;
using FluentValidation.Results;
using GrupoADyD.Infrastructure.Repositories;

namespace GrupoADyD.Application.Concrete
{
    public class ProductService : IProductService
    {
        private readonly ProductValidator _validator;
        private readonly IRepository<Product> _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
            _validator = new ProductValidator();
        }

        public IEnumerable<Product> GetAll
        {
            get
            {
                return _productRepository.GetAll;
            }
        }

        public Product Get(Product entity)
        {
            return _productRepository.Get(entity);
        }

        public Product GetById(int Id)
        {
            return _productRepository.GetById(Id);
        }

        public void Create(Product entity)
        {
            _productRepository.Create(entity);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public void Commit()
        {
            _productRepository.Commit();
        }

        public bool Validate(Product entity)
        {
            return false;
        }

        public bool isValid(Product entity)
        {
            return _validator.Validate(entity).IsValid;
        }

        public ICollection<ValidationFailure> Errors(Product entity)
        {
            return _validator.Validate(entity).Errors;
        }
    }
}