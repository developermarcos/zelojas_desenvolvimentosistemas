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
    public partial class UserControlHeaderPrincipal : UserControl
    {
        public String nomeBotao;
        FormTelasListagem telaAtual;
        public UserControlHeaderPrincipal()
        {
            InitializeComponent();
            labelHeaderTituloSistema.Text = Properties.Resources.ResourceManager.GetString("labelHeaderTituloSistema");
            buttonHeaderSairSistema.Text = Properties.Resources.ResourceManager.GetString(" buttonHeaderSairSistema");
        }
        public UserControlHeaderPrincipal(FormTelasListagem listagemAtual)
        {
            InitializeComponent();
            //telaAtual = listagemAtual;
            //FormLoginSistema telaLogin = new FormLoginSistema();
            //telaLogin.Show();

            labelHeaderTituloSistema.Text = Properties.Resources.ResourceManager.GetString("labelHeaderTituloSistema");
            buttonHeaderSairSistema.Text = Properties.Resources.ResourceManager.GetString("buttonHeaderSairSistema");
        }



        private void buttonHeaderSairSistema_Click(object sender, EventArgs e)
        {

            FormLoginSistema telaLogin = new FormLoginSistema();
            telaLogin.Show();

            telaAtual.Hide();
            
;        }

        internal object buttomHeaderPrincipal()
        {
            throw new NotImplementedException();
        }

        private void labelHeaderTituloSistema_Click(object sender, EventArgs e)
        {

        }

        private void panelHeaderPrincipalListagemEmpresas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
