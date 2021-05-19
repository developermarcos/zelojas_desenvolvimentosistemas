
namespace ControleEstoqueDoZe
{
    partial class FormConfirmaSaidaSistema
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
            this.buttonEnviarBandejaConfirmacao = new System.Windows.Forms.Button();
            this.buttonSairSistemaConfirmacao = new System.Windows.Forms.Button();
            this.buttonContinuarSistemaConfirmacao = new System.Windows.Forms.Button();
            this.labelMensagemSairSistema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEnviarBandejaConfirmacao
            // 
            this.buttonEnviarBandejaConfirmacao.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonEnviarBandejaConfirmacao.Location = new System.Drawing.Point(443, 167);
            this.buttonEnviarBandejaConfirmacao.Name = "buttonEnviarBandejaConfirmacao";
            this.buttonEnviarBandejaConfirmacao.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviarBandejaConfirmacao.TabIndex = 7;
            this.buttonEnviarBandejaConfirmacao.Text = "Enviar para bandeja";
            this.buttonEnviarBandejaConfirmacao.UseVisualStyleBackColor = true;
            // 
            // buttonSairSistemaConfirmacao
            // 
            this.buttonSairSistemaConfirmacao.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonSairSistemaConfirmacao.Location = new System.Drawing.Point(351, 167);
            this.buttonSairSistemaConfirmacao.Name = "buttonSairSistemaConfirmacao";
            this.buttonSairSistemaConfirmacao.Size = new System.Drawing.Size(75, 23);
            this.buttonSairSistemaConfirmacao.TabIndex = 6;
            this.buttonSairSistemaConfirmacao.Text = "Sair";
            this.buttonSairSistemaConfirmacao.UseVisualStyleBackColor = true;
            // 
            // buttonContinuarSistemaConfirmacao
            // 
            this.buttonContinuarSistemaConfirmacao.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonContinuarSistemaConfirmacao.Location = new System.Drawing.Point(259, 167);
            this.buttonContinuarSistemaConfirmacao.Name = "buttonContinuarSistemaConfirmacao";
            this.buttonContinuarSistemaConfirmacao.Size = new System.Drawing.Size(75, 23);
            this.buttonContinuarSistemaConfirmacao.TabIndex = 5;
            this.buttonContinuarSistemaConfirmacao.Text = "Continuar";
            this.buttonContinuarSistemaConfirmacao.UseVisualStyleBackColor = true;
            // 
            // labelMensagemSairSistema
            // 
            this.labelMensagemSairSistema.AutoSize = true;
            this.labelMensagemSairSistema.Location = new System.Drawing.Point(368, 83);
            this.labelMensagemSairSistema.Name = "labelMensagemSairSistema";
            this.labelMensagemSairSistema.Size = new System.Drawing.Size(59, 13);
            this.labelMensagemSairSistema.TabIndex = 4;
            this.labelMensagemSairSistema.Text = "Deseja sair";
            this.labelMensagemSairSistema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormConfirmaSaidaSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 273);
            this.Controls.Add(this.buttonEnviarBandejaConfirmacao);
            this.Controls.Add(this.buttonSairSistemaConfirmacao);
            this.Controls.Add(this.buttonContinuarSistemaConfirmacao);
            this.Controls.Add(this.labelMensagemSairSistema);
            this.Name = "FormConfirmaSaidaSistema";
            this.Text = "FormConfirmaSaidaSistema";
            this.Load += new System.EventHandler(this.FormConfirmaSaidaSistema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnviarBandejaConfirmacao;
        private System.Windows.Forms.Button buttonSairSistemaConfirmacao;
        private System.Windows.Forms.Button buttonContinuarSistemaConfirmacao;
        private System.Windows.Forms.Label labelMensagemSairSistema;
    }
}