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
    public partial class UserControlEnderecoPadrao : UserControl
    {
        public UserControlEnderecoPadrao()
        {
            InitializeComponent();
            labelEnderecoPadraoCep.Text = Properties.Resources.ResourceManager.GetString("labelEnderecoPadraoCep");
            labelEnderecoPadraoRua.Text = Properties.Resources.ResourceManager.GetString("labelEnderecoPadraoRua");
            labelEnderecoPadraoBairro.Text = Properties.Resources.ResourceManager.GetString("labelEnderecoPadraoBairro");
            labelEnderecoPadraoNumero.Text = Properties.Resources.ResourceManager.GetString("labelEnderecoPadraoNumero");
            labelEnderecoPadraoCidade.Text = Properties.Resources.ResourceManager.GetString("labelEnderecoPadraoCidade");
            labelEnderecoPadraoUf.Text = Properties.Resources.ResourceManager.GetString("labelEnderecoPadraoUf");
            labelEnderecoPadraoEmail.Text = Properties.Resources.ResourceManager.GetString("labelEnderecoPadraoEmail");
            labelEnderecoPadraoTelefone.Text = Properties.Resources.ResourceManager.GetString("labelEnderecoPadraoTelefone");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlEnderecoPadrao_Load(object sender, EventArgs e)
        {

        }
    }
}
