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
    public partial class FormEmpresasCadastroEdicao : Form
    {
        public FormEmpresasCadastroEdicao()
        {
            InitializeComponent();

            this.Text = Properties.Resources.ResourceManager.GetString("FormClientesCadastroEdicao");
            labelEmpresaCadastroEditarTitulo.Text = Properties.Resources.ResourceManager.GetString("labelEmpresaCadastroEditarTitulo");
            labelEmpresaCadastroEdicaoRazaoSocial.Text = Properties.Resources.ResourceManager.GetString("labelEmpresaCadastroEdicaoRazaoSocial");
            labelEmpresaCadastroEdicaoCnpjCpf.Text = Properties.Resources.ResourceManager.GetString("labelEmpresaCadastroEdicaoCnpjCpf");
            groupBoxTipoEmpresaCadEditTipo.Text = Properties.Resources.ResourceManager.GetString("groupBoxTipoEmpresaCadEditTipo");
            radioButtonEmpresaCadEditMatriz.Text = Properties.Resources.ResourceManager.GetString("radioButtonEmpresaCadEditMatriz");
            radioButtonEmpresaCadEditFilial.Text = Properties.Resources.ResourceManager.GetString("radioButtonEmpresaCadEditFilial");
            labelEmpresaCadastroEdicaoFantasia.Text = Properties.Resources.ResourceManager.GetString("labelEmpresaCadastroEdicaoFantasia");
            labelEmpresaCadastroEdicaoGerente.Text = Properties.Resources.ResourceManager.GetString("labelEmpresaCadastroEdicaoGerente");


            UserControlSalvarExcluir salvarExcluirPadrao = new UserControlSalvarExcluir();
            salvarExcluirPadrao.Dock = DockStyle.Bottom;
            panelEditarExcluirPadrao.Controls.Add(salvarExcluirPadrao);

            salvarExcluirPadrao.buttonFecharUserControl.Click += ButtonFecharUserControl_Click;
        }

        private void ButtonFecharUserControl_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEmpresasCadastroEdicao_Load(object sender, EventArgs e)
        {

        }
    }
}
