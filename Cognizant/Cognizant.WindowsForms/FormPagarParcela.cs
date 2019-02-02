using Cognizant.App;
using Cognizant.App.Services;
using Cognizant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cognizant.WindowsForms
{
    public partial class FormPagarParcela : Form
    {
        readonly Conta conta;
        readonly AjustarCampoMonetario ajustar;
        private Transacao transacao;
        private AppTransacao appTransacao;
        private int[] _compraId;
        private int compraId;
        private AppCompra appCompra;
        private List<Compra> tr;
        private Compra compra;
        string mensagemErro = "A transação não pôde ser completada." +
                    "\nVerifique se os campos foram preenchidos corretamente";

        public FormPagarParcela(Conta _conta)
        {
            InitializeComponent();
            conta = _conta;
            ajustar = new AjustarCampoMonetario();
            appTransacao = AppCtor.AplicacaoTransacao();
            appCompra = AppCtor.AplicacaoCompra();
        }
        

        private void btnPagar_Click(object sender, EventArgs e)
        {
            var valorParcela = compra.dbValorParcela;
            var qtdPar = qtdPagarPar.Value;
            var pagamento = qtdPar * valorParcela;
            var saldo = conta.SaldoDebito;
            pagamento = decimal.Parse(pagamento.ToString());
            if (saldo >= pagamento)
            {
                try
                {
                    transacao = new Transacao()
                    {
                        ContaId = conta.ContaId,
                        Valor = pagamento,
                        Tipo = "Pagamento",
                        Funcao = "Débito",
                        Agendamento = DateTime.Now,
                        Observacao = compra.dbLoja,
                        CompraId = compraId
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

        private void FormPagarParcela_Load(object sender, EventArgs e)
        {
            try
            {
                tr = appCompra.SelecionarCompras(conta.ContaId).ToList();
                _compraId = new int[tr.Count()];
                for (int i = 0; i < tr.Count(); i++)
                {
                    _compraId[i] = int.Parse(tr[i].dbCompraId.ToString());
                    cbCompra.Items.Add(tr[i].dbLoja);
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sem contas à pagar.", "Aviso");
                this.Close();
            }
        }

        private void qtdPagarPar_ValueChanged(object sender, EventArgs e)
        {
            var totalPagar =
                decimal.Parse
                ((compra.dbValorParcela * qtdPagarPar.Value).ToString());
            lblTotalPagar.Text = totalPagar.ToString();
        }

        private void cbCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            compra = tr[cbCompra.SelectedIndex];
            var maxPars = compra.dbParcelasPendentes;
            qtdPagarPar.Maximum = maxPars;
            compraId = compra.dbCompraId;
            lblTotalPagar.Text = compra.dbValorParcela.ToString();
            qtdPagarPar.Minimum = 1;
            qtdPagarPar.Value = qtdPagarPar.Minimum;
            qtdPagarPar.Enabled = true;
            
        }
    }
}
