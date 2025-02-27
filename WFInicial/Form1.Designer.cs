namespace WFInicial
{
    partial class Form1
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
            LBLnota1 = new Label();
            txtnota1 = new TextBox();
            btnCalcular = new Button();
            txtnota2 = new TextBox();
            LBLnota2 = new Label();
            SuspendLayout();
            // 
            // LBLnota1
            // 
            LBLnota1.AutoSize = true;
            LBLnota1.ForeColor = SystemColors.Highlight;
            LBLnota1.Location = new Point(12, 24);
            LBLnota1.Name = "LBLnota1";
            LBLnota1.Size = new Size(45, 15);
            LBLnota1.TabIndex = 0;
            LBLnota1.Text = "Nota 1:";
            // 
            // txtnota1
            // 
            txtnota1.Location = new Point(63, 24);
            txtnota1.Name = "txtnota1";
            txtnota1.Size = new Size(100, 23);
            txtnota1.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcular.Location = new Point(52, 112);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(111, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular media";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtnota2
            // 
            txtnota2.Location = new Point(63, 64);
            txtnota2.Name = "txtnota2";
            txtnota2.Size = new Size(100, 23);
            txtnota2.TabIndex = 3;
            // 
            // LBLnota2
            // 
            LBLnota2.AccessibleRole = AccessibleRole.MenuItem;
            LBLnota2.AutoSize = true;
            LBLnota2.ForeColor = SystemColors.Highlight;
            LBLnota2.Location = new Point(12, 64);
            LBLnota2.Name = "LBLnota2";
            LBLnota2.Size = new Size(45, 15);
            LBLnota2.TabIndex = 4;
            LBLnota2.Text = "Nota 2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 287);
            Controls.Add(LBLnota2);
            Controls.Add(txtnota2);
            Controls.Add(btnCalcular);
            Controls.Add(txtnota1);
            Controls.Add(LBLnota1);
            Name = "Form1";
            Text = "Calcular media das notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLnota1;
        private TextBox txtnota1;
        private Button btnCalcular;
        private TextBox txtnota2;
        private Label LBLnota2;
    }
}
