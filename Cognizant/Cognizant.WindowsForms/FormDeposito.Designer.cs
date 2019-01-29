namespace Cognizant.WindowsForms
{
    partial class FormDeposito
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
            this.pnlDep = new System.Windows.Forms.Panel();
            this.dtDep = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtValDep = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.pnlDep.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDep
            // 
            this.pnlDep.Controls.Add(this.dtDep);
            this.pnlDep.Controls.Add(this.label19);
            this.pnlDep.Controls.Add(this.btnDepositar);
            this.pnlDep.Controls.Add(this.label20);
            this.pnlDep.Controls.Add(this.txtValDep);
            this.pnlDep.Controls.Add(this.label23);
            this.pnlDep.Location = new System.Drawing.Point(12, 12);
            this.pnlDep.Name = "pnlDep";
            this.pnlDep.Size = new System.Drawing.Size(232, 197);
            this.pnlDep.TabIndex = 19;
            // 
            // dtDep
            // 
            this.dtDep.Location = new System.Drawing.Point(6, 119);
            this.dtDep.Name = "dtDep";
            this.dtDep.Size = new System.Drawing.Size(217, 20);
            this.dtDep.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 16);
            this.label19.TabIndex = 15;
            this.label19.Text = "Agendamento";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(6, 155);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(217, 23);
            this.btnDepositar.TabIndex = 8;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(87, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 16);
            this.label20.TabIndex = 14;
            this.label20.Text = "Depositar";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValDep
            // 
            this.txtValDep.Location = new System.Drawing.Point(6, 59);
            this.txtValDep.Name = "txtValDep";
            this.txtValDep.Size = new System.Drawing.Size(100, 20);
            this.txtValDep.TabIndex = 9;
            this.txtValDep.Text = "0,00";
            this.txtValDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValDep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtValDep_MouseClick_1);
            this.txtValDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValDep_KeyPress_1);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 16);
            this.label23.TabIndex = 8;
            this.label23.Text = "Valor (R$)";
            // 
            // FormDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 219);
            this.Controls.Add(this.pnlDep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDeposito";
            this.Text = "FormDeposito";
            this.Load += new System.EventHandler(this.FormDeposito_Load);
            this.pnlDep.ResumeLayout(false);
            this.pnlDep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDep;
        private System.Windows.Forms.DateTimePicker dtDep;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtValDep;
        private System.Windows.Forms.Label label23;
    }
}