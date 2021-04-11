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

        }

        private void FormProdutosCadastroEdicao_Load(object sender, EventArgs e)
        {

        }
    }
}
