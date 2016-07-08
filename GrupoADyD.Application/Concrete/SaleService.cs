using GrupoADyD.Domain.Interfaces;
using GrupoADyD.Domain.Entities;
using GrupoADyD.Application.Interfaces;
using GrupoADyD.Application.Validators;
using System.Collections.Generic;
using FluentValidation.Results;
using System;

namespace GrupoADyD.Application.Concrete
{
    public class SaleService : ISaleService
    {
        private readonly SaleValidator _validator;
        private readonly IRepository<Sale> _saleRepository;

        public SaleService(IRepository<Sale> saleRepository)
        {
            _saleRepository = saleRepository;
            _validator = new SaleValidator();
        }

        public IEnumerable<Sale> GetAll
        {
            get
            {
                return _saleRepository.GetAll;
            }
        }

        public Sale Get(Sale entity)
        {
            return _saleRepository.Get(entity);
        }

        public Sale GetById(int Id)
        {
            return _saleRepository.GetById(Id);
        }

        public void Create(Sale entity)
        {
            _saleRepository.Create(entity);
        }

        public void Update(Sale entity)
        {
            _saleRepository.Update(entity);
        }

        public void Delete(Sale entity)
        {
            _saleRepository.Delete(entity);
        }

        public void Commit()
        {
            _saleRepository.Commit();
        }

        public bool Validate(Sale entity)
        {
            return false;
        }

        public bool isValid(Sale entity)
        {
            return _validator.Validate(entity).IsValid;
        }

        public ICollection<ValidationFailure> Errors(Sale entity)
        {
            return _validator.Validate(entity).Errors;
        }
    }
}