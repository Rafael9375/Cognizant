using Cognizant.App;
using Cognizant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cognizant.WindowsForms
{
    public partial class DadosAcesso : Form
    {
        private readonly AppConta appConta;

        public DadosAcesso()
        {
            InitializeComponent();
            appConta = AppCtor.AplicacaoConta();
        }

        

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            btnAcessar.Enabled = false;
            try
            {
                Conta conta;
                conta = appConta.GetById(int.Parse(txtContaId.Text.ToString()));
                Acesso acesso = new Acesso(conta);
                acesso.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("A conta de entrada " + 
                    "não foi localizada na base de dados",
                    "Erro!");

            }
            finally
            {
                btnAcessar.Enabled = true;
            }

        }
    }
}
