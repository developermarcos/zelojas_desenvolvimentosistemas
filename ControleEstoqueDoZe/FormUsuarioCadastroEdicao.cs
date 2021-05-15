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

            //Eventos de estilo para os campos
            textBoxUsuarioCadastroEdicaoNome.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxUsuarioCadastroEdicaoNome.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            maskedTextBoxUsuarioCadastroEdicaoCpf.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            maskedTextBoxUsuarioCadastroEdicaoCpf.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            radioButtonEmpresaCadEditGerente.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            radioButtonEmpresaCadEditGerente.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            radioButtonEmpresaCadEditUsuario.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            radioButtonEmpresaCadEditUsuario.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            radioButtonEmpresaCadEditEstoque.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            radioButtonEmpresaCadEditEstoque.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            radioButtonEmpresaCadEditFinanceiro.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            radioButtonEmpresaCadEditFinanceiro.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            //VERIFICA BOTÃO ENTER E PASSA PARA PROXIMO CAMPO OU FECHA FORMULÁRIO
            this.KeyDown += new KeyEventHandler(ClassHelpers.FormEventoKeyDown);

            salvarExcluirPadrao.buttonSalvarUserControl.Click += ButtonSalvarUserControl_Click;
            salvarExcluirPadrao.buttonFecharUserControl.Click += ButtonFecharUserControl_Click;


            //Mascaras formatação
            maskedTextBoxUsuarioCadastroEdicaoCpf.Mask = Properties.Resources.ResourceManager.GetString("maskCpf");
        }

        private void ButtonSalvarUserControl_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(Properties.Resources.ResourceManager.GetString("salvarMensagemConfirmar"), Properties.Resources.ResourceManager.GetString("tituloDesejaFecharSistema"), MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ButtonFecharUserControl_Click(object sender, EventArgs e)
        {
            Close();
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
