namespace WFPresentationLayer
{
    partial class FormRegistrarEntradaModal
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
            txtPlaca = new TextBox();
            lblPlaca = new Label();
            lblHora = new Label();
            dtpHora = new DateTimePicker();
            btnRegistrar = new Button();
            txtTitulo = new Label();
            SuspendLayout();
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(12, 90);
            txtPlaca.MaxLength = 8;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(260, 23);
            txtPlaca.TabIndex = 0;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(12, 72);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(44, 15);
            lblPlaca.TabIndex = 3;
            lblPlaca.Text = "PLACA";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(12, 144);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(131, 15);
            lblHora.TabIndex = 4;
            lblHora.Text = "HORÁRIO DE ENTRADA";
            // 
            // dtpHora
            // 
            dtpHora.Location = new Point(12, 162);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(260, 23);
            dtpHora.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(69, 213);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(146, 36);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.AutoEllipsis = true;
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(9, 26);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(269, 21);
            txtTitulo.TabIndex = 7;
            txtTitulo.Text = "REGISTRAR ENTRADA DE VEÍCULO";
            txtTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormRegistrarEntradaModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(txtTitulo);
            Controls.Add(btnRegistrar);
            Controls.Add(dtpHora);
            Controls.Add(lblHora);
            Controls.Add(lblPlaca);
            Controls.Add(txtPlaca);
            Name = "FormRegistrarEntradaModal";
            Text = "FormRegistrarEntradaModal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlaca;
        private Label lblPlaca;
        private Label lblHora;
        private DateTimePicker dtpHora;
        private Button btnRegistrar;
        private Label txtTitulo;
    }
}