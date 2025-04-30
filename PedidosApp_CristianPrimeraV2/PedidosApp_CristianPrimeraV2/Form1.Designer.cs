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
            bttHistorial = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            // bttHistorial
            // 
            bttHistorial.Location = new Point(587, 192);
            bttHistorial.Name = "bttHistorial";
            bttHistorial.Size = new Size(142, 54);
            bttHistorial.TabIndex = 7;
            bttHistorial.Text = "Historial";
            bttHistorial.UseVisualStyleBackColor = true;
            bttHistorial.Click += bttHistorial_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 51);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 8;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 107);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 9;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 152);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 10;
            label3.Text = "Es urgente?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 194);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 11;
            label4.Text = "Peso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 253);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 12;
            label5.Text = "Distancia";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bttHistorial);
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
        private Button bttHistorial;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
