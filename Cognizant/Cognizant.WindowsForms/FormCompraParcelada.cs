using Cognizant.App;
using Cognizant.App.Services;
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
    public partial class FormCompraParcelada : Form
    {
        readonly Conta conta;
        readonly AjustarCampoMonetario ajustar;
        private Transacao transacao;
        private AppTransacao appTransacao;
        string mensagemErro = "A transação não pôde ser completada." +
                    "\nVerifique se os campos foram preenchidos corretamente";


        public FormCompraParcelada(Conta _conta)
        {
            InitializeComponent();
            conta = _conta;
            ajustar = new AjustarCampoMonetario();
            appTransacao = AppCtor.AplicacaoTransacao();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if ((qtdParcelas.Value * decimal.Parse(txtValPar.Text.ToString()) <=
                decimal.Parse(conta.CreditoDisponivel.ToString())))
            {
                try
                {
                    transacao = new Transacao()
                    {
                        Tipo = "Compra",
                        Funcao = "Crédito",
                        Valor = qtdParcelas.Value *
                    decimal.Parse(txtValPar.Text.ToString()),
                        Observacao = qtdParcelas.Value + "x" +
                    txtValPar.Text.ToString() + " " +
                    txtObsCompra.Text.ToString(),
                        Agendamento = DateTime.Now,
                        ContaId = conta.ContaId
                    };

                    appTransacao.Add(transacao);
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
