namespace Cognizant.WindowsForms
{
    partial class FormCompraParcelada
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
            this.pnlCompraParcelada = new System.Windows.Forms.Panel();
            this.txtObsCompra = new System.Windows.Forms.TextBox();
            this.btnCompra = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.qtdParcelas = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValPar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlCompraParcelada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCompraParcelada
            // 
            this.pnlCompraParcelada.Controls.Add(this.txtObsCompra);
            this.pnlCompraParcelada.Controls.Add(this.btnCompra);
            this.pnlCompraParcelada.Controls.Add(this.label11);
            this.pnlCompraParcelada.Controls.Add(this.qtdParcelas);
            this.pnlCompraParcelada.Controls.Add(this.label10);
            this.pnlCompraParcelada.Controls.Add(this.txtValPar);
            this.pnlCompraParcelada.Controls.Add(this.label9);
            this.pnlCompraParcelada.Controls.Add(this.label8);
            this.pnlCompraParcelada.Location = new System.Drawing.Point(12, 12);
            this.pnlCompraParcelada.Name = "pnlCompraParcelada";
            this.pnlCompraParcelada.Size = new System.Drawing.Size(222, 254);
            this.pnlCompraParcelada.TabIndex = 18;
            // 
            // txtObsCompra
            // 
            this.txtObsCompra.Location = new System.Drawing.Point(6, 171);
            this.txtObsCompra.MaxLength = 20;
            this.txtObsCompra.Name = "txtObsCompra";
            this.txtObsCompra.Size = new System.Drawing.Size(206, 20);
            this.txtObsCompra.TabIndex = 18;
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(3, 214);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(209, 23);
            this.btnCompra.TabIndex = 17;
            this.btnCompra.Text = "Confirmar compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nome da loja";
            // 
            // qtdParcelas
            // 
            this.qtdParcelas.Location = new System.Drawing.Point(6, 60);
            this.qtdParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtdParcelas.Name = "qtdParcelas";
            this.qtdParcelas.Size = new System.Drawing.Size(120, 20);
            this.qtdParcelas.TabIndex = 20;
            this.qtdParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Parcelas";
            // 
            // txtValPar
            // 
            this.txtValPar.Location = new System.Drawing.Point(6, 115);
            this.txtValPar.Name = "txtValPar";
            this.txtValPar.Size = new System.Drawing.Size(120, 20);
            this.txtValPar.TabIndex = 19;
            this.txtValPar.Text = "0,00";
            this.txtValPar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValPar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValPar_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Valor da parcela (R$)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Compra parcelada";
            // 
            // FormCompraParcelada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 289);
            this.Controls.Add(this.pnlCompraParcelada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCompraParcelada";
            this.Text = "FormCompraParcelada";
            this.pnlCompraParcelada.ResumeLayout(false);
            this.pnlCompraParcelada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCompraParcelada;
        private System.Windows.Forms.TextBox txtObsCompra;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown qtdParcelas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValPar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}