
namespace ControleEstoqueDoZe
{
    partial class UserControlHeaderPrincipal
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
            this.panelHeaderPrincipalListagemEmpresas = new System.Windows.Forms.Panel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonHeaderSairSistema = new System.Windows.Forms.Button();
            this.labelHeaderTituloSistema = new System.Windows.Forms.Label();
            this.panelHeaderPrincipalListagemEmpresas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeaderPrincipalListagemEmpresas
            // 
            this.panelHeaderPrincipalListagemEmpresas.AutoSize = true;
            this.panelHeaderPrincipalListagemEmpresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelHeaderPrincipalListagemEmpresas.Controls.Add(this.buttonDashboard);
            this.panelHeaderPrincipalListagemEmpresas.Controls.Add(this.buttonHeaderSairSistema);
            this.panelHeaderPrincipalListagemEmpresas.Controls.Add(this.labelHeaderTituloSistema);
            this.panelHeaderPrincipalListagemEmpresas.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderPrincipalListagemEmpresas.Name = "panelHeaderPrincipalListagemEmpresas";
            this.panelHeaderPrincipalListagemEmpresas.Size = new System.Drawing.Size(1280, 60);
            this.panelHeaderPrincipalListagemEmpresas.TabIndex = 2;
            this.panelHeaderPrincipalListagemEmpresas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeaderPrincipalListagemEmpresas_Paint);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonDashboard.FlatAppearance.BorderSize = 2;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(296, 14);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(220, 35);
            this.buttonDashboard.TabIndex = 7;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonHeaderSairSistema
            // 
            this.buttonHeaderSairSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHeaderSairSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHeaderSairSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonHeaderSairSistema.Location = new System.Drawing.Point(1176, 12);
            this.buttonHeaderSairSistema.Name = "buttonHeaderSairSistema";
            this.buttonHeaderSairSistema.Size = new System.Drawing.Size(75, 35);
            this.buttonHeaderSairSistema.TabIndex = 1;
            this.buttonHeaderSairSistema.Text = "Sair";
            this.buttonHeaderSairSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHeaderSairSistema.UseVisualStyleBackColor = true;
            this.buttonHeaderSairSistema.Click += new System.EventHandler(this.buttonHeaderSairSistema_Click);
            // 
            // labelHeaderTituloSistema
            // 
            this.labelHeaderTituloSistema.AutoSize = true;
            this.labelHeaderTituloSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderTituloSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.labelHeaderTituloSistema.Location = new System.Drawing.Point(71, 11);
            this.labelHeaderTituloSistema.Name = "labelHeaderTituloSistema";
            this.labelHeaderTituloSistema.Size = new System.Drawing.Size(157, 39);
            this.labelHeaderTituloSistema.TabIndex = 0;
            this.labelHeaderTituloSistema.Text = "Zé Lojas";
            this.labelHeaderTituloSistema.Click += new System.EventHandler(this.labelHeaderTituloSistema_Click);
            // 
            // UserControlHeaderPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHeaderPrincipalListagemEmpresas);
            this.Name = "UserControlHeaderPrincipal";
            this.Size = new System.Drawing.Size(1280, 60);
            this.panelHeaderPrincipalListagemEmpresas.ResumeLayout(false);
            this.panelHeaderPrincipalListagemEmpresas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderPrincipalListagemEmpresas;
        public System.Windows.Forms.Button buttonHeaderSairSistema;
        public System.Windows.Forms.Label labelHeaderTituloSistema;
        public System.Windows.Forms.Button buttonDashboard;
    }
}
