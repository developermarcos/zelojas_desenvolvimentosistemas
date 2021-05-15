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


            //Eventos de estilo para os campos
            maskedTextBoxEnderecoPadraoCep.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            maskedTextBoxEnderecoPadraoCep.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            textBoxEnderecoPadraoRua.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxEnderecoPadraoRua.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            textBoxEnderecoPadraoBairro.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxEnderecoPadraoBairro.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            textBoxEnderecoPadraoNumero.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxEnderecoPadraoNumero.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            textBoxEnderecoPadraoCidade.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            textBoxEnderecoPadraoCidade.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            comboBoxEnderecoPadraoUf.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            comboBoxEnderecoPadraoUf.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            maskedTextBoxEnderecoPadraoEmail.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            maskedTextBoxEnderecoPadraoEmail.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            maskedTextBoxEnderecoPadraoTelefone.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            maskedTextBoxEnderecoPadraoTelefone.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            //VERIFICA BOTÃO ENTER E PASSA PARA PROXIMO CAMPO OU FECHA FORMULÁRIO
            this.KeyDown += new KeyEventHandler(ClassHelpers.FormEventoKeyDown);


            //MASCARAS FORMATAÇÃO
            maskedTextBoxEnderecoPadraoCep.Mask = Properties.Resources.ResourceManager.GetString("maskCep");
            maskedTextBoxEnderecoPadraoEmail.Mask = Properties.Resources.ResourceManager.GetString("maskEmail");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlEnderecoPadrao_Load(object sender, EventArgs e)
        {

        }

        private void textBoxEnderecoPadraoNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
