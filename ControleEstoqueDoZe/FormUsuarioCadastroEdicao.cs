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
    public partial class FormUsuarioCadastroEdicao : Form
    {
        public FormUsuarioCadastroEdicao()
        {
            InitializeComponent();

            UserControlEnderecoPadrao enderecoPadrao = new UserControlEnderecoPadrao();
            enderecoPadrao.Dock = DockStyle.Top;
            panelDadosEnderecoPadrao.Controls.Add(enderecoPadrao);

            UserControlSalvarExcluir salvarExcluirPadrao = new UserControlSalvarExcluir();
            salvarExcluirPadrao.Dock = DockStyle.Bottom;
            panelEditarExcluirPadrao.Controls.Add(salvarExcluirPadrao);


            this.Text = Properties.Resources.ResourceManager.GetString("FormUsuarioCadastroEdicao");
            labelUsuariosCadastroEdicaoTitulo.Text = Properties.Resources.ResourceManager.GetString("labelUsuariosCadastroEdicaoTitulo");
            labelUsuarioCadastroEdicaoNome.Text = Properties.Resources.ResourceManager.GetString("labelUsuarioCadastroEdicaoNome");
            labelUsuarioCadastroEdicaoCpf.Text = Properties.Resources.ResourceManager.GetString("labelUsuarioCadastroEdicaoCpf");
            groupBoxTipoEmpresaCadEditEstoque.Text = Properties.Resources.ResourceManager.GetString("groupBoxTipoEmpresaCadEditEstoque");
            radioButtonEmpresaCadEditGerente.Text = Properties.Resources.ResourceManager.GetString("radioButtonEmpresaCadEditGerente");
            radioButtonEmpresaCadEditUsuario.Text = Properties.Resources.ResourceManager.GetString("radioButtonEmpresaCadEditUsuario");
            radioButtonEmpresaCadEditEstoque.Text = Properties.Resources.ResourceManager.GetString("radioButtonEmpresaCadEditEstoque");
            radioButtonEmpresaCadEditFinanceiro.Text = Properties.Resources.ResourceManager.GetString("radioButtonEmpresaCadEditFinanceiro");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelDadosEnderecoPadrao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelEmpresaCadastroEdicaoRazaoSocial_Click(object sender, EventArgs e)
        {

        }

        private void FormUsuarioCadastroEdicao_Load(object sender, EventArgs e)
        {

        }
    }
}
