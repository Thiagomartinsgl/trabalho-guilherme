namespace trabalho
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txbUsu = new TextBox();
            btnEntrar = new Button();
            txbSen = new TextBox();
            SuspendLayout();
            // 
            // txbUsu
            // 
            txbUsu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbUsu.Location = new Point(12, 28);
            txbUsu.Name = "txbUsu";
            txbUsu.Size = new Size(348, 29);
            txbUsu.TabIndex = 0;
            txbUsu.Text = "USUÁRIO";
            txbUsu.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(114, 146);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(139, 60);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // txbSen
            // 
            txbSen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSen.Location = new Point(12, 81);
            txbSen.Name = "txbSen";
            txbSen.Size = new Size(348, 29);
            txbSen.TabIndex = 2;
            txbSen.Text = "SENHA";
            txbSen.TextAlign = HorizontalAlignment.Center;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 225);
            Controls.Add(txbSen);
            Controls.Add(btnEntrar);
            Controls.Add(txbUsu);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbUsu;
        private Button btnEntrar;
        private TextBox txbSen;
    }
}
