using Cognizant.App;
using Cognizant.App.Services;
using Cognizant.Domain.Entities;
using System;
using System.Windows.Forms;

namespace Cognizant.WindowsForms
{
    public partial class FormCompraParcelada : Form
    {
        readonly Conta conta;
        readonly AjustarCampoMonetario ajustar;
        private Transacao transacao;
        private Compra compra;
        private AppCompra appCompra;
        string mensagemErro = "A transação não pôde ser completada." +
                    "\nVerifique se os campos foram preenchidos corretamente";


        public FormCompraParcelada(Conta _conta)
        {
            InitializeComponent();
            conta = _conta;
            ajustar = new AjustarCampoMonetario();
            appCompra = AppCtor.AplicacaoCompra();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if ((qtdParcelas.Value * decimal.Parse(txtValPar.Text.ToString()) <=
                decimal.Parse(conta.CreditoDisponivel.ToString()))&&
                decimal.Parse(txtValPar.Text) > 0)
            {
                try
                {
                    compra = new Compra()
                    {
                        dbContaId = conta.ContaId,
                        dbLoja = txtObsCompra.Text,
                        dbParcelas = int.Parse(qtdParcelas.Value.ToString()),
                        dbValorParcela = decimal.Parse(txtValPar.Text),
                        dbParcelasQuitadas = 0
                    };
                    appCompra.Add(compra);
                }
                catch (Exception)
                {
                    MessageBox.Show(mensagemErro, "Erro");
                }

            }
            else
            {
                MessageBox.Show(mensagemErro, "Erro");
            }
            this.Close();
        }

        private void txtValPar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValPar.Text = ajustar.TxtBox(txtValPar.Text);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            txtValPar.SelectionStart = txtValPar.Text.Length;
        }
    }
}
