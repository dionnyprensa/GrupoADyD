using GrupoADyD.Domain.Interfaces;
using GrupoADyD.Domain.Entities;
using GrupoADyD.Application.Interfaces;
using GrupoADyD.Application.Validators;
using System.Collections.Generic;
using FluentValidation.Results;

namespace GrupoADyD.Application.Concrete
{
    public class ClientAppService : IClientAppService
    {
        private readonly ClientValidator _validator;
        private readonly IRepository<Client> _clientRepository;
        public ClientAppService(IRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
            _validator = new ClientValidator();
        }

        public IEnumerable<Client> GetAll
        {
            get
            {
                return _clientRepository.GetAll;
            }
        }

        public Client Get(Client entity)
        {
            return _clientRepository.Get(entity);
        }

        public Client GetById(int Id)
        {
            return _clientRepository.GetById(Id);
        }

        public void Create(Client entity)
        {
            _clientRepository.Create(entity);
        }

        public void Update(Client entity)
        {
            _clientRepository.Update(entity);
        }

        public void Delete(Client entity)
        {
            _clientRepository.Delete(entity);
        }

        public void Commit()
        {
            _clientRepository.Commit();
        }

        public bool Validate(Client entity)
        {
            return false;
        }

        public bool isValid(Client entity)
        {
            return _validator.Validate(entity).IsValid;
        }

        public ICollection<ValidationFailure> Errors(Client entity)
        {
            return _validator.Validate(entity).Errors;
        }
    }
}