using Cognizant.App;
using Cognizant.App.Services;
using Cognizant.Domain.Entities;
using System;
using System.Windows.Forms;

namespace Cognizant.WindowsForms
{
    public partial class FormDeposito : Form
    {
        readonly Conta conta;
        readonly AjustarCampoMonetario ajustar;
        private Transacao transacao;
        private AppTransacao appTransacao;
        string mensagemErro = "A transação não pôde ser completada." +
                    "\nVerifique se os campos foram preenchidos corretamente";


        public FormDeposito(Conta _conta)
        {
            InitializeComponent();
            conta = _conta;
            ajustar = new AjustarCampoMonetario();
            appTransacao = AppCtor.AplicacaoTransacao();
        }

        private void txtValDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDep.Text = ajustar.TxtBox(txtValDep.Text);
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
            txtValDep.SelectionStart = txtValDep.Text.Length;
        }

        private void txtValDep_MouseClick(object sender, MouseEventArgs e)
        {
            txtValDep.SelectionStart = txtValDep.Text.Length;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            var valDepositado = decimal.Parse(txtValDep.Text.ToString());
            var data = DateTime.Parse(dtDep.Value.Date.ToString("yyyy/MM/dd"));
            try
            {
                transacao = new Transacao()
                {
                    ContaId = conta.ContaId,
                    Agendamento = data,
                    Observacao = "Depósito de " + valDepositado,
                    Tipo = "Depósito",
                    Funcao = "Débito",
                    Valor = valDepositado
                };
                appTransacao.Add(transacao);
            }
            catch (Exception)
            {
                MessageBox.Show(mensagemErro, "Erro");
                throw;
            }
            this.Close();
        }

        private void FormDeposito_Load(object sender, EventArgs e)
        {

        }

        private void txtValDep_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txtValDep.Text = ajustar.TxtBox(txtValDep.Text);
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
            txtValDep.SelectionStart = txtValDep.Text.Length;
        }

        private void txtValDep_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtValDep.SelectionStart = txtValDep.Text.Length;
        }

        private void btnDepositar_Click_1(object sender, EventArgs e)
        {
            var valDepositado = decimal.Parse(txtValDep.Text.ToString());
            var data = DateTime.Parse(dtDep.Value.Date.ToString("yyyy/MM/dd"));
            try
            {
                transacao = new Transacao()
                {
                    ContaId = conta.ContaId,
                    Agendamento = data,
                    Observacao = "Depósito de " + valDepositado,
                    Tipo = "Depósito",
                    Funcao = "Débito",
                    Valor = valDepositado
                };
                appTransacao.Add(transacao);
            }
            catch (Exception)
            {
                MessageBox.Show(mensagemErro, "Erro");
                throw;
            }
            this.Close();
            
        }
    }
}
