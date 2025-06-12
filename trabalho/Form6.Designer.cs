namespace trabalho
{
    partial class FormCadastroPedidos
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
            txbCPF = new TextBox();
            txbNome = new TextBox();
            label2 = new Label();
            txbTotal = new TextBox();
            txbValor = new TextBox();
            cbxProduto = new ComboBox();
            txbQuantidade = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSalvar = new Button();
            btnExcluir = new Button();
            lbProdutos = new ListBox();
            button1 = new Button();
            txbDescricao = new TextBox();
            label7 = new Label();
            btnFinalizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 21);
            label1.TabIndex = 0;
            label1.Text = "CPF";
            // 
            // txbCPF
            // 
            txbCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbCPF.Location = new Point(12, 33);
            txbCPF.Name = "txbCPF";
            txbCPF.Size = new Size(233, 29);
            txbCPF.TabIndex = 1;
            // 
            // txbNome
            // 
            txbNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbNome.Location = new Point(12, 151);
            txbNome.Name = "txbNome";
            txbNome.ReadOnly = true;
            txbNome.Size = new Size(233, 29);
            txbNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 2;
            label2.Text = "NOME";
            // 
            // txbTotal
            // 
            txbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTotal.Location = new Point(12, 475);
            txbTotal.Name = "txbTotal";
            txbTotal.ReadOnly = true;
            txbTotal.Size = new Size(233, 29);
            txbTotal.TabIndex = 4;
            // 
            // txbValor
            // 
            txbValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbValor.Location = new Point(12, 412);
            txbValor.Name = "txbValor";
            txbValor.ReadOnly = true;
            txbValor.Size = new Size(233, 29);
            txbValor.TabIndex = 5;
            // 
            // cbxProduto
            // 
            cbxProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxProduto.FormattingEnabled = true;
            cbxProduto.Location = new Point(12, 275);
            cbxProduto.Name = "cbxProduto";
            cbxProduto.Size = new Size(233, 29);
            cbxProduto.TabIndex = 6;
            cbxProduto.SelectedIndexChanged += cbxProduto_SelectedIndexChanged;
            // 
            // txbQuantidade
            // 
            txbQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbQuantidade.Location = new Point(12, 345);
            txbQuantidade.Name = "txbQuantidade";
            txbQuantidade.Size = new Size(233, 29);
            txbQuantidade.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 321);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 7;
            label3.Text = "QUANTIDADE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 251);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 9;
            label4.Text = "PRODUTOS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 451);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 10;
            label5.Text = "TOTAL PEDIDO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 388);
            label6.Name = "label6";
            label6.Size = new Size(141, 21);
            label6.TabIndex = 11;
            label6.Text = "VALOR UNITÁRIO";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(12, 670);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(116, 52);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(129, 670);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(116, 52);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lbProdutos
            // 
            lbProdutos.FormattingEnabled = true;
            lbProdutos.ItemHeight = 15;
            lbProdutos.Location = new Point(12, 510);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(233, 154);
            lbProdutos.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 77);
            button1.Name = "button1";
            button1.Size = new Size(233, 44);
            button1.TabIndex = 16;
            button1.Text = "BUSCAR CLIENTE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txbDescricao
            // 
            txbDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDescricao.Location = new Point(12, 219);
            txbDescricao.Name = "txbDescricao";
            txbDescricao.Size = new Size(233, 29);
            txbDescricao.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 195);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 17;
            label7.Text = "DESCRIÇÃO";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.Location = new Point(12, 737);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(233, 44);
            btnFinalizar.TabIndex = 19;
            btnFinalizar.Text = "FINALIZAR PEDIDO";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // FormCadastroPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 790);
            Controls.Add(btnFinalizar);
            Controls.Add(txbDescricao);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(lbProdutos);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txbQuantidade);
            Controls.Add(label3);
            Controls.Add(cbxProduto);
            Controls.Add(txbValor);
            Controls.Add(txbTotal);
            Controls.Add(txbNome);
            Controls.Add(label2);
            Controls.Add(txbCPF);
            Controls.Add(label1);
            Name = "FormCadastroPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Pedidos";
            Load += FormCadastroPedidos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbCPF;
        private TextBox txbNome;
        private Label label2;
        private TextBox txbTotal;
        private TextBox txbValor;
        private ComboBox cbxProduto;
        private TextBox txbQuantidade;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSalvar;
        private Button btnExcluir;
        private ListBox lbProdutos;
        private Button button1;
        private TextBox txbDescricao;
        private Label label7;
        private Button btnFinalizar;
    }
}