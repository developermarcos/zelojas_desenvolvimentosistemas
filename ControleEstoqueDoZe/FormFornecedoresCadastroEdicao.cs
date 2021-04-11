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
    public partial class FormFornecedoresCadastroEdicao : Form
    {
        public FormFornecedoresCadastroEdicao()
        {
            InitializeComponent();

            UserControlEnderecoPadrao enderecoPadrao = new UserControlEnderecoPadrao();
            enderecoPadrao.Dock = DockStyle.Top;
            panelDadosEnderecoPadrao.Controls.Add(enderecoPadrao);


            UserControlSalvarExcluir salvarExcluirPadrao = new UserControlSalvarExcluir();
            salvarExcluirPadrao.Dock = DockStyle.Bottom;
            panelEditarExcluirPadrao.Controls.Add(salvarExcluirPadrao);

            this.Text = Properties.Resources.ResourceManager.GetString("FormFornecedoresCadastroEdicao");
            labelFornecedorCadastroEdicaoTitulo.Text = Properties.Resources.ResourceManager.GetString("labelFornecedorCadastroEdicaoTitulo");
            labelFornecedoresCadastroEdicaoRazaoSocial.Text = Properties.Resources.ResourceManager.GetString("labelFornecedoresCadastroEdicaoRazaoSocial");
            labelFornecedorCadastroEdicaoFantasia.Text = Properties.Resources.ResourceManager.GetString("labelFornecedorCadastroEdicaoFantasia");
        }

        private void FormFornecedoresCadastroEdicao_Load(object sender, EventArgs e)
        {

        }
    }
}
