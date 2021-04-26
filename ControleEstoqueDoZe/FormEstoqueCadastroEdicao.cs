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


            //Eventos de estilo para os campos
            textBoxEstoqueCadastroEdicaoNome.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxEstoqueCadastroEdicaoNome.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            textBoxEstoqueCadastroEdicaoQuantidadeAtual.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxEstoqueCadastroEdicaoQuantidadeAtual.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            numericUpDownEstoqueCadastroEdicaoQuantidadeAlterar.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            numericUpDownEstoqueCadastroEdicaoQuantidadeAlterar.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            textBoxEstoqueCadastroEdicaoMotivo.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxEstoqueCadastroEdicaoMotivo.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            UserControlSalvarExcluir salvarExcluirPadrao = new UserControlSalvarExcluir();
            salvarExcluirPadrao.Dock = DockStyle.Bottom;
            panelEditarExcluirPadrao.Controls.Add(salvarExcluirPadrao);

            salvarExcluirPadrao.buttonFecharUserControl.Click += ButtonFecharUserControl_Click;

            //VERIFICA BOTÃO ENTER E PASSA PARA PROXIMO CAMPO OU FECHA FORMULÁRIO
            this.KeyDown += new KeyEventHandler(ClassHelpers.FormEventoKeyDown);

        }

        private void ButtonFecharUserControl_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelFornecedoresCadastroEdicaoRazaoSocial_Click(object sender, EventArgs e)
        {

        }

        private void FormEstoqueCadastroEdicao_Load(object sender, EventArgs e)
        {

        }
    }
}
