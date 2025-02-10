namespace Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtKetQua = new TextBox();
            button1 = new Button();
            btnTru = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 71);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Số a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 117);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Số b";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 164);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // txtA
            // 
            txtA.Location = new Point(227, 64);
            txtA.Name = "txtA";
            txtA.Size = new Size(209, 27);
            txtA.TabIndex = 3;
            // 
            // txtB
            // 
            txtB.Location = new Point(227, 117);
            txtB.Name = "txtB";
            txtB.Size = new Size(209, 27);
            txtB.TabIndex = 4;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(227, 164);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(209, 27);
            txtKetQua.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(342, 225);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Cộng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(227, 225);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(94, 29);
            btnTru.TabIndex = 7;
            btnTru.Text = "Trừ";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTru);
            Controls.Add(button1);
            Controls.Add(txtKetQua);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tính Toán";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKetQua;
        private Button button1;
        private Button btnTru;
    }
}
