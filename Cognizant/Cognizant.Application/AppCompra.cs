using Cognizant.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Domain.Entities;

namespace Cognizant.App
{
    public class AppCompra : IRepositoryCompra
    {
        private IRepositoryCompra repo;
        public AppCompra(IRepositoryCompra _repo)
        {
            repo = _repo;
        }
        public void Add(Compra obj)
        {
            repo.Add(obj);
        }

        public IEnumerable<Compra> GetAll()
        {
            return repo.GetAll();
        }

        public Compra GetById(int id)
        {
            return repo.GetById(id);
        }

        public void Remove(Compra obj)
        {
            repo.Remove(obj);
        }

        public void Update(Compra obj)
        {
            repo.Update(obj);
        }
    }
}
