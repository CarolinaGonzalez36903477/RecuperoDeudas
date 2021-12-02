
namespace RecuperoDeudas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbImporteAdeudado = new System.Windows.Forms.TextBox();
            this.txbPunitorioDia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbFechaVencimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbFechaPago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbPunitorio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbImporteTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.TxbInteresPromedio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbDiasDeAtraso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstbPagos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio";
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(157, 55);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(169, 28);
            this.cmbServicio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Importe Adeudado";
            // 
            // txbImporteAdeudado
            // 
            this.txbImporteAdeudado.Location = new System.Drawing.Point(157, 109);
            this.txbImporteAdeudado.Name = "txbImporteAdeudado";
            this.txbImporteAdeudado.Size = new System.Drawing.Size(169, 26);
            this.txbImporteAdeudado.TabIndex = 3;
            // 
            // txbPunitorioDia
            // 
            this.txbPunitorioDia.Location = new System.Drawing.Point(157, 159);
            this.txbPunitorioDia.Name = "txbPunitorioDia";
            this.txbPunitorioDia.ReadOnly = true;
            this.txbPunitorioDia.Size = new System.Drawing.Size(169, 26);
            this.txbPunitorioDia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Punitorio por dia";
            // 
            // txbFechaVencimiento
            // 
            this.txbFechaVencimiento.Location = new System.Drawing.Point(157, 215);
            this.txbFechaVencimiento.Name = "txbFechaVencimiento";
            this.txbFechaVencimiento.Size = new System.Drawing.Size(169, 26);
            this.txbFechaVencimiento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // txbFechaPago
            // 
            this.txbFechaPago.Location = new System.Drawing.Point(157, 270);
            this.txbFechaPago.Name = "txbFechaPago";
            this.txbFechaPago.Size = new System.Drawing.Size(169, 26);
            this.txbFechaPago.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Pago";
            // 
            // txtbPunitorio
            // 
            this.txtbPunitorio.Location = new System.Drawing.Point(157, 359);
            this.txtbPunitorio.Name = "txtbPunitorio";
            this.txtbPunitorio.Size = new System.Drawing.Size(169, 26);
            this.txtbPunitorio.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Interes Punitorio";
            // 
            // txbImporteTotal
            // 
            this.txbImporteTotal.Location = new System.Drawing.Point(157, 412);
            this.txbImporteTotal.Name = "txbImporteTotal";
            this.txbImporteTotal.Size = new System.Drawing.Size(169, 26);
            this.txbImporteTotal.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Importe Total";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(157, 311);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 29);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // BtnPagar
            // 
            this.BtnPagar.Location = new System.Drawing.Point(157, 474);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(104, 29);
            this.BtnPagar.TabIndex = 15;
            this.BtnPagar.Text = "PAGAR";
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // TxbInteresPromedio
            // 
            this.TxbInteresPromedio.Location = new System.Drawing.Point(556, 408);
            this.TxbInteresPromedio.Name = "TxbInteresPromedio";
            this.TxbInteresPromedio.Size = new System.Drawing.Size(169, 26);
            this.TxbInteresPromedio.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Interes Promedio";
            // 
            // txbDiasDeAtraso
            // 
            this.txbDiasDeAtraso.Location = new System.Drawing.Point(556, 353);
            this.txbDiasDeAtraso.Name = "txbDiasDeAtraso";
            this.txbDiasDeAtraso.Size = new System.Drawing.Size(169, 26);
            this.txbDiasDeAtraso.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Dias de atraso Promedio";
            // 
            // lstbPagos
            // 
            this.lstbPagos.FormattingEnabled = true;
            this.lstbPagos.ItemHeight = 20;
            this.lstbPagos.Location = new System.Drawing.Point(510, 45);
            this.lstbPagos.Name = "lstbPagos";
            this.lstbPagos.Size = new System.Drawing.Size(235, 284);
            this.lstbPagos.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.lstbPagos);
            this.Controls.Add(this.TxbInteresPromedio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbDiasDeAtraso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbImporteTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbPunitorio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbFechaPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbFechaVencimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbPunitorioDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbImporteAdeudado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbImporteAdeudado;
        private System.Windows.Forms.TextBox txbPunitorioDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbFechaVencimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbFechaPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbPunitorio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbImporteTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.TextBox TxbInteresPromedio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbDiasDeAtraso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstbPagos;
    }
}

