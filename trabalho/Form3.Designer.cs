﻿namespace trabalho
{
    partial class FormCadastroU
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
            btnSalvar = new Button();
            txbUsuario = new TextBox();
            dgvUsuario = new DataGridView();
            txbSenha = new TextBox();
            lblUsuario = new Label();
            lblSenha = new Label();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(151, 526);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(135, 57);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txbUsuario
            // 
            txbUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbUsuario.Location = new Point(12, 41);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(411, 29);
            txbUsuario.TabIndex = 1;
            // 
            // dgvUsuario
            // 
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(10, 275);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.Size = new Size(413, 235);
            dgvUsuario.TabIndex = 2;
            // 
            // txbSenha
            // 
            txbSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSenha.Location = new Point(12, 115);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(411, 29);
            txbSenha.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(12, 17);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(73, 21);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(12, 91);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(61, 21);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(12, 169);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(135, 57);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(288, 169);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(135, 57);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 251);
            label1.Name = "label1";
            label1.Size = new Size(309, 21);
            label1.TabIndex = 9;
            label1.Text = "Dê 2 cliques na sua senha para edita-la:";
            // 
            // FormCadastroU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 586);
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(txbSenha);
            Controls.Add(dgvUsuario);
            Controls.Add(txbUsuario);
            Controls.Add(btnSalvar);
            Name = "FormCadastroU";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Usuário";
            Load += FormCadastroU_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txbUsuario;
        private DataGridView dgvUsuario;
        private TextBox txbSenha;
        private Label lblUsuario;
        private Label lblSenha;
        private Button btnCadastrar;
        private Button btnExcluir;
        private Label label1;
    }
}