namespace WFInicial
{
    partial class FormEx2
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
            lblDiaSemana = new Label();
            txtDiaSemana = new TextBox();
            btnEscolher = new Button();
            SuspendLayout();
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.ForeColor = SystemColors.Desktop;
            lblDiaSemana.Location = new Point(31, 34);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(85, 15);
            lblDiaSemana.TabIndex = 0;
            lblDiaSemana.Text = "Dia da Semana";
            // 
            // txtDiaSemana
            // 
            txtDiaSemana.ForeColor = SystemColors.MenuText;
            txtDiaSemana.Location = new Point(133, 31);
            txtDiaSemana.Name = "txtDiaSemana";
            txtDiaSemana.Size = new Size(100, 23);
            txtDiaSemana.TabIndex = 1;
            // 
            // btnEscolher
            // 
            btnEscolher.Location = new Point(266, 30);
            btnEscolher.Name = "btnEscolher";
            btnEscolher.Size = new Size(75, 23);
            btnEscolher.TabIndex = 2;
            btnEscolher.Text = "Escolher";
            btnEscolher.UseVisualStyleBackColor = true;
            btnEscolher.Click += btnEscolher_Click;
            // 
            // FormEx2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(589, 418);
            Controls.Add(btnEscolher);
            Controls.Add(txtDiaSemana);
            Controls.Add(lblDiaSemana);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormEx2";
            Text = "FormEx2";
            TransparencyKey = Color.Snow;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDiaSemana;
        private TextBox txtDiaSemana;
        private Button btnEscolher;
    }
}