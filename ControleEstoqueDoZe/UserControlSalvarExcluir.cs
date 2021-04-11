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
    public partial class UserControlSalvarExcluir : UserControl
    {
        //FormProdutosCadastroEdicao formProdutos;
        //FormEmpresasCadastroEdicao formEmpresas;
        //FormUsuarioCadastroEdicao formUsuarios;

        public UserControlSalvarExcluir()
        {
            InitializeComponent();
            buttonSalvarUserControl.Text = Properties.Resources.ResourceManager.GetString("buttonSalvarUserControl");
            buttonFecharUserControl.Text = Properties.Resources.ResourceManager.GetString("buttonExcluirUserControl");
        }

        
        private void UserControlSalvarExcluir_Load(object sender, EventArgs e)
        {
            
        }

        public void buttonSalvarUserControl_Click(object sender, EventArgs e)
        {

        }

        public void buttonExcluirUserControl_Click(object sender, EventArgs e)
        {
            
        }
    }
}
