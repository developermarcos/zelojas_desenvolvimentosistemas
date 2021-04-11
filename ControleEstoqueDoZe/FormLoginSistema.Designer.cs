
namespace ControleEstoqueDoZe
{
    partial class FormLoginSistema
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginSistema));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLoggarLoginSistema = new System.Windows.Forms.Button();
            this.textBoxSenhaLoginSistema = new System.Windows.Forms.TextBox();
            this.textBoxNomeLoginSistema = new System.Windows.Forms.TextBox();
            this.labelSenhaLoginSistema = new System.Windows.Forms.Label();
            this.labelNomeLoginSistema = new System.Windows.Forms.Label();
            this.labelNomeLojaLoginSistema = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.buttonLoggarLoginSistema);
            this.panel1.Controls.Add(this.textBoxSenhaLoginSistema);
            this.panel1.Controls.Add(this.textBoxNomeLoginSistema);
            this.panel1.Controls.Add(this.labelSenhaLoginSistema);
            this.panel1.Controls.Add(this.labelNomeLoginSistema);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonLoggarLoginSistema
            // 
            resources.ApplyResources(this.buttonLoggarLoginSistema, "buttonLoggarLoginSistema");
            this.buttonLoggarLoginSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.buttonLoggarLoginSistema.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.buttonLoggarLoginSistema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.buttonLoggarLoginSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.buttonLoggarLoginSistema.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLoggarLoginSistema.Name = "buttonLoggarLoginSistema";
            this.buttonLoggarLoginSistema.UseVisualStyleBackColor = false;
            this.buttonLoggarLoginSistema.Click += new System.EventHandler(this.buttonLoggarLoginSistema_Click);
            // 
            // textBoxSenhaLoginSistema
            // 
            resources.ApplyResources(this.textBoxSenhaLoginSistema, "textBoxSenhaLoginSistema");
            this.textBoxSenhaLoginSistema.Name = "textBoxSenhaLoginSistema";
            // 
            // textBoxNomeLoginSistema
            // 
            resources.ApplyResources(this.textBoxNomeLoginSistema, "textBoxNomeLoginSistema");
            this.textBoxNomeLoginSistema.Name = "textBoxNomeLoginSistema";
            this.textBoxNomeLoginSistema.TextChanged += new System.EventHandler(this.textBoxNomeLoginSistema_TextChanged);
            // 
            // labelSenhaLoginSistema
            // 
            resources.ApplyResources(this.labelSenhaLoginSistema, "labelSenhaLoginSistema");
            this.labelSenhaLoginSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.labelSenhaLoginSistema.Name = "labelSenhaLoginSistema";
            // 
            // labelNomeLoginSistema
            // 
            resources.ApplyResources(this.labelNomeLoginSistema, "labelNomeLoginSistema");
            this.labelNomeLoginSistema.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeLoginSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.labelNomeLoginSistema.Name = "labelNomeLoginSistema";
            this.labelNomeLoginSistema.Click += new System.EventHandler(this.labelNomeLoginSistema_Click);
            // 
            // labelNomeLojaLoginSistema
            // 
            resources.ApplyResources(this.labelNomeLojaLoginSistema, "labelNomeLojaLoginSistema");
            this.labelNomeLojaLoginSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.labelNomeLojaLoginSistema.Name = "labelNomeLojaLoginSistema";
            this.labelNomeLojaLoginSistema.UseMnemonic = false;
            this.labelNomeLojaLoginSistema.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormLoginSistema
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.labelNomeLojaLoginSistema);
            this.Controls.Add(this.panel1);
            this.Name = "FormLoginSistema";
            this.Load += new System.EventHandler(this.FormLoginSistema_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSenhaLoginSistema;
        private System.Windows.Forms.Label labelNomeLoginSistema;
        private System.Windows.Forms.TextBox textBoxSenhaLoginSistema;
        private System.Windows.Forms.TextBox textBoxNomeLoginSistema;
        private System.Windows.Forms.Button buttonLoggarLoginSistema;
        private System.Windows.Forms.Label labelNomeLojaLoginSistema;
    }
}

