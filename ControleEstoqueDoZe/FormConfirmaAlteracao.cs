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
    public partial class FormConfirmaAlteracao : Form
    {
        public FormConfirmaAlteracao()
        {
            InitializeComponent();
        }

        public FormConfirmaAlteracao(String Texto)
        {
            InitializeComponent();
            this.labelManssagemConfirmaCancela.Text = Texto;

        }

        private void FormConfirmaAlteracao_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmaAcao_Click(object sender, EventArgs e)
        {
            
        }
    }
}
