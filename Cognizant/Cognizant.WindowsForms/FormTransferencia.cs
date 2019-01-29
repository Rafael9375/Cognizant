using Cognizant.App;
using Cognizant.App.Services;
using Cognizant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cognizant.WindowsForms
{
    public partial class FormTransferencia : Form
    {
        readonly Conta conta;
        readonly AjustarCampoMonetario ajustar;
        private Transacao transacao;
        private AppTransacao appTransacao;
        string mensagemErro = "A transação não pôde ser completada." +
                    "\nVerifique se os campos foram preenchidos corretamente";


        public FormTransferencia(Conta _conta)
        {
            InitializeComponent();
            conta = _conta;
            ajustar = new AjustarCampoMonetario();
            appTransacao = AppCtor.AplicacaoTransacao();
        }
        #region Transferencia
        private void txtValTrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValTrans.Text = ajustar.TxtBox(txtValTrans.Text);
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
            txtValTrans.SelectionStart = txtValTrans.Text.Length;
        }

        private void txtValTrans_MouseClick(object sender, MouseEventArgs e)
        {
            txtValTrans.SelectionStart = txtValTrans.Text.Length;
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(conta.SaldoDebito.ToString()) >=
                decimal.Parse(txtValTrans.Text.ToString()) &&
                txtContaTrans.Text != "")
            {
                var aux = dtTrans.Value.Date.ToString("yyyy/MM/dd");
                transacao = new Transacao()
                {
                    Tipo = "Transferência",
                    Funcao = "Débito",
                    Valor = decimal.Parse(txtValTrans.Text.ToString()),
                    Observacao = txtObsTrans.Text.ToString(),
                    Agendamento = DateTime.ParseExact
                        (aux, "yyyy/MM/dd", CultureInfo.InvariantCulture),
                    ContaId = conta.ContaId,
                    ContaIdTransferencia = int.Parse(txtContaTrans.Text.ToString())
                };
                try
                {
                    appTransacao.Add(transacao);
                }
                catch (Exception)
                {
                    MessageBox.Show(mensagemErro, "Erro");
                    throw;
                }
            }
            else
            {
                MessageBox.Show(mensagemErro, "Erro");

            }
            this.Close();

        }
        #endregion
        
    }
}
