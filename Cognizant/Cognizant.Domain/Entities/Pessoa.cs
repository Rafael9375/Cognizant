

namespace Cognizant.Domain.Entities
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public Conta ContaPessoa { get; set; }
    }
}
