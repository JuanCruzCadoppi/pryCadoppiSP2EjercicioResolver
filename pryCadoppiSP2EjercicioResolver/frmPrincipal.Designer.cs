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
            this.txtCodigo = new TextBox();
            this.cboTipoBoleto = new ComboBox();
            this.gbDistancia = new GroupBox();
            rbCorta = new RadioButton();
            rbLarga = new RadioButton();
            btnRegistrar = new Button();
            this.dtpFecha = new DateTimePicker();
            this.lblFecha = new Label();
            this.lblCodigo = new Label();
            lblTipo = new Label();
            this.gbDistancia.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new Point(77, 70);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new Size(73, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // cboTipoBoleto
            // 
            this.cboTipoBoleto.FormattingEnabled = true;
            this.cboTipoBoleto.Location = new Point(77, 112);
            this.cboTipoBoleto.Name = "cboTipoBoleto";
            this.cboTipoBoleto.Size = new Size(114, 23);
            this.cboTipoBoleto.TabIndex = 1;
            // 
            // gbDistancia
            // 
            this.gbDistancia.Controls.Add(rbLarga);
            this.gbDistancia.Controls.Add(rbCorta);
            this.gbDistancia.Location = new Point(22, 160);
            this.gbDistancia.Name = "gbDistancia";
            this.gbDistancia.Size = new Size(169, 95);
            this.gbDistancia.TabIndex = 2;
            this.gbDistancia.TabStop = false;
            this.gbDistancia.Text = "Distancia";
            this.gbDistancia.Enter += this.groupBox1_Enter;
            // 
            // rbCorta
            // 
            rbCorta.AutoSize = true;
            rbCorta.Location = new Point(34, 22);
            rbCorta.Name = "rbCorta";
            rbCorta.Size = new Size(54, 19);
            rbCorta.TabIndex = 3;
            rbCorta.TabStop = true;
            rbCorta.Text = "Corta";
            rbCorta.UseVisualStyleBackColor = true;
            rbCorta.CheckedChanged += this.radioButton1_CheckedChanged;
            // 
            // rbLarga
            // 
            rbLarga.AutoSize = true;
            rbLarga.Location = new Point(34, 62);
            rbLarga.Name = "rbLarga";
            rbLarga.Size = new Size(54, 19);
            rbLarga.TabIndex = 4;
            rbLarga.TabStop = true;
            rbLarga.Text = "Larga";
            rbLarga.UseVisualStyleBackColor = true;
            rbLarga.CheckedChanged += this.radioButton2_CheckedChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(116, 261);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new Point(77, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new Size(114, 23);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.ValueChanged += this.dateTimePicker1_ValueChanged;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new Point(22, 34);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new Size(38, 15);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new Point(22, 77);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new Size(46, 15);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Click += this.label2_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(22, 120);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "Tipo";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 303);
            Controls.Add(lblTipo);
            Controls.Add(this.lblCodigo);
            Controls.Add(this.lblFecha);
            Controls.Add(this.dtpFecha);
            Controls.Add(btnRegistrar);
            Controls.Add(this.gbDistancia);
            Controls.Add(this.cboTipoBoleto);
            Controls.Add(this.txtCodigo);
            Name = "frmPrincipal";
            Text = "Venta Boletería";
            Load += frmPrincipal_Load;
            this.gbDistancia.ResumeLayout(false);
            this.gbDistancia.PerformLayout();
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
    }
}