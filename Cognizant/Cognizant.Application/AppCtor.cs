using Cognizant.Ado.Repositories;
using Cognizant.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
