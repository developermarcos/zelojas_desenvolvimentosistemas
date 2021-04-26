
namespace ControleEstoqueDoZe
{
    partial class FormConfirmaAlteracao
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
            this.panelConfirmaCancelaAcao = new System.Windows.Forms.Panel();
            this.labelManssagemConfirmaCancela = new System.Windows.Forms.Label();
            this.buttonConfirmaAcao = new System.Windows.Forms.Button();
            this.buttonCancelaAcao = new System.Windows.Forms.Button();
            this.panelConfirmaCancelaAcao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConfirmaCancelaAcao
            // 
            this.panelConfirmaCancelaAcao.Controls.Add(this.buttonCancelaAcao);
            this.panelConfirmaCancelaAcao.Controls.Add(this.buttonConfirmaAcao);
            this.panelConfirmaCancelaAcao.Controls.Add(this.labelManssagemConfirmaCancela);
            this.panelConfirmaCancelaAcao.Location = new System.Drawing.Point(146, 93);
            this.panelConfirmaCancelaAcao.Name = "panelConfirmaCancelaAcao";
            this.panelConfirmaCancelaAcao.Size = new System.Drawing.Size(519, 256);
            this.panelConfirmaCancelaAcao.TabIndex = 0;
            // 
            // labelManssagemConfirmaCancela
            // 
            this.labelManssagemConfirmaCancela.AutoSize = true;
            this.labelManssagemConfirmaCancela.Location = new System.Drawing.Point(226, 99);
            this.labelManssagemConfirmaCancela.Name = "labelManssagemConfirmaCancela";
            this.labelManssagemConfirmaCancela.Size = new System.Drawing.Size(79, 13);
            this.labelManssagemConfirmaCancela.TabIndex = 0;
            this.labelManssagemConfirmaCancela.Text = "Frase desejada";
            // 
            // buttonConfirmaAcao
            // 
            this.buttonConfirmaAcao.Location = new System.Drawing.Point(158, 174);
            this.buttonConfirmaAcao.Name = "buttonConfirmaAcao";
            this.buttonConfirmaAcao.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmaAcao.TabIndex = 1;
            this.buttonConfirmaAcao.Text = "Confirmar";
            this.buttonConfirmaAcao.UseVisualStyleBackColor = true;
            this.buttonConfirmaAcao.Click += new System.EventHandler(this.buttonConfirmaAcao_Click);
            // 
            // buttonCancelaAcao
            // 
            this.buttonCancelaAcao.Location = new System.Drawing.Point(299, 174);
            this.buttonCancelaAcao.Name = "buttonCancelaAcao";
            this.buttonCancelaAcao.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelaAcao.TabIndex = 2;
            this.buttonCancelaAcao.Text = "Cancelar";
            this.buttonCancelaAcao.UseVisualStyleBackColor = true;
            // 
            // FormConfirmaAlteracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelConfirmaCancelaAcao);
            this.Name = "FormConfirmaAlteracao";
            this.Text = "Confirmação";
            this.Load += new System.EventHandler(this.FormConfirmaAlteracao_Load);
            this.panelConfirmaCancelaAcao.ResumeLayout(false);
            this.panelConfirmaCancelaAcao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConfirmaCancelaAcao;
        private System.Windows.Forms.Button buttonCancelaAcao;
        private System.Windows.Forms.Button buttonConfirmaAcao;
        private System.Windows.Forms.Label labelManssagemConfirmaCancela;
    }
}