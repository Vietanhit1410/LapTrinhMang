namespace User1
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
            button4 = new Button();
            button3 = new Button();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(426, 423);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 22;
            button4.Text = "Hủy";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(292, 423);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 21;
            button3.Text = "Đóng góp";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 275);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 20;
            label3.Text = "Đóng góp của bạn";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(224, 295);
            richTextBox2.Margin = new Padding(3, 0, 3, 3);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(368, 120);
            richTextBox2.TabIndex = 19;
            richTextBox2.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 268);
            textBox2.Margin = new Padding(0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(368, 27);
            textBox2.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(224, 209);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 17;
            button2.Text = "Đóng góp";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(224, 83);
            richTextBox1.Margin = new Padding(3, 0, 3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(368, 120);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(654, 56);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 15;
            button1.Text = "Tra cứu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 56);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 27);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 59);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 13;
            label2.Text = "Nhập từ cần tra cứu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 28);
            label1.TabIndex = 12;
            label1.Text = "Bảng tra cứu từ điển tiếng việt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(richTextBox2);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Label label3;
        private RichTextBox richTextBox2;
        private TextBox textBox2;
        private Button button2;
        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}
