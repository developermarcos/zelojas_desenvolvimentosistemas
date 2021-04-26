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
    public partial class FormVendasCadastroEdicao : Form
    {
        public FormVendasCadastroEdicao()
        {
            InitializeComponent();

            UserControlSalvarExcluir salvarExcluirPadrao = new UserControlSalvarExcluir();
            salvarExcluirPadrao.Dock = DockStyle.Bottom;
            panelEditarExcluirPadrao.Controls.Add(salvarExcluirPadrao);
            salvarExcluirPadrao.buttonFecharUserControl.Click += ButtonFecharUserControl_Click;


            //VERIFICA BOTÃO ENTER E PASSA PARA PROXIMO CAMPO OU FECHA FORMULÁRIO
            this.KeyDown += new KeyEventHandler(ClassHelpers.FormEventoKeyDown);
        }

        private void ButtonFecharUserControl_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormVendasCadastroEdicao_Load(object sender, EventArgs e)
        {

        }
    }
}
