
namespace ControleEstoqueDoZe
{
    partial class FormUsuarioCadastroEdicao
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
            this.panelDadosEnderecoPadrao = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBoxUsuarioCadastroEdicaoCpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxTipoEmpresaCadEditEstoque = new System.Windows.Forms.GroupBox();
            this.radioButtonEmpresaCadEditEstoque = new System.Windows.Forms.RadioButton();
            this.radioButtonEmpresaCadEditGerente = new System.Windows.Forms.RadioButton();
            this.radioButtonEmpresaCadEditUsuario = new System.Windows.Forms.RadioButton();
            this.radioButtonEmpresaCadEditFinanceiro = new System.Windows.Forms.RadioButton();
            this.labelUsuarioCadastroEdicaoCpf = new System.Windows.Forms.Label();
            this.textBoxUsuarioCadastroEdicaoNome = new System.Windows.Forms.TextBox();
            this.labelUsuarioCadastroEdicaoNome = new System.Windows.Forms.Label();
            this.labelUsuariosCadastroEdicaoTitulo = new System.Windows.Forms.Label();
            this.panelEditarExcluirPadrao = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBoxTipoEmpresaCadEditEstoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDadosEnderecoPadrao
            // 
            this.panelDadosEnderecoPadrao.Location = new System.Drawing.Point(592, 58);
            this.panelDadosEnderecoPadrao.Name = "panelDadosEnderecoPadrao";
            this.panelDadosEnderecoPadrao.Size = new System.Drawing.Size(580, 532);
            this.panelDadosEnderecoPadrao.TabIndex = 4;
            this.panelDadosEnderecoPadrao.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDadosEnderecoPadrao_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.maskedTextBoxUsuarioCadastroEdicaoCpf);
            this.panel1.Controls.Add(this.groupBoxTipoEmpresaCadEditEstoque);
            this.panel1.Controls.Add(this.labelUsuarioCadastroEdicaoCpf);
            this.panel1.Controls.Add(this.textBoxUsuarioCadastroEdicaoNome);
            this.panel1.Controls.Add(this.labelUsuarioCadastroEdicaoNome);
            this.panel1.Location = new System.Drawing.Point(42, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 532);
            this.panel1.TabIndex = 5;
            // 
            // maskedTextBoxUsuarioCadastroEdicaoCpf
            // 
            this.maskedTextBoxUsuarioCadastroEdicaoCpf.Location = new System.Drawing.Point(263, 37);
            this.maskedTextBoxUsuarioCadastroEdicaoCpf.Name = "maskedTextBoxUsuarioCadastroEdicaoCpf";
            this.maskedTextBoxUsuarioCadastroEdicaoCpf.Size = new System.Drawing.Size(211, 20);
            this.maskedTextBoxUsuarioCadastroEdicaoCpf.TabIndex = 17;
            // 
            // groupBoxTipoEmpresaCadEditEstoque
            // 
            this.groupBoxTipoEmpresaCadEditEstoque.Controls.Add(this.radioButtonEmpresaCadEditEstoque);
            this.groupBoxTipoEmpresaCadEditEstoque.Controls.Add(this.radioButtonEmpresaCadEditGerente);
            this.groupBoxTipoEmpresaCadEditEstoque.Controls.Add(this.radioButtonEmpresaCadEditUsuario);
            this.groupBoxTipoEmpresaCadEditEstoque.Controls.Add(this.radioButtonEmpresaCadEditFinanceiro);
            this.groupBoxTipoEmpresaCadEditEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTipoEmpresaCadEditEstoque.Location = new System.Drawing.Point(28, 63);
            this.groupBoxTipoEmpresaCadEditEstoque.Name = "groupBoxTipoEmpresaCadEditEstoque";
            this.groupBoxTipoEmpresaCadEditEstoque.Size = new System.Drawing.Size(402, 54);
            this.groupBoxTipoEmpresaCadEditEstoque.TabIndex = 15;
            this.groupBoxTipoEmpresaCadEditEstoque.TabStop = false;
            this.groupBoxTipoEmpresaCadEditEstoque.Text = "Tipo";
            // 
            // radioButtonEmpresaCadEditEstoque
            // 
            this.radioButtonEmpresaCadEditEstoque.AutoSize = true;
            this.radioButtonEmpresaCadEditEstoque.Location = new System.Drawing.Point(202, 25);
            this.radioButtonEmpresaCadEditEstoque.Name = "radioButtonEmpresaCadEditEstoque";
            this.radioButtonEmpresaCadEditEstoque.Size = new System.Drawing.Size(87, 24);
            this.radioButtonEmpresaCadEditEstoque.TabIndex = 9;
            this.radioButtonEmpresaCadEditEstoque.TabStop = true;
            this.radioButtonEmpresaCadEditEstoque.Text = "Estoque";
            this.radioButtonEmpresaCadEditEstoque.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmpresaCadEditGerente
            // 
            this.radioButtonEmpresaCadEditGerente.AutoSize = true;
            this.radioButtonEmpresaCadEditGerente.Location = new System.Drawing.Point(20, 25);
            this.radioButtonEmpresaCadEditGerente.Name = "radioButtonEmpresaCadEditGerente";
            this.radioButtonEmpresaCadEditGerente.Size = new System.Drawing.Size(86, 24);
            this.radioButtonEmpresaCadEditGerente.TabIndex = 6;
            this.radioButtonEmpresaCadEditGerente.TabStop = true;
            this.radioButtonEmpresaCadEditGerente.Text = "Gerente";
            this.radioButtonEmpresaCadEditGerente.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmpresaCadEditUsuario
            // 
            this.radioButtonEmpresaCadEditUsuario.AutoSize = true;
            this.radioButtonEmpresaCadEditUsuario.Location = new System.Drawing.Point(112, 25);
            this.radioButtonEmpresaCadEditUsuario.Name = "radioButtonEmpresaCadEditUsuario";
            this.radioButtonEmpresaCadEditUsuario.Size = new System.Drawing.Size(82, 24);
            this.radioButtonEmpresaCadEditUsuario.TabIndex = 8;
            this.radioButtonEmpresaCadEditUsuario.TabStop = true;
            this.radioButtonEmpresaCadEditUsuario.Text = "Usuário";
            this.radioButtonEmpresaCadEditUsuario.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmpresaCadEditFinanceiro
            // 
            this.radioButtonEmpresaCadEditFinanceiro.AutoSize = true;
            this.radioButtonEmpresaCadEditFinanceiro.Location = new System.Drawing.Point(295, 24);
            this.radioButtonEmpresaCadEditFinanceiro.Name = "radioButtonEmpresaCadEditFinanceiro";
            this.radioButtonEmpresaCadEditFinanceiro.Size = new System.Drawing.Size(101, 24);
            this.radioButtonEmpresaCadEditFinanceiro.TabIndex = 10;
            this.radioButtonEmpresaCadEditFinanceiro.TabStop = true;
            this.radioButtonEmpresaCadEditFinanceiro.Text = "Financeiro";
            this.radioButtonEmpresaCadEditFinanceiro.UseVisualStyleBackColor = true;
            // 
            // labelUsuarioCadastroEdicaoCpf
            // 
            this.labelUsuarioCadastroEdicaoCpf.AutoSize = true;
            this.labelUsuarioCadastroEdicaoCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioCadastroEdicaoCpf.Location = new System.Drawing.Point(259, 14);
            this.labelUsuarioCadastroEdicaoCpf.Name = "labelUsuarioCadastroEdicaoCpf";
            this.labelUsuarioCadastroEdicaoCpf.Size = new System.Drawing.Size(40, 20);
            this.labelUsuarioCadastroEdicaoCpf.TabIndex = 2;
            this.labelUsuarioCadastroEdicaoCpf.Text = "CPF";
            // 
            // textBoxUsuarioCadastroEdicaoNome
            // 
            this.textBoxUsuarioCadastroEdicaoNome.Location = new System.Drawing.Point(28, 36);
            this.textBoxUsuarioCadastroEdicaoNome.Multiline = true;
            this.textBoxUsuarioCadastroEdicaoNome.Name = "textBoxUsuarioCadastroEdicaoNome";
            this.textBoxUsuarioCadastroEdicaoNome.Size = new System.Drawing.Size(229, 20);
            this.textBoxUsuarioCadastroEdicaoNome.TabIndex = 1;
            // 
            // labelUsuarioCadastroEdicaoNome
            // 
            this.labelUsuarioCadastroEdicaoNome.AutoSize = true;
            this.labelUsuarioCadastroEdicaoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioCadastroEdicaoNome.Location = new System.Drawing.Point(24, 14);
            this.labelUsuarioCadastroEdicaoNome.Name = "labelUsuarioCadastroEdicaoNome";
            this.labelUsuarioCadastroEdicaoNome.Size = new System.Drawing.Size(51, 20);
            this.labelUsuarioCadastroEdicaoNome.TabIndex = 0;
            this.labelUsuarioCadastroEdicaoNome.Text = "Nome";
            this.labelUsuarioCadastroEdicaoNome.Click += new System.EventHandler(this.labelEmpresaCadastroEdicaoRazaoSocial_Click);
            // 
            // labelUsuariosCadastroEdicaoTitulo
            // 
            this.labelUsuariosCadastroEdicaoTitulo.AutoSize = true;
            this.labelUsuariosCadastroEdicaoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuariosCadastroEdicaoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.labelUsuariosCadastroEdicaoTitulo.Location = new System.Drawing.Point(42, 15);
            this.labelUsuariosCadastroEdicaoTitulo.Name = "labelUsuariosCadastroEdicaoTitulo";
            this.labelUsuariosCadastroEdicaoTitulo.Size = new System.Drawing.Size(242, 31);
            this.labelUsuariosCadastroEdicaoTitulo.TabIndex = 6;
            this.labelUsuariosCadastroEdicaoTitulo.Text = "Cadastro Usuário";
            this.labelUsuariosCadastroEdicaoTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelEditarExcluirPadrao
            // 
            this.panelEditarExcluirPadrao.Location = new System.Drawing.Point(592, 607);
            this.panelEditarExcluirPadrao.Name = "panelEditarExcluirPadrao";
            this.panelEditarExcluirPadrao.Size = new System.Drawing.Size(580, 100);
            this.panelEditarExcluirPadrao.TabIndex = 7;
            // 
            // FormUsuarioCadastroEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.panelEditarExcluirPadrao);
            this.Controls.Add(this.labelUsuariosCadastroEdicaoTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDadosEnderecoPadrao);
            this.Name = "FormUsuarioCadastroEdicao";
            this.Text = "Usuario Cadastro/Edição";
            this.Load += new System.EventHandler(this.FormUsuarioCadastroEdicao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxTipoEmpresaCadEditEstoque.ResumeLayout(false);
            this.groupBoxTipoEmpresaCadEditEstoque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDadosEnderecoPadrao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxUsuarioCadastroEdicaoCpf;
        private System.Windows.Forms.GroupBox groupBoxTipoEmpresaCadEditEstoque;
        private System.Windows.Forms.RadioButton radioButtonEmpresaCadEditEstoque;
        private System.Windows.Forms.RadioButton radioButtonEmpresaCadEditGerente;
        private System.Windows.Forms.RadioButton radioButtonEmpresaCadEditUsuario;
        private System.Windows.Forms.RadioButton radioButtonEmpresaCadEditFinanceiro;
        private System.Windows.Forms.Label labelUsuarioCadastroEdicaoCpf;
        private System.Windows.Forms.TextBox textBoxUsuarioCadastroEdicaoNome;
        private System.Windows.Forms.Label labelUsuarioCadastroEdicaoNome;
        private System.Windows.Forms.Label labelUsuariosCadastroEdicaoTitulo;
        private System.Windows.Forms.Panel panelEditarExcluirPadrao;
    }
}