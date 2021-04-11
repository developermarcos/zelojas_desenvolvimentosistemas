
namespace ControleEstoqueDoZe
{
    partial class UserControlSalvarExcluir
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
            this.buttonSalvarUserControl = new System.Windows.Forms.Button();
            this.buttonFecharUserControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSalvarUserControl
            // 
            this.buttonSalvarUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonSalvarUserControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarUserControl.ForeColor = System.Drawing.Color.White;
            this.buttonSalvarUserControl.Image = global::ControleEstoqueDoZe.Properties.Resources.salvar;
            this.buttonSalvarUserControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvarUserControl.Location = new System.Drawing.Point(13, 15);
            this.buttonSalvarUserControl.Name = "buttonSalvarUserControl";
            this.buttonSalvarUserControl.Size = new System.Drawing.Size(160, 45);
            this.buttonSalvarUserControl.TabIndex = 2;
            this.buttonSalvarUserControl.Text = "Salvar";
            this.buttonSalvarUserControl.UseVisualStyleBackColor = false;
            this.buttonSalvarUserControl.Click += new System.EventHandler(this.buttonSalvarUserControl_Click);
            // 
            // buttonFecharUserControl
            // 
            this.buttonFecharUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.buttonFecharUserControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFecharUserControl.ForeColor = System.Drawing.Color.White;
            this.buttonFecharUserControl.Image = global::ControleEstoqueDoZe.Properties.Resources.deletar_excluir;
            this.buttonFecharUserControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFecharUserControl.Location = new System.Drawing.Point(197, 15);
            this.buttonFecharUserControl.Name = "buttonFecharUserControl";
            this.buttonFecharUserControl.Size = new System.Drawing.Size(160, 45);
            this.buttonFecharUserControl.TabIndex = 1;
            this.buttonFecharUserControl.Text = "Excluir";
            this.buttonFecharUserControl.UseVisualStyleBackColor = false;
            this.buttonFecharUserControl.Click += new System.EventHandler(this.buttonExcluirUserControl_Click);
            // 
            // UserControlSalvarExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonSalvarUserControl);
            this.Controls.Add(this.buttonFecharUserControl);
            this.Name = "UserControlSalvarExcluir";
            this.Size = new System.Drawing.Size(374, 75);
            this.Load += new System.EventHandler(this.UserControlSalvarExcluir_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonFecharUserControl;
        public System.Windows.Forms.Button buttonSalvarUserControl;
    }
}
