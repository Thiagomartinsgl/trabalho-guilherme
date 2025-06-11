namespace trabalho
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
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(288, 517);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(135, 57);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 4;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 5;
            label2.Text = "Senha:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 517);
            button2.Name = "button2";
            button2.Size = new Size(135, 57);
            button2.TabIndex = 6;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 182);
            button3.Name = "button3";
            button3.Size = new Size(135, 57);
            button3.TabIndex = 7;
            button3.Text = "CADASTRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(288, 182);
            button4.Name = "button4";
            button4.Size = new Size(135, 57);
            button4.TabIndex = 8;
            button4.Text = "EXCLUIR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormCadastroU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 586);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}