using Cognizant.Domain.Entities;
using System.Collections.Generic;

namespace Cognizant.Domain.Interfaces
{
    public interface IRepositoryTransacao : IRepositoryBase<Transacao>
    {
        IEnumerable<Transacao> BuscarExtrato(int id);
    }
}
