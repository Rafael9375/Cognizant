
namespace Cognizant.Domain.Entities
{
    public class Compra
    {
        public int dbCompraId { get; set; }
        public string dbLoja { get; set; }
        public int dbParcelas { get; set; }
        public int dbParcelasQuitadas { get; set; }
        public decimal dbValorParcela { get; set; }
        public int dbQuitado { get; set; }
        public int dbContaId { get; set; }
        public virtual Conta dbContaCompra { get; set; }

    }
}
