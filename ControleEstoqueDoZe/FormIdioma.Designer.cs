
namespace ControleEstoqueDoZe
{
    partial class FormIdioma
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
            this.comboBoxListBoxMenuSelecionaIdioma = new System.Windows.Forms.ComboBox();
            this.labelIdiomaTitulo = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxListBoxMenuSelecionaIdioma
            // 
            this.comboBoxListBoxMenuSelecionaIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.comboBoxListBoxMenuSelecionaIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxListBoxMenuSelecionaIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxListBoxMenuSelecionaIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.comboBoxListBoxMenuSelecionaIdioma.FormattingEnabled = true;
            this.comboBoxListBoxMenuSelecionaIdioma.Location = new System.Drawing.Point(132, 145);
            this.comboBoxListBoxMenuSelecionaIdioma.Name = "comboBoxListBoxMenuSelecionaIdioma";
            this.comboBoxListBoxMenuSelecionaIdioma.Size = new System.Drawing.Size(220, 28);
            this.comboBoxListBoxMenuSelecionaIdioma.TabIndex = 1;
            this.comboBoxListBoxMenuSelecionaIdioma.Text = "Idioma";
            // 
            // labelIdiomaTitulo
            // 
            this.labelIdiomaTitulo.AutoSize = true;
            this.labelIdiomaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdiomaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.labelIdiomaTitulo.Location = new System.Drawing.Point(112, 78);
            this.labelIdiomaTitulo.Name = "labelIdiomaTitulo";
            this.labelIdiomaTitulo.Size = new System.Drawing.Size(259, 31);
            this.labelIdiomaTitulo.TabIndex = 11;
            this.labelIdiomaTitulo.Text = "Selecione o idioma";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Image = global::ControleEstoqueDoZe.Properties.Resources.salvar;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(160, 222);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(160, 45);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // FormIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelIdiomaTitulo);
            this.Controls.Add(this.comboBoxListBoxMenuSelecionaIdioma);
            this.Name = "FormIdioma";
            this.Text = "Idioma";
            this.Load += new System.EventHandler(this.FormIdioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxListBoxMenuSelecionaIdioma;
        private System.Windows.Forms.Label labelIdiomaTitulo;
        public System.Windows.Forms.Button buttonSalvar;
    }
}