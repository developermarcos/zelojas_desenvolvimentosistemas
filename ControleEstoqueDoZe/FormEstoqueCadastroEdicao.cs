using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueDoZe
{
    public partial class FormEstoqueCadastroEdicao : Form
    {
        public FormEstoqueCadastroEdicao()
        {
            InitializeComponent();

            this.Text = Properties.Resources.ResourceManager.GetString("FormEstoqueCadastroEdicao");
            labelEstoqueCadastroEditarTitulo.Text = Properties.Resources.ResourceManager.GetString("labelEstoqueCadastroEditarTitulo");
            labelEstoqueCadastroEdicaoNome.Text = Properties.Resources.ResourceManager.GetString("labelEstoqueCadastroEdicaoNome");
            labelEstoqueCadastroEdicaoQuantidadeAtual.Text = Properties.Resources.ResourceManager.GetString("labelEstoqueCadastroEdicaoQuantidadeAtual");
            labelEstoqueCadastroEdicaoQuantidadeParaAlterar.Text = Properties.Resources.ResourceManager.GetString("labelEstoqueCadastroEdicaoQuantidadeParaAlterar");
            labelEstoqueCadastroEdicaoMotivo.Text = Properties.Resources.ResourceManager.GetString("labelEstoqueCadastroEdicaoMotivo");
            buttonSalvarEstoqueCadastroEdicaoAdicionar.Text = Properties.Resources.ResourceManager.GetString("buttonSalvarEstoqueCadastroEdicaoAdicionar");
            buttonEstoqueCadastroEdicaoRemover.Text = Properties.Resources.ResourceManager.GetString("buttonEstoqueCadastroEdicaoRemover");
            
            UserControlSalvarExcluir salvarExcluirPadrao = new UserControlSalvarExcluir();
            salvarExcluirPadrao.Dock = DockStyle.Bottom;
            panelEditarExcluirPadrao.Controls.Add(salvarExcluirPadrao);
        }

        private void labelFornecedoresCadastroEdicaoRazaoSocial_Click(object sender, EventArgs e)
        {

        }

        private void FormEstoqueCadastroEdicao_Load(object sender, EventArgs e)
        {

        }
    }
}
