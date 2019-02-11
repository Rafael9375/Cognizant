namespace Cognizant.WindowsForms
{
    partial class FormExtrato
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvExtrato = new System.Windows.Forms.DataGridView();
            this.lblContaId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtrato)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID da conta";
            // 
            // dgvExtrato
            // 
            this.dgvExtrato.AllowUserToAddRows = false;
            this.dgvExtrato.AllowUserToDeleteRows = false;
            this.dgvExtrato.AllowUserToResizeColumns = false;
            this.dgvExtrato.AllowUserToResizeRows = false;
            this.dgvExtrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtrato.ColumnHeadersVisible = false;
            this.dgvExtrato.EnableHeadersVisualStyles = false;
            this.dgvExtrato.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvExtrato.Location = new System.Drawing.Point(12, 91);
            this.dgvExtrato.Name = "dgvExtrato";
            this.dgvExtrato.ReadOnly = true;
            this.dgvExtrato.RowHeadersVisible = false;
            this.dgvExtrato.ShowCellErrors = false;
            this.dgvExtrato.ShowCellToolTips = false;
            this.dgvExtrato.ShowEditingIcon = false;
            this.dgvExtrato.Size = new System.Drawing.Size(254, 150);
            this.dgvExtrato.TabIndex = 25;
            // 
            // lblContaId
            // 
            this.lblContaId.AutoSize = true;
            this.lblContaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaId.Location = new System.Drawing.Point(12, 25);
            this.lblContaId.Name = "lblContaId";
            this.lblContaId.Size = new System.Drawing.Size(16, 16);
            this.lblContaId.TabIndex = 26;
            this.lblContaId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Extrato";
            // 
            // FormExtrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContaId);
            this.Controls.Add(this.dgvExtrato);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormExtrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExtrato";
            this.Load += new System.EventHandler(this.FormExtrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvExtrato;
        private System.Windows.Forms.Label lblContaId;
        private System.Windows.Forms.Label label1;
    }
}