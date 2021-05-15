
namespace ControleEstoqueDoZe
{
    partial class FormTelasListagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelasListagem));
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.panelHeaderPrincipal = new System.Windows.Forms.Panel();
            this.buttonListagemCadastro = new System.Windows.Forms.Button();
            this.labelTituloPaginaListagemPaginas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelListagemConteudos = new System.Windows.Forms.Panel();
            this.contextMenuStripNavegacaoMenus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lojasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNofityIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirAplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.contextMenuStripNavegacaoMenus.SuspendLayout();
            this.contextMenuStripNofityIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.Location = new System.Drawing.Point(0, 66);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(300, 614);
            this.panelMenuPrincipal.TabIndex = 0;
            this.panelMenuPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuPrincipal_Paint);
            // 
            // panelHeaderPrincipal
            // 
            this.panelHeaderPrincipal.Location = new System.Drawing.Point(0, 1);
            this.panelHeaderPrincipal.Name = "panelHeaderPrincipal";
            this.panelHeaderPrincipal.Size = new System.Drawing.Size(1262, 68);
            this.panelHeaderPrincipal.TabIndex = 1;
            this.panelHeaderPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeaderPrincipal_Paint);
            // 
            // buttonListagemCadastro
            // 
            this.buttonListagemCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.buttonListagemCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListagemCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListagemCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonListagemCadastro.Location = new System.Drawing.Point(773, 4);
            this.buttonListagemCadastro.Name = "buttonListagemCadastro";
            this.buttonListagemCadastro.Size = new System.Drawing.Size(145, 35);
            this.buttonListagemCadastro.TabIndex = 2;
            this.buttonListagemCadastro.Text = "Botão Modelo";
            this.buttonListagemCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonListagemCadastro.UseVisualStyleBackColor = false;
            this.buttonListagemCadastro.Click += new System.EventHandler(this.buttonListagemCadastro_Click);
            // 
            // labelTituloPaginaListagemPaginas
            // 
            this.labelTituloPaginaListagemPaginas.AutoSize = true;
            this.labelTituloPaginaListagemPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPaginaListagemPaginas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.labelTituloPaginaListagemPaginas.Location = new System.Drawing.Point(14, 13);
            this.labelTituloPaginaListagemPaginas.Name = "labelTituloPaginaListagemPaginas";
            this.labelTituloPaginaListagemPaginas.Size = new System.Drawing.Size(137, 20);
            this.labelTituloPaginaListagemPaginas.TabIndex = 2;
            this.labelTituloPaginaListagemPaginas.Text = "Titulo da página";
            this.labelTituloPaginaListagemPaginas.Click += new System.EventHandler(this.labelTituloPaginaListagemPaginas_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonListagemCadastro);
            this.panel2.Controls.Add(this.labelTituloPaginaListagemPaginas);
            this.panel2.Location = new System.Drawing.Point(320, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 43);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelListagemConteudos
            // 
            this.panelListagemConteudos.Location = new System.Drawing.Point(320, 125);
            this.panelListagemConteudos.Name = "panelListagemConteudos";
            this.panelListagemConteudos.Size = new System.Drawing.Size(932, 544);
            this.panelListagemConteudos.TabIndex = 5;
            // 
            // contextMenuStripNavegacaoMenus
            // 
            this.contextMenuStripNavegacaoMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lojasToolStripMenuItem,
            this.funcionariosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.configuracoesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.contextMenuStripNavegacaoMenus.Name = "contextMenuStripNavegacaoMenus";
            this.contextMenuStripNavegacaoMenus.Size = new System.Drawing.Size(171, 158);
            // 
            // lojasToolStripMenuItem
            // 
            this.lojasToolStripMenuItem.Name = "lojasToolStripMenuItem";
            this.lojasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.lojasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.lojasToolStripMenuItem.Text = "Lojas";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.funcionariosToolStripMenuItem.Text = "Funcionários";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.produtosToolStripMenuItem.Text = "produtos";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // configuracoesToolStripMenuItem
            // 
            this.configuracoesToolStripMenuItem.Name = "configuracoesToolStripMenuItem";
            this.configuracoesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.configuracoesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.configuracoesToolStripMenuItem.Text = "Configurações";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // notifyIconSystemTray
            // 
            this.notifyIconSystemTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconSystemTray.BalloonTipText = "Aplicativo continua executando na bandeja";
            this.notifyIconSystemTray.BalloonTipTitle = "Controle de Estoque do Zé";
            this.notifyIconSystemTray.ContextMenuStrip = this.contextMenuStripNofityIcon;
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "notifyIconSystemTray";
            this.notifyIconSystemTray.DoubleClick += new System.EventHandler(this.notifyIconSystemTray_DoubleClick);
            // 
            // contextMenuStripNofityIcon
            // 
            this.contextMenuStripNofityIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirAplicaçãoToolStripMenuItem,
            this.encerrarToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.contextMenuStripNofityIcon.Name = "contextMenuStripNofityIcon";
            this.contextMenuStripNofityIcon.Size = new System.Drawing.Size(156, 70);
            this.contextMenuStripNofityIcon.Text = "contextMenuStripNofityIcon";
            // 
            // abrirAplicaçãoToolStripMenuItem
            // 
            this.abrirAplicaçãoToolStripMenuItem.Name = "abrirAplicaçãoToolStripMenuItem";
            this.abrirAplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.abrirAplicaçãoToolStripMenuItem.Text = "Abrir Aplicação";
            // 
            // encerrarToolStripMenuItem
            // 
            this.encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            this.encerrarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.encerrarToolStripMenuItem.Text = "Encerrar";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            // 
            // FormTelasListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ContextMenuStrip = this.contextMenuStripNavegacaoMenus;
            this.Controls.Add(this.panelListagemConteudos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeaderPrincipal);
            this.Controls.Add(this.panelMenuPrincipal);
            this.KeyPreview = true;
            this.Name = "FormTelasListagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTelasListagem_FormClosing);
            this.Load += new System.EventHandler(this.FormListagemEmpresas_Load);
            this.Resize += new System.EventHandler(this.FormTelasListagem_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStripNavegacaoMenus.ResumeLayout(false);
            this.contextMenuStripNofityIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuPrincipal;
        private System.Windows.Forms.Panel panelHeaderPrincipal;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button buttonListagemCadastro;
        public System.Windows.Forms.Label labelTituloPaginaListagemPaginas;
        public System.Windows.Forms.Panel panelListagemConteudos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNavegacaoMenus;
        private System.Windows.Forms.ToolStripMenuItem lojasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconSystemTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNofityIcon;
        private System.Windows.Forms.ToolStripMenuItem abrirAplicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
    }
}