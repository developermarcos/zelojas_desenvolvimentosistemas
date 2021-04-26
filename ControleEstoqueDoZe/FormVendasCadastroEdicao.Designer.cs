
namespace ControleEstoqueDoZe
{
    partial class FormVendasCadastroEdicao
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
            this.panelEditarExcluirPadrao = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelEditarExcluirPadrao
            // 
            this.panelEditarExcluirPadrao.Location = new System.Drawing.Point(592, 637);
            this.panelEditarExcluirPadrao.Name = "panelEditarExcluirPadrao";
            this.panelEditarExcluirPadrao.Size = new System.Drawing.Size(580, 100);
            this.panelEditarExcluirPadrao.TabIndex = 8;
            // 
            // FormVendasCadastroEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.panelEditarExcluirPadrao);
            this.KeyPreview = true;
            this.Name = "FormVendasCadastroEdicao";
            this.Text = "Vendas Cadastro/Edição";
            this.Load += new System.EventHandler(this.FormVendasCadastroEdicao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEditarExcluirPadrao;
    }
}