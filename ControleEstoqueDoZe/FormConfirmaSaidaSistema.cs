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
    public partial class FormConfirmaSaidaSistema : Form
    {
        public FormConfirmaSaidaSistema()
        {
            InitializeComponent();
            buttonContinuarSistemaConfirmacao.Text = Properties.Resources.ResourceManager.GetString("buttonContinuarSistemaConfirmacao");
            buttonEnviarBandejaConfirmacao.Text = Properties.Resources.ResourceManager.GetString("buttonEnviarBandejaConfirmacao");
            buttonSairSistemaConfirmacao.Text = Properties.Resources.ResourceManager.GetString("buttonSairSistemaConfirmacao");
            labelMensagemSairSistema.Text = Properties.Resources.ResourceManager.GetString("labelMensagemSairSistema");
        }

        String botaoClicado;
        private void FormConfirmaSaidaSistema_Load(object sender, EventArgs e)
        {

        }
       
    }
}
