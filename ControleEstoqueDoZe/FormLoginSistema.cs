using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueDoZe
{
    public partial class FormLoginSistema : System.Windows.Forms.Form
    {
        public FormLoginSistema()
        {
            InitializeComponent();
            this.Text = Properties.Resources.ResourceManager.GetString("FormLoginSistema");
            labelNomeLojaLoginSistema.Text = Properties.Resources.ResourceManager.GetString("labelNomeLojaLoginSistema");
            labelNomeLoginSistema.Text = Properties.Resources.ResourceManager.GetString("labelNomeLoginSistema");
            labelSenhaLoginSistema.Text = Properties.Resources.ResourceManager.GetString("labelSenhaLoginSistema");
            buttonLoggarLoginSistema.Text = Properties.Resources.ResourceManager.GetString("buttonLoggarLoginSistema");
        }

        private void textBoxNomeLoginSistema_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLoggarLoginSistema_Click(object sender, EventArgs e)
        {
            FormTelasListagem formPrincipal = new FormTelasListagem("empresas", "Cadastrar", "Empresas");
            this.Hide();
            formPrincipal.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLoginSistema_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNomeLoginSistema_Click(object sender, EventArgs e)
        {

        }
    }
}
