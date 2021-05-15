using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueDoZe
{
    public partial class FormTelasListagem : System.Windows.Forms.Form
    {

        public String telaAtual;
        String botaoClicado;
        UserControlHeaderPrincipal headerTelasListagem;
        UserControlMenuPrincipal menuTelasListagem;
        
        public FormTelasListagem()
        {

            InitializeComponent();
            UserControlHeaderPrincipal headerPrincipal = new UserControlHeaderPrincipal(this);
            headerPrincipal.Dock = DockStyle.Top;
            panelHeaderPrincipal.Controls.Add(headerPrincipal);
            headerTelasListagem = headerPrincipal;

            UserControlMenuPrincipal menuPrincipal = new UserControlMenuPrincipal(telaAtual, botaoClicado, this);
            menuPrincipal.Dock = DockStyle.Left;
            panelMenuPrincipal.Controls.Add(menuPrincipal);
            menuTelasListagem = menuPrincipal;
            //this.labelTituloPaginaListagemPaginas.Text = " ";

            //this.buttonListagemCadastro.Close();
            headerPrincipal.buttonHeaderSairSistema.Click += ButtonHeaderSairSistema_Click;

            this.Text = Properties.Resources.ResourceManager.GetString("FormTelasListagem");
            
            //VERIFICA BOTÃO ENTER E PASSA PARA PROXIMO CAMPO OU FECHA FORMULÁRIO
            this.KeyDown += new KeyEventHandler(ClassHelpers.FormEventoKeyDown);


        }
        public FormTelasListagem(String tela, String nomeBotao, String nomeTela)
        {
            InitializeComponent();
            
            telaAtual = tela;

            UserControlHeaderPrincipal headerPrincipal = new UserControlHeaderPrincipal(this);
            headerPrincipal.Dock = DockStyle.Top;
            panelHeaderPrincipal.Controls.Add(headerPrincipal);
            headerTelasListagem = headerPrincipal;
            

            UserControlMenuPrincipal menuPrincipal = new UserControlMenuPrincipal(telaAtual, botaoClicado, this);
            menuPrincipal.Dock = DockStyle.Left;
            panelMenuPrincipal.Controls.Add(menuPrincipal);
            menuTelasListagem = menuPrincipal;

            UserControlDashboard panelDashboard = new UserControlDashboard();
            panelDashboard.Dock = DockStyle.Top;
            panelListagemConteudos.Controls.Add(panelDashboard);
            this.buttonListagemCadastro.Hide();
            this.labelTituloPaginaListagemPaginas.Text = Properties.Resources.ResourceManager.GetString("buttonDashboard");
            telaAtual = "dashboard";


            //VERIFICA BOTÃO ENTER E PASSA PARA PROXIMO CAMPO OU FECHA FORMULÁRIO
            this.KeyDown += new KeyEventHandler(ClassHelpers.FormEventoKeyDown);

            //FECHAR A TELA PRINCIPAL DO SISTEMA
            headerPrincipal.buttonHeaderSairSistema.Click += ButtonHeaderSairSistema_Click;
            headerPrincipal.buttonDashboard.Click += ButtonDashboard_Click;

            //PEGA CLIQUE DOS BOTÕES DE MENU
            menuPrincipal.buttonMenuEmpresa.Click += ButtonMenuEmpresa_Click;
            menuPrincipal.buttonMenuProdutos.Click += ButtonMenuProdutos_Click;
            menuPrincipal.buttonMenuFornecedores.Click += ButtonMenuFornecedores_Click;
            menuPrincipal.buttonMenuClientes.Click += ButtonMenuClientes_Click;
            menuPrincipal.buttonMenuEstoque.Click += ButtonMenuEstoque_Click;
            menuPrincipal.buttonMenuImportacaoXML.Click += ButtonMenuImportacaoXML_Click;
            menuPrincipal.buttonMenuVendas.Click += ButtonMenuVendas_Click;
            menuPrincipal.buttonMenuUsuarios.Click += ButtonMenuUsuarios_Click;
            menuPrincipal.buttonMenuidioma.Click += ButtonMenuidioma_Click;


            //------------------------------------------------------------------------------------------
            //CRIA OUVINTES PARA ABRIR TELA ATRAVÉS DO MENU DE CONTEXTO
            lojasToolStripMenuItem.Click += new EventHandler(ButtonMenuEmpresa_Click);
            funcionariosToolStripMenuItem.Click += new EventHandler(ButtonMenuUsuarios_Click);
            fornecedoresToolStripMenuItem.Click += new EventHandler(ButtonMenuFornecedores_Click);
            produtosToolStripMenuItem.Click += new EventHandler(ButtonMenuProdutos_Click);
            vendasToolStripMenuItem.Click += new EventHandler(ButtonMenuVendas_Click);
            configuracoesToolStripMenuItem.Click += new EventHandler(ButtonMenuidioma_Click);
            sairToolStripMenuItem.Click += new EventHandler(ButtonHeaderSairSistema_Click);

            lojasToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("buttonMenuEmpresa");
            funcionariosToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("buttonMenuUsuarios");
            fornecedoresToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("buttonMenuFornecedores");
            produtosToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("buttonMenuProdutos");
            vendasToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("buttonMenuVendas");
            configuracoesToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("buttonMenuidioma");
            sairToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("buttonHeaderSairSistema");

        }

        private void ButtonMenuidioma_Click(object sender, EventArgs e)
        {
            FormIdioma formIdioma = new FormIdioma();
            formIdioma.ShowDialog();
        }

        //--------------------- FUNÇÕES DOS BOTÕES MENUS PRINCIPAL ---------------------
        private void ButtonMenuUsuarios_Click(object sender, EventArgs e)
        {
            botaoClicado = "usuarios";
            this.buttonListagemCadastro.Text = Properties.Resources.ResourceManager.GetString("buttonListagemCadastro");
            this.labelTituloPaginaListagemPaginas.Text = Properties.Resources.ResourceManager.GetString("buttonMenuUsuarios");
            this.buttonListagemCadastro.Show();
            telaAtual = "usuario";
        }

        private void ButtonMenuVendas_Click(object sender, EventArgs e)
        {
            botaoClicado = "vendas";
            this.buttonListagemCadastro.Text = Properties.Resources.ResourceManager.GetString("buttonListagemCadastro");
            this.labelTituloPaginaListagemPaginas.Text = Properties.Resources.ResourceManager.GetString("buttonMenuVendas");
            this.buttonListagemCadastro.Show();
            telaAtual = "venda";
        }

        private void ButtonMenuImportacaoXML_Click(object sender, EventArgs e)
        {
            botaoClicado = "importacao";
            this.buttonListagemCadastro.Text = Properties.Resources.ResourceManager.GetString("buttonListagemCadastro");
            this.labelTituloPaginaListagemPaginas.Text = Properties.Resources.ResourceManager.GetString("buttonMenuImportacaoXML");
            this.buttonListagemCadastro.Show();
            telaAtual = "importacao";
        }

        private void ButtonMenuEstoque_Click(object sender, EventArgs e)
        {
            botaoClicado = "estoque";
            this.buttonListagemCadastro.Text = Properties.Resources.ResourceManager.GetString("buttonListagemCadastro");
            this.labelTituloPaginaListagemPaginas.Text = Properties.Resources.ResourceManager.GetString("buttonMenuEstoque");
            this.buttonListagemCadastro.Show();
            telaAtual = "estoque";
        }

        private void ButtonMenuClientes_Click(object sender, EventArgs e)
        {
            botaoClicado = "clientes";
            this.buttonListagemCadastro.Text = Properties.Resources.ResourceManager.GetString("buttonListagemCadastro");
            this.labelTituloPaginaListagemPaginas.Text = Properties.Resources.ResourceManager.GetString("buttonMenuClientes");
            this.buttonListagemCadastro.Show();
            telaAtual = "cliente";
        }

        private void ButtonMenuFornecedores_Click(object sender, EventArgs e)
        {
            botaoClicado = "fornecedores";
            this.buttonListagemCadastro.Text = Properties.Resources.ResourceManager.GetString("buttonListagemCadastro");
            this.labelTituloPaginaListagemPaginas.Text = Properties.Resources.ResourceManager.GetString("buttonMenuFornecedores");
            this.buttonListagemCadastro.Show();
            telaAtual = "fornecedor";
        }

        private void ButtonMenuProdutos_Click(object sender, EventArgs e)
        {
            botaoClicado = "produtos";
            this.buttonListagemCadastro.Text = Properties.Resources.ResourceManager.GetString("buttonListagemCadastro");
            this.labelTituloPaginaListagemPaginas.Text = Properties.Resources.ResourceManager.GetString("buttonMenuProdutos");
            this.buttonListagemCadastro.Show();
            telaAtual = "produto";
        }

        private void ButtonMenuEmpresa_Click(object sender, EventArgs e)
        {
            botaoClicado = "empresa";
            this.buttonListagemCadastro.Text = Properties.Resources.ResourceManager.GetString("buttonListagemCadastro");
            this.labelTituloPaginaListagemPaginas.Text = Properties.Resources.ResourceManager.GetString("buttonMenuEmpresa");
            this.buttonListagemCadastro.Show();
            telaAtual = "empresa";
        }
        //--------------------- END FUNÇÕES DOS BOTÕES MENU PRINCIPAL ---------------------

        private void ButtonDashboard_Click(object sender, EventArgs e)
        {

            UserControlDashboard panelDashboard = new UserControlDashboard();
            panelDashboard.Dock = DockStyle.Top;
            panelListagemConteudos.Controls.Add(panelDashboard);
            this.buttonListagemCadastro.Hide();
            this.labelTituloPaginaListagemPaginas.Text = Properties.Resources.ResourceManager.GetString("buttonDashboard");
            telaAtual = "dashboard";
        }



        private void ButtonHeaderSairSistema_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeaderPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTituloCadastroPaginas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormListagemEmpresas_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTituloPaginaListagemPaginas_Click(object sender, EventArgs e)
        {

        }

        private void buttonListagemCadastro_Click(object sender, EventArgs e)
        {
            switch (telaAtual)
            {
                case "empresa":
                    FormEmpresasCadastroEdicao telaCadastroEditaEmpresas = new FormEmpresasCadastroEdicao();
                    telaCadastroEditaEmpresas.ShowDialog();
                    break;
                case "produto":
                    FormProdutosCadastroEdicao telaCadastroEditaProdutos = new FormProdutosCadastroEdicao();
                    telaCadastroEditaProdutos.ShowDialog();
                    break;
                case "fornecedor":
                    FormFornecedoresCadastroEdicao telaCadastroEditaFornecedores = new FormFornecedoresCadastroEdicao();
                    telaCadastroEditaFornecedores.ShowDialog();
                    break;
                case "cliente":
                    FormClientesCadastroEdicao telaCadastroEdicaoClientes = new FormClientesCadastroEdicao();
                    telaCadastroEdicaoClientes.ShowDialog();
                    break;
                
                case "estoque":
                    FormEstoqueCadastroEdicao telaCadastroEditaEstoque = new FormEstoqueCadastroEdicao();
                    telaCadastroEditaEstoque.ShowDialog();
                    break;
                case "importacao":
                    FormImportacaoCadastroEdicao telaCadastroEditaImportacao = new FormImportacaoCadastroEdicao();
                    telaCadastroEditaImportacao.ShowDialog();
                    break;
                case "venda":
                    FormVendasCadastroEdicao telaCadastroEditaVendas = new FormVendasCadastroEdicao();
                    telaCadastroEditaVendas.ShowDialog();
                    break;
                case "usuario":
                    FormUsuarioCadastroEdicao telaCadastroEditaUsuario = new FormUsuarioCadastroEdicao();
                    telaCadastroEditaUsuario.ShowDialog();
                    break;

                default:

                    break;
            }


        }

        private void FormTelasListagem_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(Properties.Resources.ResourceManager.GetString("fraseDesejaFecharSistema"), Properties.Resources.ResourceManager.GetString("tituloDesejaFecharSistema"), MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {
                e.Cancel = true;
            }
        }


        //------------------------------------- BANDEJA ---------------------------------------------
        private void FormTelasListagem_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
                notifyIconSystemTray.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }

        private void notifyIconSystemTray_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            notifyIconSystemTray.Visible = false;
        }
    }
}
