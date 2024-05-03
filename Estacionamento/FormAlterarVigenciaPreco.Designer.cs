namespace WFPresentationLayer
{
    partial class FormAlterarVigenciaPreco
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
            dtpInicioVigencia = new DateTimePicker();
            dtpFimVigencia = new DateTimePicker();
            lblInicioVigencia = new Label();
            lblFimVigencia = new Label();
            lblTitulo = new Label();
            txtValor = new TextBox();
            lblValor = new Label();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // dtpInicioVigencia
            // 
            dtpInicioVigencia.Location = new Point(12, 79);
            dtpInicioVigencia.Name = "dtpInicioVigencia";
            dtpInicioVigencia.Size = new Size(260, 23);
            dtpInicioVigencia.TabIndex = 0;
            // 
            // dtpFimVigencia
            // 
            dtpFimVigencia.Location = new Point(12, 146);
            dtpFimVigencia.Name = "dtpFimVigencia";
            dtpFimVigencia.Size = new Size(260, 23);
            dtpFimVigencia.TabIndex = 1;
            // 
            // lblInicioVigencia
            // 
            lblInicioVigencia.AutoSize = true;
            lblInicioVigencia.Location = new Point(12, 61);
            lblInicioVigencia.Name = "lblInicioVigencia";
            lblInicioVigencia.Size = new Size(99, 15);
            lblInicioVigencia.TabIndex = 2;
            lblInicioVigencia.Text = "Início da vigência";
            // 
            // lblFimVigencia
            // 
            lblFimVigencia.AutoSize = true;
            lblFimVigencia.Location = new Point(12, 128);
            lblFimVigencia.Name = "lblFimVigencia";
            lblFimVigencia.Size = new Size(90, 15);
            lblFimVigencia.TabIndex = 3;
            lblFimVigencia.Text = "Fim da vigência";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(62, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(156, 21);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "ALTERAR VIGÊNCIA";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(12, 209);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(260, 23);
            txtValor.TabIndex = 5;
            txtValor.TextChanged += txtValor_TextChanged;
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(12, 191);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(97, 258);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(93, 33);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FormAlterarVigenciaPreco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 303);
            Controls.Add(btnConfirmar);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(lblTitulo);
            Controls.Add(lblFimVigencia);
            Controls.Add(lblInicioVigencia);
            Controls.Add(dtpFimVigencia);
            Controls.Add(dtpInicioVigencia);
            Name = "FormAlterarVigenciaPreco";
            Text = "FormAlterarVigenciaPreco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpInicioVigencia;
        private DateTimePicker dtpFimVigencia;
        private Label lblInicioVigencia;
        private Label lblFimVigencia;
        private Label lblTitulo;
        private TextBox txtValor;
        private Label lblValor;
        private Button btnConfirmar;
    }
}