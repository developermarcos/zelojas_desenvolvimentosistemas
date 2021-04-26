using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueDoZe
{
    public partial class FormIdioma : Form
    {
        public FormIdioma()
        {
            InitializeComponent();

            this.Text = Properties.Resources.ResourceManager.GetString("FormIdioma");
            labelIdiomaTitulo.Text = Properties.Resources.ResourceManager.GetString("labelIdiomaTitulo");
            comboBoxListBoxMenuSelecionaIdioma.Text = Properties.Resources.ResourceManager.GetString("comboBoxListBoxMenuSelecionaIdioma");


            comboBoxListBoxMenuSelecionaIdioma.Items.Add("pt");
            comboBoxListBoxMenuSelecionaIdioma.Items.Add("en");
            comboBoxListBoxMenuSelecionaIdioma.Items.Add("es");


            comboBoxListBoxMenuSelecionaIdioma.SelectedItem = ConfigurationManager.AppSettings.Get("Cultura");
            
        }

        
        
        private void FormIdioma_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("Cultura");
            config.AppSettings.Settings.Add("Cultura", comboBoxListBoxMenuSelecionaIdioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            Close();

            MessageBox.Show("Cultura alterada com sucesso! Reinicie a aplicação para aplicar a nova cultura!");
        }
    }
}
