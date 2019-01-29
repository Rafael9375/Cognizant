using Cognizant.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Domain.Entities;

namespace Cognizant.App
{
    public class AppConta : IRepositoryConta
    {
        private readonly IRepositoryConta repo;
        public AppConta(IRepositoryConta _repo)
        {
            repo = _repo;
        }
        public void Add(Conta obj)
        {
            repo.Add(obj);
        }

        public IEnumerable<Conta> GetAll()
        {
            return repo.GetAll();
        }

        public Conta GetById(int id)
        {
            //repo.GetAll();
            return repo.GetById(id);
        }

        public void Remove(Conta obj)
        {
            repo.Remove(obj);
        }

        public void Update(Conta obj)
        {
            repo.Update(obj);
        }
    }
}
