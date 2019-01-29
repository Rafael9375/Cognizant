using Cognizant.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Domain.Entities;

namespace Cognizant.App
{
    public class AppTransacao : IRepositoryTransacao
    {
        private readonly IRepositoryTransacao repo;
        public AppTransacao(IRepositoryTransacao _repo)
        {
            repo = _repo;
        }
        public void Add(Transacao obj)
        {
            repo.Add(obj);
        }

        public IEnumerable<Transacao> GetAll()
        {
            return repo.GetAll();
        }

        public Transacao GetById(int id)
        {
            return repo.GetById(id);
        }

        public void Remove(Transacao obj)
        {
            repo.Remove(obj);
        }

        public IEnumerable<Transacao> SelecionarCompras(int id)
        {
            return repo.SelecionarCompras(id);
        }

        public void Update(Transacao obj)
        {
            repo.Update(obj);
        }
    }
}
