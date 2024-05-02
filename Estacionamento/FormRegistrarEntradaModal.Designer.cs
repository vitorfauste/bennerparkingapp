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
            SuspendLayout();
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(12, 44);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(260, 23);
            txtPlaca.TabIndex = 0;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(12, 26);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(44, 15);
            lblPlaca.TabIndex = 3;
            lblPlaca.Text = "PLACA";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(12, 98);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(131, 15);
            lblHora.TabIndex = 4;
            lblHora.Text = "HORÁRIO DE ENTRADA";
            // 
            // dtpHora
            // 
            dtpHora.Location = new Point(12, 116);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(260, 23);
            dtpHora.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(60, 174);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(154, 55);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // FormRegistrarEntradaModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
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
    }
}