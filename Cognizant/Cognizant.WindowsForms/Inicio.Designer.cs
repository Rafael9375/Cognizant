namespace Cognizant.WindowsForms
{
    partial class Inicio
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
            this.btnAcesso = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCotacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAcesso
            // 
            this.btnAcesso.Location = new System.Drawing.Point(56, 12);
            this.btnAcesso.Name = "btnAcesso";
            this.btnAcesso.Size = new System.Drawing.Size(147, 23);
            this.btnAcesso.TabIndex = 0;
            this.btnAcesso.Text = "Acessar conta";
            this.btnAcesso.UseVisualStyleBackColor = true;
            this.btnAcesso.Click += new System.EventHandler(this.btnAcesso_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(56, 41);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(147, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar conta";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCotacao
            // 
            this.btnCotacao.Location = new System.Drawing.Point(56, 70);
            this.btnCotacao.Name = "btnCotacao";
            this.btnCotacao.Size = new System.Drawing.Size(147, 23);
            this.btnCotacao.TabIndex = 2;
            this.btnCotacao.Text = "Cotação do dolar";
            this.btnCotacao.UseVisualStyleBackColor = true;
            this.btnCotacao.Click += new System.EventHandler(this.btnCotacao_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 109);
            this.Controls.Add(this.btnCotacao);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAcesso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Cognizant";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAcesso;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCotacao;
    }
}