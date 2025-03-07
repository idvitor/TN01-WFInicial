namespace WFInicial
{
    partial class FormEx8
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
            lblnumero1 = new Label();
            txtnumero1 = new TextBox();
            txtnumero2 = new TextBox();
            lblnumero2 = new Label();
            gbxOperacao = new GroupBox();
            rdbdivisao = new RadioButton();
            rdbpotenciacao = new RadioButton();
            rdbradiciacao = new RadioButton();
            rdbmultiplicacao = new RadioButton();
            rdbSoma = new RadioButton();
            rdbSubtracao = new RadioButton();
            btncalcular = new Button();
            gbxOperacao.SuspendLayout();
            SuspendLayout();
            // 
            // lblnumero1
            // 
            lblnumero1.AutoSize = true;
            lblnumero1.Location = new Point(24, 22);
            lblnumero1.Name = "lblnumero1";
            lblnumero1.Size = new Size(58, 15);
            lblnumero1.TabIndex = 0;
            lblnumero1.Text = "numero 1";
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(12, 51);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 23);
            txtnumero1.TabIndex = 1;
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(12, 129);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(100, 23);
            txtnumero2.TabIndex = 3;
            // 
            // lblnumero2
            // 
            lblnumero2.AutoSize = true;
            lblnumero2.Location = new Point(24, 93);
            lblnumero2.Name = "lblnumero2";
            lblnumero2.Size = new Size(58, 15);
            lblnumero2.TabIndex = 2;
            lblnumero2.Text = "numero 2";
         
            // 
            // gbxOperacao
            // 
            gbxOperacao.Controls.Add(rdbdivisao);
            gbxOperacao.Controls.Add(rdbpotenciacao);
            gbxOperacao.Controls.Add(rdbradiciacao);
            gbxOperacao.Controls.Add(rdbmultiplicacao);
            gbxOperacao.Controls.Add(rdbSoma);
            gbxOperacao.Controls.Add(rdbSubtracao);
            gbxOperacao.Location = new Point(158, 22);
            gbxOperacao.Name = "gbxOperacao";
            gbxOperacao.Size = new Size(200, 186);
            gbxOperacao.TabIndex = 4;
            gbxOperacao.TabStop = false;
            gbxOperacao.Text = "Operação";
            gbxOperacao.Enter += groupBox1_Enter;
            // 
            // rdbdivisao
            // 
            rdbdivisao.AutoSize = true;
            rdbdivisao.Location = new Point(50, 107);
            rdbdivisao.Name = "rdbdivisao";
            rdbdivisao.Size = new Size(63, 19);
            rdbdivisao.TabIndex = 8;
            rdbdivisao.TabStop = true;
            rdbdivisao.Text = "Divisão";
            rdbdivisao.UseVisualStyleBackColor = true;
            // 
            // rdbpotenciacao
            // 
            rdbpotenciacao.AutoSize = true;
            rdbpotenciacao.Location = new Point(50, 132);
            rdbpotenciacao.Name = "rdbpotenciacao";
            rdbpotenciacao.Size = new Size(90, 19);
            rdbpotenciacao.TabIndex = 9;
            rdbpotenciacao.TabStop = true;
            rdbpotenciacao.Text = "Potenciação";
            rdbpotenciacao.UseVisualStyleBackColor = true;
            // 
            // rdbradiciacao
            // 
            rdbradiciacao.AutoSize = true;
            rdbradiciacao.Location = new Point(50, 157);
            rdbradiciacao.Name = "rdbradiciacao";
            rdbradiciacao.Size = new Size(82, 19);
            rdbradiciacao.TabIndex = 10;
            rdbradiciacao.TabStop = true;
            rdbradiciacao.Text = "Radiciação";
            rdbradiciacao.UseVisualStyleBackColor = true;
            // 
            // rdbmultiplicacao
            // 
            rdbmultiplicacao.AutoSize = true;
            rdbmultiplicacao.Location = new Point(50, 82);
            rdbmultiplicacao.Name = "rdbmultiplicacao";
            rdbmultiplicacao.Size = new Size(97, 19);
            rdbmultiplicacao.TabIndex = 7;
            rdbmultiplicacao.TabStop = true;
            rdbmultiplicacao.Text = "Multiplicação";
            rdbmultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbSoma
            // 
            rdbSoma.AutoSize = true;
            rdbSoma.Location = new Point(50, 32);
            rdbSoma.Name = "rdbSoma";
            rdbSoma.Size = new Size(55, 19);
            rdbSoma.TabIndex = 5;
            rdbSoma.TabStop = true;
            rdbSoma.Text = "Soma";
            rdbSoma.UseVisualStyleBackColor = true;
            rdbSoma.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdbSubtracao
            // 
            rdbSubtracao.AutoSize = true;
            rdbSubtracao.Location = new Point(50, 57);
            rdbSubtracao.Name = "rdbSubtracao";
            rdbSubtracao.Size = new Size(78, 19);
            rdbSubtracao.TabIndex = 6;
            rdbSubtracao.TabStop = true;
            rdbSubtracao.Text = "Subtração";
            rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(24, 185);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 11;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // FormEx8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 239);
            Controls.Add(btncalcular);
            Controls.Add(gbxOperacao);
            Controls.Add(txtnumero2);
            Controls.Add(lblnumero2);
            Controls.Add(txtnumero1);
            Controls.Add(lblnumero1);
            Name = "FormEx8";
            Text = "FormEx8";
            gbxOperacao.ResumeLayout(false);
            gbxOperacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumero1;
        private TextBox txtnumero1;
        private TextBox txtnumero2;
        private Label lblnumero2;
        private GroupBox gbxOperacao;
        private RadioButton rdbSoma;
        private RadioButton rdbSubtracao;
        private RadioButton rdbmultiplicacao;
        private RadioButton rdbdivisao;
        private RadioButton rdbpotenciacao;
        private RadioButton rdbradiciacao;
        private Button btncalcular;
    }
}