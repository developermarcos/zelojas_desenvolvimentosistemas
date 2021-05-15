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
            buttonMenuidioma.Text = Properties.Resources.ResourceManager.GetString("buttonMenuidioma");


            botaoClicado = botao;
            telaAtual = tela;
            formPassado = formAtual;
        }


        private void panelMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMenuEmpresa_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMenuProdutos_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMenuFornecedores_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMenuClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMenuEstoque_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonMenuImportacaoXML_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMenuVendas_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMenuUsuarios_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxListBoxMenuSelecionaIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonMenuidioma_Click(object sender, EventArgs e)
        {
            FormIdioma formIdioma = new FormIdioma();
            formIdioma.ShowDialog();
        }
    }
}
