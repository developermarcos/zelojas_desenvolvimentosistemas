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


            //Eventos de estilo para os campos
            textBoxEmpresaCadastroEdicaoRazaoSocial.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxEmpresaCadastroEdicaoRazaoSocial.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            maskedTextBoxEmpresaCadEditNome.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            maskedTextBoxEmpresaCadEditNome.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            radioButtonEmpresaCadEditMatriz.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            radioButtonEmpresaCadEditMatriz.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            radioButtonEmpresaCadEditFilial.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            radioButtonEmpresaCadEditFilial.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            textBoxEmpresaCadastroEdicaoFantasia.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxEmpresaCadastroEdicaoFantasia.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            comboBoxEmpresaCadastroEdicaoGerente.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            comboBoxEmpresaCadastroEdicaoGerente.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            UserControlEnderecoPadrao enderecoPadrao = new UserControlEnderecoPadrao();
            enderecoPadrao.Dock = DockStyle.Top;
            panelDadosEnderecoPadrao.Controls.Add(enderecoPadrao);

            UserControlSalvarExcluir salvarExcluirPadrao = new UserControlSalvarExcluir();
            salvarExcluirPadrao.Dock = DockStyle.Bottom;
            panelEditarExcluirPadrao.Controls.Add(salvarExcluirPadrao);

            salvarExcluirPadrao.buttonFecharUserControl.Click += ButtonFecharUserControl_Click;
            salvarExcluirPadrao.buttonSalvarUserControl.Click += ButtonSalvarUserControl_Click;

            //VERIFICA BOTÃO ENTER E PASSA PARA PROXIMO CAMPO OU FECHA FORMULÁRIO
            this.KeyDown += new KeyEventHandler(ClassHelpers.FormEventoKeyDown);
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

        private void FormEmpresasCadastroEdicao_Load(object sender, EventArgs e)
        {

        }
    }
}
