using Cognizant.App.Services;
using System;

using System.Windows.Forms;

namespace Cognizant.WindowsForms
{
    public partial class Cotacao : Form
    {
        private decimal real;
        private decimal dolar;
        private decimal conversao;
        private ResgataCotacao cotacao;
        private readonly AjustarCampoMonetario ajustar;
        public Cotacao()
        {
            InitializeComponent();
            cotacao = new ResgataCotacao();
            ajustar = new AjustarCampoMonetario();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Cotacao_Load(object sender, EventArgs e)
        {
            lblAtual.Text = DateTime.Now.ToString();
            lblCotacao.Text = cotacao.Retorno().ToString();
            dolar = decimal.Parse(lblCotacao.Text.Substring(0, 4));
            txtReal.Text = dolar.ToString();
            txtDolar.Text = "1,00";
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            lblAtual.Text = DateTime.Now.ToString();
            lblCotacao.Text = cotacao.Retorno().ToString();
            dolar = decimal.Parse(lblCotacao.Text.Substring(0, 4));
        }

        private void txtReal_KeyUp(object sender, KeyEventArgs e)
        {
            real = decimal.Parse(txtReal.Text);
            dolar = decimal.Parse(lblCotacao.Text);
            if (txtReal.Text != "0,00" && txtReal.Text.Substring(0) != ",")
            {
                conversao = real / dolar;
                txtDolar.Text = conversao.ToString("n2");
                txtReal.SelectionStart = txtReal.Text.Length;
            }
            txtReal.Text = real.ToString("n2");
        }

        private void txtReal_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtReal.Text = ajustar.TxtBox(txtReal.Text);
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
            txtReal.SelectionStart = txtReal.Text.Length;
        }

        private void txtReal_Click(object sender, EventArgs e)
        {
            txtReal.Text = "0,00";
            txtDolar.Text = "0,00";
            txtReal.SelectionStart = txtReal.Text.Length;
        }

        private void txtDolar_KeyUp(object sender, KeyEventArgs e)
        {
            real = decimal.Parse(lblCotacao.Text);
            dolar = decimal.Parse(txtDolar.Text);
            conversao = dolar * real;
            txtReal.Text = conversao.ToString("n2");
            txtDolar.SelectionStart = txtReal.Text.Length;
            txtDolar.Text = dolar.ToString("n2");
        }

        private void txtDolar_Click(object sender, EventArgs e)
        {
            txtReal.Text = "0,00";
            txtDolar.Text = "0,00";
            txtDolar.SelectionStart = txtReal.Text.Length;
        }

        private void txtDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDolar.Text = ajustar.TxtBox(txtDolar.Text);
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
            txtDolar.SelectionStart = txtDolar.Text.Length;
        }

        private void txtReal_Enter(object sender, EventArgs e)
        {
            txtReal.Text = "0,00";
            txtDolar.Text = "0,00";
        }

        private void txtDolar_Enter(object sender, EventArgs e)
        {
            txtReal.Text = "0,00";
            txtDolar.Text = "0,00";
        }
    }
}
