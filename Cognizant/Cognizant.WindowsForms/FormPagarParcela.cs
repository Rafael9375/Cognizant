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
    public partial class FormPagarParcela : Form
    {
        readonly Conta conta;
        readonly AjustarCampoMonetario ajustar;
        private Transacao transacao;
        private AppTransacao appTransacao;
        private int[] _compraId;
        private int compraId;
        private AppCompra appCompra;
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
            String[] aux = cbCompra.Text.Split(' ');
            var loja = "";
            for (int i = 1; i < aux.Count(); i++)
            {
                loja += aux[i] + " ";
            }
            aux = aux[0].Split('x');
            aux[1] = aux[1].Replace('.', ',');
            var valorParcela = decimal.Parse(aux[1].ToString());
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
                        Observacao =
                        qtdPar.ToString() + "x" +
                        valorParcela.ToString() + " " +
                        loja.ToString(),
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
                List<Transacao> tr = appTransacao.SelecionarCompras(conta.ContaId).ToList();
                _compraId = new int[tr.Count()];
                for (int i = 0; i < tr.Count(); i++)
                {
                    _compraId[i] = int.Parse(tr[i].CompraId.ToString());
                    cbCompra.Items.Add(tr[i].Observacao);
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
            String[] aux = cbCompra.Text.Split(' ');
            aux = aux[0].Split('x');
            aux[1] = aux[1].Replace('.', ',');
            var maxPars = int.Parse(aux[0]);
            var valorParcela = decimal.Parse(aux[1].ToString());
            var qtdPar = qtdPagarPar.Value;
            var pagamento = qtdPar * valorParcela;
            lblTotalPagar.Text = pagamento.ToString();
            qtdPagarPar.Maximum = maxPars;

        }

        private void cbCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] aux = cbCompra.Text.Split(' ');
            aux = aux[0].Split('x');
            aux[1] = aux[1].Replace('.', ',');
            var maxPars = int.Parse(aux[0]);
            var valorParcela = decimal.Parse(aux[1].ToString());
            var qtdPar = qtdPagarPar.Value;
            var pagamento = qtdPar * valorParcela;
            lblTotalPagar.Text = pagamento.ToString();
            qtdPagarPar.Maximum = maxPars;
            qtdPagarPar.Enabled = true;
            compraId = _compraId[cbCompra.SelectedIndex];
            
        }
    }
}
