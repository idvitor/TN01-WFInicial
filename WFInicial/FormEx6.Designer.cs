namespace WFInicial
{
    partial class FormEx6
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
            txtnome = new TextBox();
            txtvalorhora = new TextBox();
            txtquanthoras = new TextBox();
            lblnome1 = new Label();
            lblsalario1 = new Label();
            lblhoras1 = new Label();
            btnTotal = new Button();
            SuspendLayout();
            // 
            // txtnome
            // 
            txtnome.Location = new Point(121, 45);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 0;
            txtnome.TextChanged += textBox1_TextChanged;
            // 
            // txtvalorhora
            // 
            txtvalorhora.Location = new Point(121, 90);
            txtvalorhora.Name = "txtvalorhora";
            txtvalorhora.Size = new Size(100, 23);
            txtvalorhora.TabIndex = 1;
            // 
            // txtquanthoras
            // 
            txtquanthoras.Location = new Point(121, 137);
            txtquanthoras.Name = "txtquanthoras";
            txtquanthoras.Size = new Size(100, 23);
            txtquanthoras.TabIndex = 2;
            // 
            // lblnome1
            // 
            lblnome1.AutoSize = true;
            lblnome1.Location = new Point(41, 45);
            lblnome1.Name = "lblnome1";
            lblnome1.Size = new Size(43, 15);
            lblnome1.TabIndex = 3;
            lblnome1.Text = "Nome:";
            // 
            // lblsalario1
            // 
            lblsalario1.AutoSize = true;
            lblsalario1.Location = new Point(22, 93);
            lblsalario1.Name = "lblsalario1";
            lblsalario1.Size = new Size(83, 15);
            lblsalario1.TabIndex = 4;
            lblsalario1.Text = "Quanto ganha";
            // 
            // lblhoras1
            // 
            lblhoras1.AutoSize = true;
            lblhoras1.Location = new Point(12, 140);
            lblhoras1.Name = "lblhoras1";
            lblhoras1.Size = new Size(103, 15);
            lblhoras1.TabIndex = 5;
            lblhoras1.Text = "Horas Trabalhadas";
            lblhoras1.Click += label3_Click;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(121, 220);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(100, 23);
            btnTotal.TabIndex = 6;
            btnTotal.Text = "Total de Renda Mes";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 336);
            Controls.Add(btnTotal);
            Controls.Add(lblhoras1);
            Controls.Add(lblsalario1);
            Controls.Add(lblnome1);
            Controls.Add(txtquanthoras);
            Controls.Add(txtvalorhora);
            Controls.Add(txtnome);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnome;
        private TextBox txtvalorhora;
        private TextBox txtquanthoras;
        private Label lblnome1;
        private Label lblsalario1;
        private Label lblhoras1;
        private Button btnTotal;
    }
}