﻿namespace trabalho
{
    partial class FormPrincipal
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnConsulta = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button1.Location = new Point(25, 12);
            button1.Name = "button1";
            button1.Size = new Size(182, 66);
            button1.TabIndex = 0;
            button1.Text = "CADASTRO DE CLIENTE ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button2.Location = new Point(25, 99);
            button2.Name = "button2";
            button2.Size = new Size(182, 66);
            button2.TabIndex = 1;
            button2.Text = "CADASTRO DE PRODUTO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button3.Location = new Point(25, 187);
            button3.Name = "button3";
            button3.Size = new Size(182, 66);
            button3.TabIndex = 2;
            button3.Text = "CADASTRO DE PEDIDOS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button4.Location = new Point(25, 278);
            button4.Name = "button4";
            button4.Size = new Size(182, 66);
            button4.TabIndex = 3;
            button4.Text = "CADASTRO DE USUÁRIO";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnConsulta.Location = new Point(25, 361);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(182, 66);
            btnConsulta.TabIndex = 4;
            btnConsulta.Text = "CONSULTA DE PEDIDOS";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 439);
            Controls.Add(btnConsulta);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnConsulta;
    }
}