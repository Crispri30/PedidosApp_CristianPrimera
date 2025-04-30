namespace PedidosApp_CristianPrimeraV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCliente = new TextBox();
            cmbProducto = new ComboBox();
            chkUrgente = new CheckBox();
            nudPeso = new NumericUpDown();
            nudDistancia = new NumericUpDown();
            lblResultado = new Label();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDistancia).BeginInit();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(312, 48);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 0;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(312, 99);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(121, 23);
            cmbProducto.TabIndex = 1;
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(312, 148);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(68, 19);
            chkUrgente.TabIndex = 2;
            chkUrgente.Text = "Urgente";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // nudPeso
            // 
            nudPeso.Location = new Point(312, 192);
            nudPeso.Name = "nudPeso";
            nudPeso.Size = new Size(120, 23);
            nudPeso.TabIndex = 3;
            // 
            // nudDistancia
            // 
            nudDistancia.Location = new Point(312, 245);
            nudDistancia.Name = "nudDistancia";
            nudDistancia.Size = new Size(120, 23);
            nudDistancia.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(312, 328);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "label1";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(435, 308);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(142, 54);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(nudDistancia);
            Controls.Add(nudPeso);
            Controls.Add(chkUrgente);
            Controls.Add(cmbProducto);
            Controls.Add(txtCliente);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDistancia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private ComboBox cmbProducto;
        private CheckBox chkUrgente;
        private NumericUpDown nudPeso;
        private NumericUpDown nudDistancia;
        private Label lblResultado;
        private Button btnCalcular;
    }
}
