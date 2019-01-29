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
    public partial class Acesso : Form
    {
        readonly Conta conta;
        
        public Acesso(Conta _conta)
        {
            InitializeComponent();
            conta = _conta;
        }

        private void Acesso_Load(object sender, EventArgs e)
        {
            lblContaId.Text = conta.ContaId.ToString();
            lblSaldo.Text = conta.SaldoDebito.ToString();
            lblCredito.Text = conta.CreditoDisponivel.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            if (cmbTipoTrans.Text == "Pagar parcelas")
            {
                this.Close();
                FormPagarParcela pagar = new FormPagarParcela(conta);
                pagar.Show();
            }

            if (cmbTipoTrans.Text == "Depósito")
            {
                this.Close();
                FormDeposito dep = new FormDeposito(conta);
                dep.ShowDialog();
            }

            if (cmbTipoTrans.Text == "Transferência")
            {
                this.Close();
                FormTransferencia tranf = new FormTransferencia(conta);
                tranf.ShowDialog();
            }

            if (cmbTipoTrans.Text == "Parcelamento")
            {
                this.Close();
                FormCompraParcelada parcelamento = 
                    new FormCompraParcelada(conta);
                parcelamento.Show();
            }

        }

        
        
        private void cmbTipoTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
