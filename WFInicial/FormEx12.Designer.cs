﻿namespace WFInicial
{
    partial class FormEx12
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblContador = new Label();
            btnAdcionar = new Button();
            lblNumeros = new Label();
            lblPar = new Label();
            lblImpar = new Label();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(12, 26);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(86, 21);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(145, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(244, 24);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(13, 15);
            lblContador.TabIndex = 2;
            lblContador.Text = "0";
            // 
            // btnAdcionar
            // 
            btnAdcionar.Location = new Point(156, 84);
            btnAdcionar.Name = "btnAdcionar";
            btnAdcionar.Size = new Size(75, 23);
            btnAdcionar.TabIndex = 3;
            btnAdcionar.Text = "Adcionar";
            btnAdcionar.UseVisualStyleBackColor = true;
            btnAdcionar.Click += btnAdcionar_Click;
            // 
            // lblNumeros
            // 
            lblNumeros.BorderStyle = BorderStyle.Fixed3D;
            lblNumeros.Location = new Point(30, 142);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(201, 35);
            lblNumeros.TabIndex = 4;
            lblNumeros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPar
            // 
            lblPar.BorderStyle = BorderStyle.Fixed3D;
            lblPar.Location = new Point(30, 188);
            lblPar.Name = "lblPar";
            lblPar.Size = new Size(201, 32);
            lblPar.TabIndex = 5;
            lblPar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblImpar
            // 
            lblImpar.BorderStyle = BorderStyle.Fixed3D;
            lblImpar.Location = new Point(30, 234);
            lblImpar.Name = "lblImpar";
            lblImpar.Size = new Size(201, 37);
            lblImpar.TabIndex = 6;
            lblImpar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormEx12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 280);
            Controls.Add(lblImpar);
            Controls.Add(lblPar);
            Controls.Add(lblNumeros);
            Controls.Add(btnAdcionar);
            Controls.Add(lblContador);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "FormEx12";
            Text = "FormEx12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblContador;
        private Button btnAdcionar;
        private Label lblNumeros;
        private Label lblPar;
        private Label lblImpar;
    }
}