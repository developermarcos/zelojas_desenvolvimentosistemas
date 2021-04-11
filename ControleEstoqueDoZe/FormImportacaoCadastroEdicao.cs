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
    public partial class FormImportacaoCadastroEdicao : Form
    {
        public FormImportacaoCadastroEdicao()
        {
            InitializeComponent();

            this.Text = Properties.Resources.ResourceManager.GetString("FormImportacaoCadastroEdicao");
            
        }

        private void FormImportacaoCadastroEdicao_Load(object sender, EventArgs e)
        {

        }
    }
}
