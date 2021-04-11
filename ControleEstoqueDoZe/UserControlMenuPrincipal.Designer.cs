
namespace ControleEstoqueDoZe
{
    partial class UserControlMenuPrincipal
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.buttonMenuUsuarios = new System.Windows.Forms.Button();
            this.comboBoxListBoxMenuSelecionaIdioma = new System.Windows.Forms.ComboBox();
            this.buttonMenuVendas = new System.Windows.Forms.Button();
            this.buttonMenuImportacaoXML = new System.Windows.Forms.Button();
            this.buttonMenuEstoque = new System.Windows.Forms.Button();
            this.buttonMenuClientes = new System.Windows.Forms.Button();
            this.buttonMenuFornecedores = new System.Windows.Forms.Button();
            this.buttonMenuProdutos = new System.Windows.Forms.Button();
            this.buttonMenuEmpresa = new System.Windows.Forms.Button();
            this.panelMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelMenuPrincipal.Controls.Add(this.buttonMenuUsuarios);
            this.panelMenuPrincipal.Controls.Add(this.comboBoxListBoxMenuSelecionaIdioma);
            this.panelMenuPrincipal.Controls.Add(this.buttonMenuVendas);
            this.panelMenuPrincipal.Controls.Add(this.buttonMenuImportacaoXML);
            this.panelMenuPrincipal.Controls.Add(this.buttonMenuEstoque);
            this.panelMenuPrincipal.Controls.Add(this.buttonMenuClientes);
            this.panelMenuPrincipal.Controls.Add(this.buttonMenuFornecedores);
            this.panelMenuPrincipal.Controls.Add(this.buttonMenuProdutos);
            this.panelMenuPrincipal.Controls.Add(this.buttonMenuEmpresa);
            this.panelMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(300, 660);
            this.panelMenuPrincipal.TabIndex = 2;
            this.panelMenuPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuPrincipal_Paint);
            // 
            // buttonMenuUsuarios
            // 
            this.buttonMenuUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuUsuarios.FlatAppearance.BorderSize = 2;
            this.buttonMenuUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuUsuarios.Image = global::ControleEstoqueDoZe.Properties.Resources.usuarios;
            this.buttonMenuUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuUsuarios.Location = new System.Drawing.Point(40, 505);
            this.buttonMenuUsuarios.Name = "buttonMenuUsuarios";
            this.buttonMenuUsuarios.Size = new System.Drawing.Size(220, 35);
            this.buttonMenuUsuarios.TabIndex = 10;
            this.buttonMenuUsuarios.Text = "Usuários";
            this.buttonMenuUsuarios.UseVisualStyleBackColor = true;
            this.buttonMenuUsuarios.Click += new System.EventHandler(this.buttonMenuUsuarios_Click);
            // 
            // comboBoxListBoxMenuSelecionaIdioma
            // 
            this.comboBoxListBoxMenuSelecionaIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.comboBoxListBoxMenuSelecionaIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxListBoxMenuSelecionaIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxListBoxMenuSelecionaIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.comboBoxListBoxMenuSelecionaIdioma.FormattingEnabled = true;
            this.comboBoxListBoxMenuSelecionaIdioma.Items.AddRange(new object[] {
            "Português",
            "English",
            "Español"});
            this.comboBoxListBoxMenuSelecionaIdioma.Location = new System.Drawing.Point(40, 560);
            this.comboBoxListBoxMenuSelecionaIdioma.Name = "comboBoxListBoxMenuSelecionaIdioma";
            this.comboBoxListBoxMenuSelecionaIdioma.Size = new System.Drawing.Size(220, 28);
            this.comboBoxListBoxMenuSelecionaIdioma.TabIndex = 9;
            this.comboBoxListBoxMenuSelecionaIdioma.Text = "Idioma";
            // 
            // buttonMenuVendas
            // 
            this.buttonMenuVendas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuVendas.FlatAppearance.BorderSize = 2;
            this.buttonMenuVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuVendas.Image = global::ControleEstoqueDoZe.Properties.Resources.vendas;
            this.buttonMenuVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuVendas.Location = new System.Drawing.Point(40, 335);
            this.buttonMenuVendas.Name = "buttonMenuVendas";
            this.buttonMenuVendas.Size = new System.Drawing.Size(220, 35);
            this.buttonMenuVendas.TabIndex = 6;
            this.buttonMenuVendas.Text = "Vendas";
            this.buttonMenuVendas.UseVisualStyleBackColor = true;
            this.buttonMenuVendas.Click += new System.EventHandler(this.buttonMenuVendas_Click);
            // 
            // buttonMenuImportacaoXML
            // 
            this.buttonMenuImportacaoXML.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuImportacaoXML.FlatAppearance.BorderSize = 2;
            this.buttonMenuImportacaoXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuImportacaoXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuImportacaoXML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuImportacaoXML.Location = new System.Drawing.Point(40, 285);
            this.buttonMenuImportacaoXML.Name = "buttonMenuImportacaoXML";
            this.buttonMenuImportacaoXML.Size = new System.Drawing.Size(220, 35);
            this.buttonMenuImportacaoXML.TabIndex = 5;
            this.buttonMenuImportacaoXML.Text = "Importação XML";
            this.buttonMenuImportacaoXML.UseVisualStyleBackColor = true;
            this.buttonMenuImportacaoXML.Click += new System.EventHandler(this.buttonMenuImportacaoXML_Click);
            // 
            // buttonMenuEstoque
            // 
            this.buttonMenuEstoque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuEstoque.FlatAppearance.BorderSize = 2;
            this.buttonMenuEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuEstoque.Image = global::ControleEstoqueDoZe.Properties.Resources.estoque;
            this.buttonMenuEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuEstoque.Location = new System.Drawing.Point(40, 235);
            this.buttonMenuEstoque.Name = "buttonMenuEstoque";
            this.buttonMenuEstoque.Size = new System.Drawing.Size(220, 35);
            this.buttonMenuEstoque.TabIndex = 4;
            this.buttonMenuEstoque.Text = "Estoque";
            this.buttonMenuEstoque.UseVisualStyleBackColor = true;
            this.buttonMenuEstoque.Click += new System.EventHandler(this.buttonMenuEstoque_Click);
            // 
            // buttonMenuClientes
            // 
            this.buttonMenuClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuClientes.FlatAppearance.BorderSize = 2;
            this.buttonMenuClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuClientes.Image = global::ControleEstoqueDoZe.Properties.Resources.clientes;
            this.buttonMenuClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuClientes.Location = new System.Drawing.Point(40, 185);
            this.buttonMenuClientes.Name = "buttonMenuClientes";
            this.buttonMenuClientes.Size = new System.Drawing.Size(220, 35);
            this.buttonMenuClientes.TabIndex = 3;
            this.buttonMenuClientes.Text = "Clientes";
            this.buttonMenuClientes.UseVisualStyleBackColor = true;
            this.buttonMenuClientes.Click += new System.EventHandler(this.buttonMenuClientes_Click);
            // 
            // buttonMenuFornecedores
            // 
            this.buttonMenuFornecedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuFornecedores.FlatAppearance.BorderSize = 2;
            this.buttonMenuFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuFornecedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuFornecedores.Image = global::ControleEstoqueDoZe.Properties.Resources.fornecedor;
            this.buttonMenuFornecedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuFornecedores.Location = new System.Drawing.Point(40, 135);
            this.buttonMenuFornecedores.Name = "buttonMenuFornecedores";
            this.buttonMenuFornecedores.Size = new System.Drawing.Size(220, 35);
            this.buttonMenuFornecedores.TabIndex = 2;
            this.buttonMenuFornecedores.Text = "Fornecedores";
            this.buttonMenuFornecedores.UseVisualStyleBackColor = true;
            this.buttonMenuFornecedores.Click += new System.EventHandler(this.buttonMenuFornecedores_Click);
            // 
            // buttonMenuProdutos
            // 
            this.buttonMenuProdutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuProdutos.FlatAppearance.BorderSize = 2;
            this.buttonMenuProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuProdutos.Image = global::ControleEstoqueDoZe.Properties.Resources.produtos;
            this.buttonMenuProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuProdutos.Location = new System.Drawing.Point(40, 85);
            this.buttonMenuProdutos.Name = "buttonMenuProdutos";
            this.buttonMenuProdutos.Size = new System.Drawing.Size(220, 35);
            this.buttonMenuProdutos.TabIndex = 1;
            this.buttonMenuProdutos.Text = "Produtos";
            this.buttonMenuProdutos.UseVisualStyleBackColor = true;
            this.buttonMenuProdutos.Click += new System.EventHandler(this.buttonMenuProdutos_Click);
            // 
            // buttonMenuEmpresa
            // 
            this.buttonMenuEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuEmpresa.FlatAppearance.BorderSize = 2;
            this.buttonMenuEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonMenuEmpresa.Image = global::ControleEstoqueDoZe.Properties.Resources.empresa;
            this.buttonMenuEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuEmpresa.Location = new System.Drawing.Point(40, 35);
            this.buttonMenuEmpresa.Name = "buttonMenuEmpresa";
            this.buttonMenuEmpresa.Size = new System.Drawing.Size(220, 35);
            this.buttonMenuEmpresa.TabIndex = 0;
            this.buttonMenuEmpresa.Text = "Empresas";
            this.buttonMenuEmpresa.UseVisualStyleBackColor = true;
            this.buttonMenuEmpresa.Click += new System.EventHandler(this.buttonMenuEmpresa_Click);
            // 
            // UserControlMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenuPrincipal);
            this.Name = "UserControlMenuPrincipal";
            this.Size = new System.Drawing.Size(300, 660);
            this.panelMenuPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuPrincipal;
        private System.Windows.Forms.Button buttonMenuUsuarios;
        private System.Windows.Forms.ComboBox comboBoxListBoxMenuSelecionaIdioma;
        private System.Windows.Forms.Button buttonMenuVendas;
        private System.Windows.Forms.Button buttonMenuImportacaoXML;
        private System.Windows.Forms.Button buttonMenuEstoque;
        private System.Windows.Forms.Button buttonMenuClientes;
        private System.Windows.Forms.Button buttonMenuFornecedores;
        private System.Windows.Forms.Button buttonMenuProdutos;
        private System.Windows.Forms.Button buttonMenuEmpresa;
    }
}
