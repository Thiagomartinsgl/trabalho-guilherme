namespace trabalho
{
    partial class FormConsultaPedidos
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
            lblNome = new Label();
            txbCPF = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ltvPedidos = new ListView();
            ltvItens = new ListView();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(12, 93);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(59, 21);
            lblNome.TabIndex = 6;
            lblNome.Text = "NOME";
            // 
            // txbCPF
            // 
            txbCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbCPF.Location = new Point(12, 40);
            txbCPF.Name = "txbCPF";
            txbCPF.Size = new Size(178, 29);
            txbCPF.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(38, 21);
            label1.TabIndex = 4;
            label1.Text = "CPF";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(219, 16);
            button1.Name = "button1";
            button1.Size = new Size(161, 53);
            button1.TabIndex = 10;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ltvPedidos
            // 
            ltvPedidos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ltvPedidos.Location = new Point(12, 138);
            ltvPedidos.Name = "ltvPedidos";
            ltvPedidos.Size = new Size(368, 151);
            ltvPedidos.TabIndex = 11;
            ltvPedidos.UseCompatibleStateImageBehavior = false;
            ltvPedidos.SelectedIndexChanged += ltvPedidos_SelectedIndexChanged;
            // 
            // ltvItens
            // 
            ltvItens.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ltvItens.Location = new Point(12, 295);
            ltvItens.Name = "ltvItens";
            ltvItens.Size = new Size(368, 151);
            ltvItens.TabIndex = 12;
            ltvItens.UseCompatibleStateImageBehavior = false;
            // 
            // FormConsultaPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 467);
            Controls.Add(ltvItens);
            Controls.Add(ltvPedidos);
            Controls.Add(button1);
            Controls.Add(lblNome);
            Controls.Add(txbCPF);
            Controls.Add(label1);
            Name = "FormConsultaPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Pedidos";
            Load += FormConsultaPedidos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbNome;
        private Label lblNome;
        private TextBox txbCPF;
        private Label label1;
        private Button button1;
        private ListView ltvPedidos;
        private ListView ltvItens;
    }
}