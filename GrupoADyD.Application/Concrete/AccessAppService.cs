using GrupoADyD.Domain.Interfaces;
using GrupoADyD.Domain.Entities;
using GrupoADyD.Application.Interfaces;
using GrupoADyD.Application.Validators;
using System.Collections.Generic;
using FluentValidation.Results;
using System;

namespace GrupoADyD.Application.Concrete
{
    public class AccessAppService : IAccessAppService
    {
        private readonly AccessValidator _validator;
        private readonly IRepository<Access> _accessRepository;

        public AccessAppService(IRepository<Access> accessRepository)
        {
            _accessRepository = accessRepository;
            _validator = new AccessValidator();
        }

        public IEnumerable<Access> GetAll
        {
            get
            {
                return _accessRepository.GetAll;
            }
        }

        public Access Get(Access entity)
        {
            return _accessRepository.Get(entity);
        }

        public Access GetById(int Id)
        {
            return _accessRepository.GetById(Id);
        }

        public void Create(Access entity)
        {
            _accessRepository.Create(entity);
        }

        public void Update(Access entity)
        {
            _accessRepository.Update(entity);
        }

        public void Delete(Access entity)
        {
            _accessRepository.Delete(entity);
        }

        public void Commit()
        {
            _accessRepository.Commit();
        }

        public bool Validate(Access entity)
        {
            var validator = new AccessValidator();

            return false;
        }

        public bool isValid(Access entity)
        {
            return _validator.Validate(entity).IsValid;
        }

        public ICollection<ValidationFailure> Errors(Access entity)
        {
            return _validator.Validate(entity).Errors;
        }
    }
}