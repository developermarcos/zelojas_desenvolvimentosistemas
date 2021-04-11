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
    public partial class UserControlMenuPrincipal : UserControl
    {
        String botaoClicado;
        String telaAtual;
        FormTelasListagem formPassado;
        
        public UserControlMenuPrincipal()
        {
            InitializeComponent();
            buttonMenuEmpresa.Text = Properties.Resources.ResourceManager.GetString("buttonMenuEmpresa");
            buttonMenuProdutos.Text = Properties.Resources.ResourceManager.GetString("buttonMenuProdutos");
            buttonMenuFornecedores.Text = Properties.Resources.ResourceManager.GetString("buttonMenuFornecedores");
            buttonMenuClientes.Text = Properties.Resources.ResourceManager.GetString("buttonMenuClientes");
            buttonMenuEstoque.Text = Properties.Resources.ResourceManager.GetString("buttonMenuEstoque");
            buttonMenuImportacaoXML.Text = Properties.Resources.ResourceManager.GetString("buttonMenuImportacaoXML");
            buttonMenuVendas.Text = Properties.Resources.ResourceManager.GetString("buttonMenuVendas");
            buttonMenuUsuarios.Text = Properties.Resources.ResourceManager.GetString("buttonMenuUsuarios");
            comboBoxListBoxMenuSelecionaIdioma.Text = Properties.Resources.ResourceManager.GetString("comboBoxListBoxMenuSelecionaIdioma");
        }
        public UserControlMenuPrincipal(String tela, String botao, FormTelasListagem formAtual)
        {
            InitializeComponent();

            buttonMenuEmpresa.Text = Properties.Resources.ResourceManager.GetString("buttonMenuEmpresa");
            buttonMenuProdutos.Text = Properties.Resources.ResourceManager.GetString("buttonMenuProdutos");
            buttonMenuFornecedores.Text = Properties.Resources.ResourceManager.GetString("buttonMenuFornecedores");
            buttonMenuClientes.Text = Properties.Resources.ResourceManager.GetString("buttonMenuClientes");
            buttonMenuEstoque.Text = Properties.Resources.ResourceManager.GetString("buttonMenuEstoque");
            buttonMenuImportacaoXML.Text = Properties.Resources.ResourceManager.GetString("buttonMenuImportacaoXML");
            buttonMenuVendas.Text = Properties.Resources.ResourceManager.GetString("buttonMenuVendas");
            buttonMenuUsuarios.Text = Properties.Resources.ResourceManager.GetString("buttonMenuUsuarios");
            comboBoxListBoxMenuSelecionaIdioma.Text = Properties.Resources.ResourceManager.GetString("comboBoxListBoxMenuSelecionaIdioma");


            botaoClicado = botao;
            telaAtual = tela;
            formPassado = formAtual;
        }


        private void panelMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMenuEmpresa_Click(object sender, EventArgs e)
        {
            if (botaoClicado != "empresa")
            {
                botaoClicado = "empresa";
                formPassado.buttonListagemCadastro.Text = "Cadastrar";
                formPassado.labelTituloPaginaListagemPaginas.Text = "Empresas";
                formPassado.telaAtual = "empresa";
            }
        }

        private void buttonMenuProdutos_Click(object sender, EventArgs e)
        {
            if (botaoClicado != "produtos")
            {
                botaoClicado = "produtos";
                formPassado.buttonListagemCadastro.Text = "Cadastrar";
                formPassado.labelTituloPaginaListagemPaginas.Text = "Produtos";
                formPassado.telaAtual = "produto";

            }
        }

        private void buttonMenuFornecedores_Click(object sender, EventArgs e)
        {
            if (botaoClicado != "fornecedores")
            {
                botaoClicado = "fornecedores";
                formPassado.buttonListagemCadastro.Text = "Cadastrar";
                formPassado.labelTituloPaginaListagemPaginas.Text = "Fornecedores";
                formPassado.telaAtual = "fornecedor";

            }
        }

        private void buttonMenuClientes_Click(object sender, EventArgs e)
        {
            if (botaoClicado != "clientes")
            {
                botaoClicado = "clientes";
                formPassado.buttonListagemCadastro.Text = "Cadastrar";
                formPassado.labelTituloPaginaListagemPaginas.Text = "Clientes";
                formPassado.telaAtual = "cliente";

            }
        }

        private void buttonMenuEstoque_Click(object sender, EventArgs e)
        {
            if (botaoClicado != "estoque")
            {
                botaoClicado = "estoque";
                formPassado.buttonListagemCadastro.Text = "Cadastrar";
                formPassado.labelTituloPaginaListagemPaginas.Text = "Estoque";
                formPassado.telaAtual = "estoque";

            }
        }

        private void buttonMenuImportacaoXML_Click(object sender, EventArgs e)
        {
            if (botaoClicado != "importacao")
            {
                botaoClicado = "importacao";
                formPassado.buttonListagemCadastro.Text = "Cadastrar";
                formPassado.labelTituloPaginaListagemPaginas.Text = "Importacao XML";
                formPassado.telaAtual = "importacao";
            }
        }

        private void buttonMenuVendas_Click(object sender, EventArgs e)
        {
            if (botaoClicado != "vendas")
            {
                botaoClicado = "vendas";
                formPassado.buttonListagemCadastro.Text = "Cadastrar";
                formPassado.labelTituloPaginaListagemPaginas.Text = "Vendas";
                formPassado.telaAtual = "venda";
            }
        }

        private void buttonMenuUsuarios_Click(object sender, EventArgs e)
        {
            if (botaoClicado != "usuarios")
            {
                botaoClicado = "usuarios";
                formPassado.buttonListagemCadastro.Text = "Cadastrar";
                formPassado.labelTituloPaginaListagemPaginas.Text = "Usuarios";
                formPassado.telaAtual = "usuario";
            }
        }
    }
}
