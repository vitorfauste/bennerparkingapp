namespace WFPresentationLayer
{
    partial class FormEntradaSaidaVeiculos
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
            gpbxListaCarros = new GroupBox();
            dgvGridCarros = new DataGridView();
            btnEntrada = new Button();
            lblEstacionamento = new Label();
            picboxLogo = new PictureBox();
            lblNomeEstacionamento = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            lblPesquisar = new Label();
            btnVigencia = new Button();
            lblDataHora = new Label();
            gpbxListaCarros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGridCarros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // gpbxListaCarros
            // 
            gpbxListaCarros.Controls.Add(dgvGridCarros);
            gpbxListaCarros.Location = new Point(12, 241);
            gpbxListaCarros.Name = "gpbxListaCarros";
            gpbxListaCarros.Size = new Size(693, 308);
            gpbxListaCarros.TabIndex = 0;
            gpbxListaCarros.TabStop = false;
            // 
            // dgvGridCarros
            // 
            dgvGridCarros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGridCarros.Location = new Point(6, 19);
            dgvGridCarros.Name = "dgvGridCarros";
            dgvGridCarros.ReadOnly = true;
            dgvGridCarros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGridCarros.Size = new Size(681, 283);
            dgvGridCarros.TabIndex = 0;
            // 
            // btnEntrada
            // 
            btnEntrada.AutoEllipsis = true;
            btnEntrada.BackColor = Color.Navy;
            btnEntrada.Font = new Font("Segoe UI", 12F);
            btnEntrada.ForeColor = SystemColors.ButtonFace;
            btnEntrada.Location = new Point(476, 42);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(223, 66);
            btnEntrada.TabIndex = 1;
            btnEntrada.Text = "REGISTRAR ENTRADA";
            btnEntrada.UseVisualStyleBackColor = false;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // lblEstacionamento
            // 
            lblEstacionamento.AutoSize = true;
            lblEstacionamento.Location = new Point(73, 9);
            lblEstacionamento.Name = "lblEstacionamento";
            lblEstacionamento.Size = new Size(92, 15);
            lblEstacionamento.TabIndex = 3;
            lblEstacionamento.Text = "Estacionamento\r\n";
            lblEstacionamento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picboxLogo
            // 
            picboxLogo.Image = Properties.Resources.image;
            picboxLogo.Location = new Point(-132, 42);
            picboxLogo.Name = "picboxLogo";
            picboxLogo.Size = new Size(521, 142);
            picboxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picboxLogo.TabIndex = 4;
            picboxLogo.TabStop = false;
            picboxLogo.WaitOnLoad = true;
            // 
            // lblNomeEstacionamento
            // 
            lblNomeEstacionamento.AutoSize = true;
            lblNomeEstacionamento.Font = new Font("Segoe UI", 15F);
            lblNomeEstacionamento.Location = new Point(35, 24);
            lblNomeEstacionamento.Name = "lblNomeEstacionamento";
            lblNomeEstacionamento.Size = new Size(196, 28);
            lblNomeEstacionamento.TabIndex = 5;
            lblNomeEstacionamento.Text = "Carro Bem Guardado";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(131, 212);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(194, 23);
            txtPesquisar.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(331, 212);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(18, 219);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(112, 15);
            lblPesquisar.TabIndex = 8;
            lblPesquisar.Text = "Pesquisar por placa:";
            // 
            // btnVigencia
            // 
            btnVigencia.AutoEllipsis = true;
            btnVigencia.BackColor = Color.DarkSlateGray;
            btnVigencia.Font = new Font("Segoe UI", 10F);
            btnVigencia.ForeColor = SystemColors.ButtonFace;
            btnVigencia.Location = new Point(476, 114);
            btnVigencia.Name = "btnVigencia";
            btnVigencia.Size = new Size(223, 31);
            btnVigencia.TabIndex = 9;
            btnVigencia.Text = "Alterar vigência";
            btnVigencia.UseVisualStyleBackColor = false;
            // 
            // lblDataHora
            // 
            lblDataHora.AutoSize = true;
            lblDataHora.Location = new Point(476, 169);
            lblDataHora.Name = "lblDataHora";
            lblDataHora.Size = new Size(0, 15);
            lblDataHora.TabIndex = 10;
            // 
            // FormEntradaSaidaVeiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 561);
            Controls.Add(lblDataHora);
            Controls.Add(btnVigencia);
            Controls.Add(lblPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblNomeEstacionamento);
            Controls.Add(lblEstacionamento);
            Controls.Add(btnEntrada);
            Controls.Add(gpbxListaCarros);
            Controls.Add(picboxLogo);
            Name = "FormEntradaSaidaVeiculos";
            Text = "FormEntradaSaidaVeiculos";
            gpbxListaCarros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGridCarros).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpbxListaCarros;
        private DataGridView dgvGridCarros;
        private Button btnEntrada;
        private Label lblEstacionamento;
        private PictureBox picboxLogo;
        private Label lblNomeEstacionamento;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Label lblPesquisar;
        private Button btnVigencia;
        private Label lblDataHora;
    }
}