namespace pryCadoppiSP2EjercicioResolver
{
    partial class frmPrincipal
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
            btnRegistrar = new Button();
            lblTipo = new Label();
            grbDistancia = new GroupBox();
            optLarga = new RadioButton();
            opCorta = new RadioButton();
            txtCodigo = new TextBox();
            cboTipoBoleto = new ComboBox();
            dtFecha = new DateTimePicker();
            lblFecha = new Label();
            lblCodigo = new Label();
            grbDistancia.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(124, 262);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(22, 122);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "Tipo";
            // 
            // grbDistancia
            // 
            grbDistancia.Controls.Add(optLarga);
            grbDistancia.Controls.Add(opCorta);
            grbDistancia.Location = new Point(22, 156);
            grbDistancia.Name = "grbDistancia";
            grbDistancia.Size = new Size(177, 100);
            grbDistancia.TabIndex = 8;
            grbDistancia.TabStop = false;
            grbDistancia.Text = "Distancia";
            // 
            // optLarga
            // 
            optLarga.AutoSize = true;
            optLarga.Location = new Point(18, 60);
            optLarga.Name = "optLarga";
            optLarga.Size = new Size(54, 19);
            optLarga.TabIndex = 1;
            optLarga.TabStop = true;
            optLarga.Text = "Larga";
            optLarga.UseVisualStyleBackColor = true;
            // 
            // opCorta
            // 
            opCorta.AutoSize = true;
            opCorta.Location = new Point(18, 22);
            opCorta.Name = "opCorta";
            opCorta.Size = new Size(54, 19);
            opCorta.TabIndex = 0;
            opCorta.TabStop = true;
            opCorta.Text = "Corta";
            opCorta.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(71, 74);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 9;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // cboTipoBoleto
            // 
            cboTipoBoleto.FormattingEnabled = true;
            cboTipoBoleto.Location = new Point(70, 118);
            cboTipoBoleto.Name = "cboTipoBoleto";
            cboTipoBoleto.Size = new Size(129, 23);
            cboTipoBoleto.TabIndex = 10;
            // 
            // dtFecha
            // 
            dtFecha.Format = DateTimePickerFormat.Short;
            dtFecha.Location = new Point(71, 30);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(128, 23);
            dtFecha.TabIndex = 11;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(22, 38);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 12;
            lblFecha.Text = "Fecha";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(22, 80);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 13;
            lblCodigo.Text = "Codigo";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 300);
            Controls.Add(lblCodigo);
            Controls.Add(lblFecha);
            Controls.Add(dtFecha);
            Controls.Add(cboTipoBoleto);
            Controls.Add(txtCodigo);
            Controls.Add(grbDistancia);
            Controls.Add(lblTipo);
            Controls.Add(btnRegistrar);
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta Boletería";
            Load += frmPrincipal_Load;
            grbDistancia.ResumeLayout(false);
            grbDistancia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private RadioButton rbLarga;
        private RadioButton rbCorta;
        private Button btnRegistrar;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label lblTipo;
        private GroupBox grbDistancia;
        private RadioButton optLarga;
        private RadioButton opCorta;
        private TextBox txtCodigo;
        private ComboBox cboTipoBoleto;
        private DateTimePicker dtFecha;
        private Label lblFecha;
        private Label lblCodigo;
    }
}