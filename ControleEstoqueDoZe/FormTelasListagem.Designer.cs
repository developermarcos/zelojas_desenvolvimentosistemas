
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
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.panelHeaderPrincipal = new System.Windows.Forms.Panel();
            this.buttonListagemCadastro = new System.Windows.Forms.Button();
            this.labelTituloPaginaListagemPaginas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
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
            this.labelTituloPaginaListagemPaginas.TabIndex = 0;
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
            // FormTelasListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeaderPrincipal);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Name = "FormTelasListagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.FormListagemEmpresas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuPrincipal;
        private System.Windows.Forms.Panel panelHeaderPrincipal;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button buttonListagemCadastro;
        public System.Windows.Forms.Label labelTituloPaginaListagemPaginas;
    }
}