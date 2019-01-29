namespace Cognizant.WindowsForms
{
    partial class Cotacao
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblCotacao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAtual = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cotação do dólar comercial (R$):";
            // 
            // lblCotacao
            // 
            this.lblCotacao.AutoSize = true;
            this.lblCotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotacao.Location = new System.Drawing.Point(54, 33);
            this.lblCotacao.Name = "lblCotacao";
            this.lblCotacao.Size = new System.Drawing.Size(46, 20);
            this.lblCotacao.TabIndex = 5;
            this.lblCotacao.Text = "erro!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Última atualização feita em ";
            // 
            // lblAtual
            // 
            this.lblAtual.AutoSize = true;
            this.lblAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtual.ForeColor = System.Drawing.Color.Blue;
            this.lblAtual.Location = new System.Drawing.Point(13, 90);
            this.lblAtual.Name = "lblAtual";
            this.lblAtual.Size = new System.Drawing.Size(0, 20);
            this.lblAtual.TabIndex = 7;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(16, 129);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(77, 104);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BRL (R$)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "USD ($)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Simuldor para conversão";
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(156, 174);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(100, 20);
            this.txtReal.TabIndex = 9;
            this.txtReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReal.Click += new System.EventHandler(this.txtReal_Click);
            this.txtReal.Enter += new System.EventHandler(this.txtReal_Enter);
            this.txtReal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReal_KeyPress);
            this.txtReal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtReal_KeyUp);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(156, 200);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolar.TabIndex = 10;
            this.txtDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDolar.Click += new System.EventHandler(this.txtDolar_Click);
            this.txtDolar.Enter += new System.EventHandler(this.txtDolar_Enter);
            this.txtDolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDolar_KeyPress);
            this.txtDolar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDolar_KeyUp);
            // 
            // Cotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 250);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtReal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAtual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCotacao);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cotacao";
            this.Text = "Cotacao";
            this.Load += new System.EventHandler(this.Cotacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCotacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAtual;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.TextBox txtDolar;
    }
}