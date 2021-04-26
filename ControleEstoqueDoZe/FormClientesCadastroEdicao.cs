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

            maskedTextBoxEmpresaCadEditNome.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            maskedTextBoxEmpresaCadEditNome.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            textBoxClientesCadastroEdicaoNomeRazaoSocial.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxClientesCadastroEdicaoNomeRazaoSocial.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);
            
            dateTimePickerClientesCadastroEdicaoDataNascimento.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            dateTimePickerClientesCadastroEdicaoDataNascimento.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            //VERIFICA BOTÃO ENTER E PASSA PARA PROXIMO CAMPO OU FECHA FORMULÁRIO
            this.KeyDown += new KeyEventHandler(ClassHelpers.FormEventoKeyDown);

            UserControlSalvarExcluir salvarExcluirPadrao = new UserControlSalvarExcluir();
            salvarExcluirPadrao.Dock = DockStyle.Bottom;
            panelEditarExcluirPadrao.Controls.Add(salvarExcluirPadrao);

            salvarExcluirPadrao.buttonFecharUserControl.Click += ButtonFecharUserControl_Click;
            salvarExcluirPadrao.buttonSalvarUserControl.Click += ButtonSalvarUserControl_Click;

        }

        private void ButtonSalvarUserControl_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonFecharUserControl_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormClientesCadastroEdicao_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxEmpresaCadEditNome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
