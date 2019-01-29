namespace Cognizant.WindowsForms
{
    partial class DadosAcesso
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
            this.txtContaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContaId
            // 
            this.txtContaId.Location = new System.Drawing.Point(81, 12);
            this.txtContaId.Name = "txtContaId";
            this.txtContaId.Size = new System.Drawing.Size(166, 20);
            this.txtContaId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID da conta";
            // 
            // btnAcessar
            // 
            this.btnAcessar.Location = new System.Drawing.Point(12, 38);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(235, 23);
            this.btnAcessar.TabIndex = 4;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // DadosAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 68);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContaId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DadosAcesso";
            this.Text = "Dados de acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Button btnCancelar;
    }
}