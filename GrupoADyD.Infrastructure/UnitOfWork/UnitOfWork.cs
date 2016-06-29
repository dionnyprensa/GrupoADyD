﻿using GrupoADyD.Infrastructure.Repositories;

namespace GrupoADyD.Infrastructure.UnitOfWork
{
    public class UnitOfWork
    {
        private AccessRepository _accessRepository;
        private ClientRepository _clientRepository;
        private ProductRepository _productRepository;
        private SaleRepository _saleRepository;

        private ApplicationDbContext _db;

        public UnitOfWork()
        {
            _db = new ApplicationDbContext();
        }

        public AccessRepository AccessRepository
        {
            get
            {
                if (_accessRepository == null)
                {
                    _accessRepository = new AccessRepository(_db);
                }
                return _accessRepository;
            }
        }

        public ClientRepository ClientRepository
        {
            get
            {
                if (_clientRepository == null)
                {
                    _clientRepository = new ClientRepository(_db);
                }
                return _clientRepository;
            }
        }

        public ProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_db);
                }
                return _productRepository;
            }
        }

        //public RolRepository RolRepository
        //{
        //    get
        //    {
        //        if (_rolRepository == null)
        //        {
        //            _rolRepository = new RolRepository(_db);
        //        }
        //        return _rolRepository;
        //    }
        //}

        public SaleRepository SaleRepository
        {
            get
            {
                if (_saleRepository == null)
                {
                    _saleRepository = new SaleRepository(_db);
                }
                return _saleRepository;
            }
        }
    }
}