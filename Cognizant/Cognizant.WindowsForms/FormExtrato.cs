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
    public partial class FormExtrato : Form
    {
        private readonly IEnumerable<Transacao> transacoes;
        private readonly AppTransacao appTransacao;
        private readonly Conta _conta;
        public FormExtrato(Conta conta)
        {
            InitializeComponent();
            appTransacao = AppCtor.AplicacaoTransacao();
            transacoes = appTransacao.BuscarExtrato(conta.ContaId);
            _conta = conta;
        }

        private void FormExtrato_Load(object sender, EventArgs e)
        {
            lblContaId.Text = _conta.ContaId.ToString();
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Dado");
            for (int i = 0; i < transacoes.Count(); i++)
            {
                tabela.Rows.Add(transacoes.ToList()[i].Observacao);
            }
            dgvExtrato.DataSource = tabela;
            dgvExtrato.Columns[0].Width = 254;
            this.AutoSize = true;
        }
    }
}
