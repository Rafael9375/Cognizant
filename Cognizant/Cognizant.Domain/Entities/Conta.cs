using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Domain.Entities
{
    public class Conta
    {
        public int ContaId { get; set; }
        public decimal SaldoDebito { get; set; }
        public decimal CreditoDisponivel { get; set; }
        public virtual IEnumerable<Transacao> Transacoes { get; set; }
    }
}
