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
    public partial class FormClientesCadastroEdicao : Form
    {
        public FormClientesCadastroEdicao()
        {
            InitializeComponent();

            this.Text = Properties.Resources.ResourceManager.GetString("FormClientesCadastroEdicao");
            labelClientesCadastroEditarTitulo.Text = Properties.Resources.ResourceManager.GetString("labelClientesCadastroEditarTitulo");
            labelClientesCadastroEdicaoNome.Text = Properties.Resources.ResourceManager.GetString("labelClientesCadastroEdicaoNome");
            labelClientesCadastroEdicaoCpfCnpj.Text = Properties.Resources.ResourceManager.GetString("labelClientesCadastroEdicaoCpfCnpj");
            labelClientesCadastroEdicaoRazaoSocial.Text = Properties.Resources.ResourceManager.GetString("labelClientesCadastroEdicaoRazaoSocial");
            labelClientesCadastroEdicaoDataNascimento.Text = Properties.Resources.ResourceManager.GetString("labelClientesCadastroEdicaoDataNascimento");
            

            UserControlSalvarExcluir salvarExcluirPadrao = new UserControlSalvarExcluir();
            salvarExcluirPadrao.Dock = DockStyle.Bottom;
            panelEditarExcluirPadrao.Controls.Add(salvarExcluirPadrao);

            salvarExcluirPadrao.buttonFecharUserControl.Click += ButtonFecharUserControl_Click;

        }

        private void ButtonFecharUserControl_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormClientesCadastroEdicao_Load(object sender, EventArgs e)
        {

        }
    }
}
