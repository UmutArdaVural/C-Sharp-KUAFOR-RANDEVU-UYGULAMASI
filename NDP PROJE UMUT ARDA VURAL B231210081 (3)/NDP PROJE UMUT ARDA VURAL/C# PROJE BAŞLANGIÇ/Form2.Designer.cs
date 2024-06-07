namespace C__PROJE_BAŞLANGIÇ
{
    partial class Form2
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
            doğrulamakolbl = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button7 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // doğrulamakolbl
            // 
            doğrulamakolbl.AutoSize = true;
            doğrulamakolbl.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            doğrulamakolbl.ForeColor = SystemColors.Control;
            doğrulamakolbl.Location = new Point(696, 352);
            doğrulamakolbl.Name = "doğrulamakolbl";
            doğrulamakolbl.Size = new Size(0, 35);
            doğrulamakolbl.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(757, 352);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 23);
            textBox3.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(397, 340);
            label4.Name = "label4";
            label4.Size = new Size(310, 47);
            label4.TabIndex = 15;
            label4.Text = "DOĞRULAMA KODU : ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(558, 452);
            button1.Name = "button1";
            button1.Size = new Size(245, 110);
            button1.TabIndex = 14;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(757, 273);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(397, 251);
            label3.Name = "label3";
            label3.Size = new Size(122, 47);
            label3.TabIndex = 12;
            label3.Text = "ŞİFRE : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(757, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Sitka Banner", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(397, 180);
            label2.Name = "label2";
            label2.Size = new Size(242, 47);
            label2.TabIndex = 10;
            label2.Text = "KULLANICI ADI :";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(353, 40);
            label1.Name = "label1";
            label1.Size = new Size(577, 74);
            label1.TabIndex = 9;
            label1.Text = "ÇALIŞAN  GİRİŞİ";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 22);
            button2.Name = "button2";
            button2.Size = new Size(100, 42);
            button2.TabIndex = 18;
            button2.Text = "Geri Dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(17, 89);
            button7.Name = "button7";
            button7.Size = new Size(95, 50);
            button7.TabIndex = 22;
            button7.Text = "Uygulamadan çık";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(571, 421);
            label5.Name = "label5";
            label5.Size = new Size(192, 28);
            label5.TabIndex = 24;
            label5.Text = "şifre ve kul adı : calısan";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1281, 722);
            Controls.Add(label5);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(doğrulamakolbl);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label doğrulamakolbl;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button7;
        private Label label5;
    }
}