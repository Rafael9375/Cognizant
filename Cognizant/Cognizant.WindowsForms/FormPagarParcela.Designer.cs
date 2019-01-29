namespace Cognizant.WindowsForms
{
    partial class FormPagarParcela
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
            this.pnlPagDebito = new System.Windows.Forms.Panel();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.qtdPagarPar = new System.Windows.Forms.NumericUpDown();
            this.cbCompra = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlPagDebito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdPagarPar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPagDebito
            // 
            this.pnlPagDebito.Controls.Add(this.lblTotalPagar);
            this.pnlPagDebito.Controls.Add(this.label13);
            this.pnlPagDebito.Controls.Add(this.qtdPagarPar);
            this.pnlPagDebito.Controls.Add(this.cbCompra);
            this.pnlPagDebito.Controls.Add(this.label16);
            this.pnlPagDebito.Controls.Add(this.btnPagar);
            this.pnlPagDebito.Controls.Add(this.label15);
            this.pnlPagDebito.Controls.Add(this.label17);
            this.pnlPagDebito.Location = new System.Drawing.Point(23, 11);
            this.pnlPagDebito.Name = "pnlPagDebito";
            this.pnlPagDebito.Size = new System.Drawing.Size(239, 239);
            this.pnlPagDebito.TabIndex = 18;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(109, 157);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(36, 16);
            this.lblTotalPagar.TabIndex = 24;
            this.lblTotalPagar.Text = "0,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Total à pagar:";
            // 
            // qtdPagarPar
            // 
            this.qtdPagarPar.Enabled = false;
            this.qtdPagarPar.Location = new System.Drawing.Point(6, 119);
            this.qtdPagarPar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtdPagarPar.Name = "qtdPagarPar";
            this.qtdPagarPar.Size = new System.Drawing.Size(120, 20);
            this.qtdPagarPar.TabIndex = 22;
            this.qtdPagarPar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtdPagarPar.ValueChanged += new System.EventHandler(this.qtdPagarPar_ValueChanged);
            // 
            // cbCompra
            // 
            this.cbCompra.FormattingEnabled = true;
            this.cbCompra.Location = new System.Drawing.Point(6, 59);
            this.cbCompra.Name = "cbCompra";
            this.cbCompra.Size = new System.Drawing.Size(217, 21);
            this.cbCompra.TabIndex = 17;
            this.cbCompra.Text = "Selecionar compra";
            this.cbCompra.SelectedIndexChanged += new System.EventHandler(this.cbCompra_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "Parcelas";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(6, 199);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(217, 23);
            this.btnPagar.TabIndex = 8;
            this.btnPagar.Text = "Confirmar pagamento";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(184, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Pagar parcelas no débito";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "Compra";
            // 
            // FormPagarParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pnlPagDebito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPagarParcela";
            this.Text = "FormPagarParcela";
            this.Load += new System.EventHandler(this.FormPagarParcela_Load);
            this.pnlPagDebito.ResumeLayout(false);
            this.pnlPagDebito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdPagarPar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPagDebito;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown qtdPagarPar;
        private System.Windows.Forms.ComboBox cbCompra;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
    }
}