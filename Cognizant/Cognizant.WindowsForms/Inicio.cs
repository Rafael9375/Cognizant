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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            DadosAcesso dadosForm = new DadosAcesso();
            dadosForm.ShowDialog();
        }

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastroForm = new Cadastro();
            cadastroForm.ShowDialog();
        }

        private void btnCotacao_Click(object sender, EventArgs e)
        {
            Cotacao cotacao = new Cotacao();
            cotacao.ShowDialog();
        }
    }
}
