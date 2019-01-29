namespace Cognizant.WindowsForms
{
    partial class FormTransferencia
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
            this.pnlTrans = new System.Windows.Forms.Panel();
            this.dtTrans = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObsTrans = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContaTrans = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValTrans = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTrans
            // 
            this.pnlTrans.Controls.Add(this.dtTrans);
            this.pnlTrans.Controls.Add(this.label12);
            this.pnlTrans.Controls.Add(this.btnTransferir);
            this.pnlTrans.Controls.Add(this.label7);
            this.pnlTrans.Controls.Add(this.txtObsTrans);
            this.pnlTrans.Controls.Add(this.label6);
            this.pnlTrans.Controls.Add(this.txtContaTrans);
            this.pnlTrans.Controls.Add(this.label5);
            this.pnlTrans.Controls.Add(this.txtValTrans);
            this.pnlTrans.Controls.Add(this.label4);
            this.pnlTrans.Location = new System.Drawing.Point(12, 12);
            this.pnlTrans.Name = "pnlTrans";
            this.pnlTrans.Size = new System.Drawing.Size(239, 269);
            this.pnlTrans.TabIndex = 8;
            // 
            // dtTrans
            // 
            this.dtTrans.Location = new System.Drawing.Point(6, 176);
            this.dtTrans.Name = "dtTrans";
            this.dtTrans.Size = new System.Drawing.Size(217, 20);
            this.dtTrans.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Agendamento";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(6, 214);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(217, 23);
            this.btnTransferir.TabIndex = 8;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Transferência";
            // 
            // txtObsTrans
            // 
            this.txtObsTrans.Location = new System.Drawing.Point(6, 118);
            this.txtObsTrans.MaxLength = 50;
            this.txtObsTrans.Name = "txtObsTrans";
            this.txtObsTrans.Size = new System.Drawing.Size(217, 20);
            this.txtObsTrans.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Conta";
            // 
            // txtContaTrans
            // 
            this.txtContaTrans.Location = new System.Drawing.Point(123, 59);
            this.txtContaTrans.MaxLength = 50;
            this.txtContaTrans.Name = "txtContaTrans";
            this.txtContaTrans.Size = new System.Drawing.Size(100, 20);
            this.txtContaTrans.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Observação";
            // 
            // txtValTrans
            // 
            this.txtValTrans.Location = new System.Drawing.Point(6, 59);
            this.txtValTrans.Name = "txtValTrans";
            this.txtValTrans.Size = new System.Drawing.Size(100, 20);
            this.txtValTrans.TabIndex = 9;
            this.txtValTrans.Text = "0,00";
            this.txtValTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValTrans.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtValTrans_MouseClick);
            this.txtValTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValTrans_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor (R$)";
            // 
            // FormTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 298);
            this.Controls.Add(this.pnlTrans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTransferencia";
            this.Text = "FormTransferencia";
            this.pnlTrans.ResumeLayout(false);
            this.pnlTrans.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTrans;
        private System.Windows.Forms.DateTimePicker dtTrans;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObsTrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContaTrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValTrans;
        private System.Windows.Forms.Label label4;
    }
}