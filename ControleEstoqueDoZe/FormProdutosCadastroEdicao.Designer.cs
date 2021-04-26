
namespace ControleEstoqueDoZe
{
    partial class FormProdutosCadastroEdicao
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
            this.labelProdutosCadastroTituloPagina = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxProdutosCadastroEdicaoStatus = new System.Windows.Forms.GroupBox();
            this.checkBoxProdutosCadastroEdicaoInativo = new System.Windows.Forms.CheckBox();
            this.checkBoxProdutosCadastroEdicaoAtivo = new System.Windows.Forms.CheckBox();
            this.textBoxProdutosCadastroEdicaoDescricao = new System.Windows.Forms.TextBox();
            this.labelProdutosCadastroEdicaoDescricao = new System.Windows.Forms.Label();
            this.textBoxProdutosCadastroEdicaoID = new System.Windows.Forms.TextBox();
            this.labelProdutosCadastroEdicaoID = new System.Windows.Forms.Label();
            this.textBoxProdutosCadastroEdicaoNome = new System.Windows.Forms.TextBox();
            this.labelProdutosCadastroEdicaoNome = new System.Windows.Forms.Label();
            this.panelDadosEnderecoPadrao = new System.Windows.Forms.Panel();
            this.panelEditarExcluirPadrao = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBoxProdutosCadastroEdicaoStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProdutosCadastroTituloPagina
            // 
            this.labelProdutosCadastroTituloPagina.AutoSize = true;
            this.labelProdutosCadastroTituloPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutosCadastroTituloPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.labelProdutosCadastroTituloPagina.Location = new System.Drawing.Point(38, 30);
            this.labelProdutosCadastroTituloPagina.Name = "labelProdutosCadastroTituloPagina";
            this.labelProdutosCadastroTituloPagina.Size = new System.Drawing.Size(243, 31);
            this.labelProdutosCadastroTituloPagina.TabIndex = 20;
            this.labelProdutosCadastroTituloPagina.Text = "Cadastro Produto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.groupBoxProdutosCadastroEdicaoStatus);
            this.panel1.Controls.Add(this.textBoxProdutosCadastroEdicaoDescricao);
            this.panel1.Controls.Add(this.labelProdutosCadastroEdicaoDescricao);
            this.panel1.Controls.Add(this.textBoxProdutosCadastroEdicaoID);
            this.panel1.Controls.Add(this.labelProdutosCadastroEdicaoID);
            this.panel1.Controls.Add(this.textBoxProdutosCadastroEdicaoNome);
            this.panel1.Controls.Add(this.labelProdutosCadastroEdicaoNome);
            this.panel1.Location = new System.Drawing.Point(44, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 222);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxProdutosCadastroEdicaoStatus
            // 
            this.groupBoxProdutosCadastroEdicaoStatus.Controls.Add(this.checkBoxProdutosCadastroEdicaoInativo);
            this.groupBoxProdutosCadastroEdicaoStatus.Controls.Add(this.checkBoxProdutosCadastroEdicaoAtivo);
            this.groupBoxProdutosCadastroEdicaoStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProdutosCadastroEdicaoStatus.Location = new System.Drawing.Point(280, 66);
            this.groupBoxProdutosCadastroEdicaoStatus.Name = "groupBoxProdutosCadastroEdicaoStatus";
            this.groupBoxProdutosCadastroEdicaoStatus.Size = new System.Drawing.Size(200, 88);
            this.groupBoxProdutosCadastroEdicaoStatus.TabIndex = 24;
            this.groupBoxProdutosCadastroEdicaoStatus.TabStop = false;
            this.groupBoxProdutosCadastroEdicaoStatus.Text = "Status";
            // 
            // checkBoxProdutosCadastroEdicaoInativo
            // 
            this.checkBoxProdutosCadastroEdicaoInativo.AutoSize = true;
            this.checkBoxProdutosCadastroEdicaoInativo.Location = new System.Drawing.Point(7, 58);
            this.checkBoxProdutosCadastroEdicaoInativo.Name = "checkBoxProdutosCadastroEdicaoInativo";
            this.checkBoxProdutosCadastroEdicaoInativo.Size = new System.Drawing.Size(75, 24);
            this.checkBoxProdutosCadastroEdicaoInativo.TabIndex = 5;
            this.checkBoxProdutosCadastroEdicaoInativo.Text = "Inativo";
            this.checkBoxProdutosCadastroEdicaoInativo.UseVisualStyleBackColor = true;
            // 
            // checkBoxProdutosCadastroEdicaoAtivo
            // 
            this.checkBoxProdutosCadastroEdicaoAtivo.AutoSize = true;
            this.checkBoxProdutosCadastroEdicaoAtivo.Location = new System.Drawing.Point(7, 26);
            this.checkBoxProdutosCadastroEdicaoAtivo.Name = "checkBoxProdutosCadastroEdicaoAtivo";
            this.checkBoxProdutosCadastroEdicaoAtivo.Size = new System.Drawing.Size(63, 24);
            this.checkBoxProdutosCadastroEdicaoAtivo.TabIndex = 4;
            this.checkBoxProdutosCadastroEdicaoAtivo.Text = "Ativo";
            this.checkBoxProdutosCadastroEdicaoAtivo.UseVisualStyleBackColor = true;
            // 
            // textBoxProdutosCadastroEdicaoDescricao
            // 
            this.textBoxProdutosCadastroEdicaoDescricao.Location = new System.Drawing.Point(29, 88);
            this.textBoxProdutosCadastroEdicaoDescricao.Multiline = true;
            this.textBoxProdutosCadastroEdicaoDescricao.Name = "textBoxProdutosCadastroEdicaoDescricao";
            this.textBoxProdutosCadastroEdicaoDescricao.Size = new System.Drawing.Size(229, 88);
            this.textBoxProdutosCadastroEdicaoDescricao.TabIndex = 3;
            // 
            // labelProdutosCadastroEdicaoDescricao
            // 
            this.labelProdutosCadastroEdicaoDescricao.AutoSize = true;
            this.labelProdutosCadastroEdicaoDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutosCadastroEdicaoDescricao.Location = new System.Drawing.Point(25, 66);
            this.labelProdutosCadastroEdicaoDescricao.Name = "labelProdutosCadastroEdicaoDescricao";
            this.labelProdutosCadastroEdicaoDescricao.Size = new System.Drawing.Size(80, 20);
            this.labelProdutosCadastroEdicaoDescricao.TabIndex = 22;
            this.labelProdutosCadastroEdicaoDescricao.Text = "Descrição";
            // 
            // textBoxProdutosCadastroEdicaoID
            // 
            this.textBoxProdutosCadastroEdicaoID.Location = new System.Drawing.Point(29, 40);
            this.textBoxProdutosCadastroEdicaoID.Multiline = true;
            this.textBoxProdutosCadastroEdicaoID.Name = "textBoxProdutosCadastroEdicaoID";
            this.textBoxProdutosCadastroEdicaoID.Size = new System.Drawing.Size(54, 20);
            this.textBoxProdutosCadastroEdicaoID.TabIndex = 1;
            this.textBoxProdutosCadastroEdicaoID.TabStop = false;
            // 
            // labelProdutosCadastroEdicaoID
            // 
            this.labelProdutosCadastroEdicaoID.AutoSize = true;
            this.labelProdutosCadastroEdicaoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutosCadastroEdicaoID.Location = new System.Drawing.Point(25, 18);
            this.labelProdutosCadastroEdicaoID.Name = "labelProdutosCadastroEdicaoID";
            this.labelProdutosCadastroEdicaoID.Size = new System.Drawing.Size(26, 20);
            this.labelProdutosCadastroEdicaoID.TabIndex = 20;
            this.labelProdutosCadastroEdicaoID.Text = "ID";
            // 
            // textBoxProdutosCadastroEdicaoNome
            // 
            this.textBoxProdutosCadastroEdicaoNome.Location = new System.Drawing.Point(105, 40);
            this.textBoxProdutosCadastroEdicaoNome.Multiline = true;
            this.textBoxProdutosCadastroEdicaoNome.Name = "textBoxProdutosCadastroEdicaoNome";
            this.textBoxProdutosCadastroEdicaoNome.Size = new System.Drawing.Size(229, 20);
            this.textBoxProdutosCadastroEdicaoNome.TabIndex = 2;
            // 
            // labelProdutosCadastroEdicaoNome
            // 
            this.labelProdutosCadastroEdicaoNome.AutoSize = true;
            this.labelProdutosCadastroEdicaoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutosCadastroEdicaoNome.Location = new System.Drawing.Point(101, 18);
            this.labelProdutosCadastroEdicaoNome.Name = "labelProdutosCadastroEdicaoNome";
            this.labelProdutosCadastroEdicaoNome.Size = new System.Drawing.Size(51, 20);
            this.labelProdutosCadastroEdicaoNome.TabIndex = 0;
            this.labelProdutosCadastroEdicaoNome.Text = "Nome";
            // 
            // panelDadosEnderecoPadrao
            // 
            this.panelDadosEnderecoPadrao.Location = new System.Drawing.Point(592, 80);
            this.panelDadosEnderecoPadrao.Name = "panelDadosEnderecoPadrao";
            this.panelDadosEnderecoPadrao.Size = new System.Drawing.Size(580, 497);
            this.panelDadosEnderecoPadrao.TabIndex = 2;
            // 
            // panelEditarExcluirPadrao
            // 
            this.panelEditarExcluirPadrao.Location = new System.Drawing.Point(592, 607);
            this.panelEditarExcluirPadrao.Name = "panelEditarExcluirPadrao";
            this.panelEditarExcluirPadrao.Size = new System.Drawing.Size(580, 100);
            this.panelEditarExcluirPadrao.TabIndex = 3;
            // 
            // FormProdutosCadastroEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.panelEditarExcluirPadrao);
            this.Controls.Add(this.panelDadosEnderecoPadrao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelProdutosCadastroTituloPagina);
            this.KeyPreview = true;
            this.Name = "FormProdutosCadastroEdicao";
            this.Text = "Produtos Cadastro/Edição";
            this.Load += new System.EventHandler(this.FormProdutosCadastroEdicao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxProdutosCadastroEdicaoStatus.ResumeLayout(false);
            this.groupBoxProdutosCadastroEdicaoStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProdutosCadastroTituloPagina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxProdutosCadastroEdicaoStatus;
        private System.Windows.Forms.CheckBox checkBoxProdutosCadastroEdicaoInativo;
        private System.Windows.Forms.CheckBox checkBoxProdutosCadastroEdicaoAtivo;
        private System.Windows.Forms.TextBox textBoxProdutosCadastroEdicaoDescricao;
        private System.Windows.Forms.Label labelProdutosCadastroEdicaoDescricao;
        private System.Windows.Forms.TextBox textBoxProdutosCadastroEdicaoID;
        private System.Windows.Forms.Label labelProdutosCadastroEdicaoID;
        private System.Windows.Forms.TextBox textBoxProdutosCadastroEdicaoNome;
        private System.Windows.Forms.Label labelProdutosCadastroEdicaoNome;
        private System.Windows.Forms.Panel panelDadosEnderecoPadrao;
        private System.Windows.Forms.Panel panelEditarExcluirPadrao;
    }
}