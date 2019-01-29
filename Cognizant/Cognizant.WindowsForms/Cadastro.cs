using Cognizant.App;
using Cognizant.App.Services;
using Cognizant.Domain.Entities;
using System;

using System.Windows.Forms;

namespace Cognizant.WindowsForms
{
    public partial class Cadastro : Form
    {
        private readonly AppConta appConta;
        private readonly AjustarCampoMonetario ajustar;
        public Cadastro()
        {
            InitializeComponent();
            appConta = AppCtor.AplicacaoConta();
            ajustar = new AjustarCampoMonetario();
        }

        

        private void txtSaldo_Enter(object sender, EventArgs e)
        {
            txtSaldo.SelectAll();
        }

        private void txtSaldo_Click(object sender, EventArgs e)
        {
            txtSaldo.SelectAll();
        }

        private void txtCredito_Enter(object sender, EventArgs e)
        {
            txtCredito.SelectAll();
        }

        private void txtCredito_Click(object sender, EventArgs e)
        {
            txtCredito.SelectAll();
        }

        private void txtCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            txtCredito.Text = ajustar.TxtBox(txtCredito.Text);
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
            txtCredito.SelectionStart = txtCredito.Text.Length;
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSaldo.Text = ajustar.TxtBox(txtSaldo.Text);
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
            txtSaldo.SelectionStart = txtSaldo.Text.Length;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = false;
            try
            {
                Conta conta = new Conta()
                {
                    ContaId = int.Parse(txtContaId.Text.ToString()),
                    SaldoDebito = decimal.Parse(txtSaldo.Text.ToString()),
                    CreditoDisponivel = decimal.Parse(txtCredito.Text.ToString())
                };
                appConta.Add(conta);
                MessageBox.Show("Conta cadastrada com sucesso!","Aviso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show
                    ("Não foi possível realizar o cadastro." +
                    "\nCertifique-se de que o ID da conta não foi utilizado." +
                    "\nCaso o erro persista, sinalize ao desenvolvedor do sistema.",
                    "Erro");
            }
            finally
            {
                this.Close();
            }
        }
    }
}
