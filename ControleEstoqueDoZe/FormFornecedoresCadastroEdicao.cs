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

            salvarExcluirPadrao.buttonFecharUserControl.Click += ButtonFecharUserControl_Click;

            this.Text = Properties.Resources.ResourceManager.GetString("FormFornecedoresCadastroEdicao");
            labelFornecedorCadastroEdicaoTitulo.Text = Properties.Resources.ResourceManager.GetString("labelFornecedorCadastroEdicaoTitulo");
            labelFornecedoresCadastroEdicaoRazaoSocial.Text = Properties.Resources.ResourceManager.GetString("labelFornecedoresCadastroEdicaoRazaoSocial");
            labelFornecedorCadastroEdicaoFantasia.Text = Properties.Resources.ResourceManager.GetString("labelFornecedorCadastroEdicaoFantasia");

            //Eventos de estilo para os campos
            textBoxFornecedoresCadastroEdicaoRazaoSocial.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxFornecedoresCadastroEdicaoRazaoSocial.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            maskedTextBoxFornecedorCadEditNome.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            maskedTextBoxFornecedorCadEditNome.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            textBoxFornecedorCadastroEdicaoFantasia.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxFornecedorCadastroEdicaoFantasia.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            //VERIFICA BOTÃO ENTER E PASSA PARA PROXIMO CAMPO OU FECHA FORMULÁRIO
            this.KeyDown += new KeyEventHandler(ClassHelpers.FormEventoKeyDown);

            salvarExcluirPadrao.buttonSalvarUserControl.Click += ButtonSalvarUserControl_Click;
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

        private void FormFornecedoresCadastroEdicao_Load(object sender, EventArgs e)
        {

        }
    }
}
