using Cognizant.Domain.Entities;
using System.Collections.Generic;

namespace Cognizant.Domain.Interfaces
{
    public interface IRepositoryCompra : IRepositoryBase<Compra>
    {
        IEnumerable<Compra> SelecionarCompras(int id);
    }
}
