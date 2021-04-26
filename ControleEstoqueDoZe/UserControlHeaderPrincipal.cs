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
            buttonDashboard.Text = Properties.Resources.ResourceManager.GetString("buttonDashboard");
        }
        public UserControlHeaderPrincipal(FormTelasListagem listagemAtual)
        {
            InitializeComponent();
            //telaAtual = listagemAtual;
            //FormLoginSistema telaLogin = new FormLoginSistema();
            //telaLogin.Show();

            labelHeaderTituloSistema.Text = Properties.Resources.ResourceManager.GetString("labelHeaderTituloSistema");
            buttonHeaderSairSistema.Text = Properties.Resources.ResourceManager.GetString("buttonHeaderSairSistema");
            buttonDashboard.Text = Properties.Resources.ResourceManager.GetString("buttonDashboard");

            //Eventos de estilo para os campos
            buttonHeaderSairSistema.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            buttonHeaderSairSistema.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);

            buttonDashboard.Enter += new EventHandler(ClassHelpers.CampoEventoEnter);
            buttonDashboard.Leave += new EventHandler(ClassHelpers.CampoEventoLeave);
        }



        private void buttonHeaderSairSistema_Click(object sender, EventArgs e)
        {

            FormLoginSistema telaLogin = new FormLoginSistema();
            telaLogin.Show();
            
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

        private void buttonDashboard_Click(object sender, EventArgs e)
        {

            

        }
    }
}
