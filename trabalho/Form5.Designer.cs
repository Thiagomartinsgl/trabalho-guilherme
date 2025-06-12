namespace trabalho
{
    partial class FormCadastroP
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
            label1 = new Label();
            txbProduto = new TextBox();
            txbPreco = new TextBox();
            label2 = new Label();
            txbDes = new TextBox();
            label3 = new Label();
            dgvProdutos = new DataGridView();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 0;
            label1.Text = "PRODUTO";
            // 
            // txbProduto
            // 
            txbProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbProduto.Location = new Point(12, 33);
            txbProduto.Name = "txbProduto";
            txbProduto.Size = new Size(225, 29);
            txbProduto.TabIndex = 1;
            // 
            // txbPreco
            // 
            txbPreco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbPreco.Location = new Point(257, 33);
            txbPreco.Name = "txbPreco";
            txbPreco.Size = new Size(125, 29);
            txbPreco.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(257, 9);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 2;
            label2.Text = "PREÇO";
            // 
            // txbDes
            // 
            txbDes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDes.Location = new Point(405, 33);
            txbDes.Name = "txbDes";
            txbDes.Size = new Size(383, 29);
            txbDes.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(405, 9);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 4;
            label3.Text = "DESCRIÇÃO";
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(12, 81);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(776, 174);
            dgvProdutos.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCadastrar.Location = new Point(12, 273);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(118, 56);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "SALVAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.Location = new Point(324, 273);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(118, 56);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluir.Location = new Point(670, 273);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(118, 56);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormCadastroP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 341);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(dgvProdutos);
            Controls.Add(txbDes);
            Controls.Add(label3);
            Controls.Add(txbPreco);
            Controls.Add(label2);
            Controls.Add(txbProduto);
            Controls.Add(label1);
            Name = "FormCadastroP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Produtos";
            Load += FormCadastroP_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbProduto;
        private TextBox txbPreco;
        private Label label2;
        private TextBox txbDes;
        private Label label3;
        private DataGridView dgvProdutos;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}