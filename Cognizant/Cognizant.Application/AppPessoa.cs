
using System;
using System.Collections.Generic;
using Cognizant.Domain.Entities;
using Cognizant.Domain.Interfaces;

namespace Cognizant.App
{
    public class AppPessoa : IRepositoryPessoa
    {
        private readonly IRepositoryPessoa repo;
        public AppPessoa(IRepositoryPessoa _repo)
        {
            repo = _repo;
        }

        public void Add(Pessoa obj)
        {
            
            repo.Add(obj);
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return repo.GetAll();
        }

        public Pessoa GetById(int id)
        {
            return repo.GetById(id);
        }

        public void Remove(Pessoa obj)
        {
            repo.Remove(obj);
        }

        public void Update(Pessoa obj)
        {
            repo.Update(obj);
        }
    }
}
