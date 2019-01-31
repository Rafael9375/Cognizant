using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Domain.Entities
{
    public class Transacao
    {
        public int TransacaoId { get; set; }
        public string Tipo { get; set; }
        public string Funcao { get; set; }
        public decimal Valor { get; set; }
        [MaxLength(50)]
        public string Observacao { get; set; }
        public DateTime Agendamento { get; set; }
        public int ContaId { get; set; }
        public int ContaIdTransferencia { get; set; }
        public int CompraId { get; set; }
        public virtual Conta ContaTransferencia { get; set; }
        public virtual Conta conta { get; set; }
        public Compra Compra { get; set; }
    }
}
