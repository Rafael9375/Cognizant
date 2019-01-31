using Cognizant.Ado.Repositories;


namespace Cognizant.App
{
    public class AppCtor
    {
        public static AppPessoa AplicacaoPessoa()
        {
            return new AppPessoa(new RepositoryPessoa());
        }

        public static AppConta AplicacaoConta()
        {
            return new AppConta(new RepositoryConta());
        }

        public static AppTransacao AplicacaoTransacao()
        {
            return new AppTransacao(new RepositoryTransacao());
        }

        public static AppCompra AplicacaoCompra()
        {
            return new AppCompra(new RepositoryCompra());
        }
    }
}
