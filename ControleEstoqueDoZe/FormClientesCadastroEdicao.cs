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

            //Eventos de estilo para os campos
            textBoxClientesCadastroEdicaoNome.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxClientesCadastroEdicaoNome.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            maskedTextBoxEmpresaCadEditCpfCnpj.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            maskedTextBoxEmpresaCadEditCpfCnpj.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            textBoxClientesCadastroEdicaoNomeRazaoSocial.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxClientesCadastroEdicaoNomeRazaoSocial.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            maskedTextBoxEmpresaCadEditCpfCnpj.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            maskedTextBoxEmpresaCadEditCpfCnpj.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            //VERIFICA BOTÃO ENTER E PASSA PARA PROXIMO CAMPO OU FECHA FORMULÁRIO
            this.KeyDown += new KeyEventHandler(ClassHelpers.FormEventoKeyDown);

            UserControlSalvarExcluir salvarExcluirPadrao = new UserControlSalvarExcluir();
            salvarExcluirPadrao.Dock = DockStyle.Bottom;
            panelEditarExcluirPadrao.Controls.Add(salvarExcluirPadrao);

            salvarExcluirPadrao.buttonFecharUserControl.Click += ButtonFecharUserControl_Click;
            salvarExcluirPadrao.buttonSalvarUserControl.Click += ButtonSalvarUserControl_Click;


            //MASCARAS DE CAMPOS
            maskedTextBoxEmpresaCadEditCpfCnpj.Mask = Properties.Resources.ResourceManager.GetString("maskCnpj");
            maskedTextBoxClientesCadastroEdicaoDataNascimento.Mask = Properties.Resources.ResourceManager.GetString("maskDiaMesAno");
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

        
    }
}
