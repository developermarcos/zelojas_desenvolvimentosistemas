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
    public partial class FormTelasListagem : System.Windows.Forms.Form
    {

        public String telaAtual;
        String botaoClicado;
        UserControlHeaderPrincipal headerTelasListagem;
        UserControlMenuPrincipal menuTelasListagem;
        
        public FormTelasListagem()
        {

            InitializeComponent();

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

            this.Text = Properties.Resources.ResourceManager.GetString("FormTelasListagem");
            buttonListagemCadastro.Text = nomeBotao;

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
    }
}
