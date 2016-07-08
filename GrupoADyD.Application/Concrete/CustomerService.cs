using GrupoADyD.Domain.Interfaces;
using GrupoADyD.Domain.Entities;
using GrupoADyD.Application.Validators;
using System.Collections.Generic;
using FluentValidation.Results;

namespace GrupoADyD.Application.Concrete
{
    public class CustomerService : Interfaces.ICustomerService
    {
        private readonly CustomerValidator _validator;
        private readonly IRepository<Customer> _clientRepository;
        public CustomerService(IRepository<Customer> clientRepository)
        {
            _clientRepository = clientRepository;
            _validator = new CustomerValidator();
        }

        public IEnumerable<Customer> GetAll
        {
            get
            {
                return _clientRepository.GetAll;
            }
        }

        public Customer Get(Customer entity)
        {
            return _clientRepository.Get(entity);
        }

        public Customer GetById(int Id)
        {
            return _clientRepository.GetById(Id);
        }

        public void Create(Customer entity)
        {
            _clientRepository.Create(entity);
        }

        public void Update(Customer entity)
        {
            _clientRepository.Update(entity);
        }

        public void Delete(Customer entity)
        {
            _clientRepository.Delete(entity);
        }

        public void Commit()
        {
            _clientRepository.Commit();
        }

        public bool Validate(Customer entity)
        {
            return false;
        }

        public bool isValid(Customer entity)
        {
            return _validator.Validate(entity).IsValid;
        }

        public ICollection<ValidationFailure> Errors(Customer entity)
        {
            return _validator.Validate(entity).Errors;
        }
    }
}