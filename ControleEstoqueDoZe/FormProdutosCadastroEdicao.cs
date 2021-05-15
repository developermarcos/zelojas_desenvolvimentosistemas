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
    public partial class FormProdutosCadastroEdicao : Form
    {
        public FormProdutosCadastroEdicao()
        {
            InitializeComponent();
            this.Text = Properties.Resources.ResourceManager.GetString("FormProdutosCadastroEdicao");
            labelProdutosCadastroTituloPagina.Text = Properties.Resources.ResourceManager.GetString("labelProdutosCadastroTituloPagina");
            labelProdutosCadastroEdicaoNome.Text = Properties.Resources.ResourceManager.GetString("labelProdutosCadastroEdicaoNome");
            labelProdutosCadastroEdicaoDescricao.Text = Properties.Resources.ResourceManager.GetString("labelProdutosCadastroEdicaoDescricao");
            groupBoxProdutosCadastroEdicaoStatus.Text = Properties.Resources.ResourceManager.GetString("groupBoxProdutosCadastroEdicaoStatus");
            checkBoxProdutosCadastroEdicaoAtivo.Text = Properties.Resources.ResourceManager.GetString("checkBoxProdutosCadastroEdicaoAtivo");
            checkBoxProdutosCadastroEdicaoInativo.Text = Properties.Resources.ResourceManager.GetString("checkBoxProdutosCadastroEdicaoInativo");


            UserControlSalvarExcluir salvarExcluirPadrao = new UserControlSalvarExcluir();
            salvarExcluirPadrao.Dock = DockStyle.Bottom;
            panelEditarExcluirPadrao.Controls.Add(salvarExcluirPadrao);
            


            //Eventos de estilo para os campos
            textBoxProdutosCadastroEdicaoNome.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxProdutosCadastroEdicaoNome.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            textBoxProdutosCadastroEdicaoDescricao.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxProdutosCadastroEdicaoDescricao.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            checkBoxProdutosCadastroEdicaoAtivo.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            checkBoxProdutosCadastroEdicaoAtivo.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            checkBoxProdutosCadastroEdicaoInativo.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            checkBoxProdutosCadastroEdicaoInativo.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            //VERIFICA BOTÃO ENTER E PASSA PARA PROXIMO CAMPO OU FECHA FORMULÁRIO
            this.KeyDown += new KeyEventHandler(ClassHelpers.FormEventoKeyDown);


            salvarExcluirPadrao.buttonSalvarUserControl.Click += ButtonSalvarUserControl_Click;
            salvarExcluirPadrao.buttonFecharUserControl.Click += ButtonFecharUserControl_Click;
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

        private void FormProdutosCadastroEdicao_Load(object sender, EventArgs e)
        {

        }
    }
}
