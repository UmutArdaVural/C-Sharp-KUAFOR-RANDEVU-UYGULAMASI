namespace C__PROJE_BAŞLANGIÇ
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            doğrulamakodu = new Label();
            button2 = new Button();
            doğrulamalbl = new Label();
            button7 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 28);
            label1.Name = "label1";
            label1.Size = new Size(605, 72);
            label1.TabIndex = 0;
            label1.Text = "YÖNETİCİ  GİRİŞİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(274, 159);
            label2.Name = "label2";
            label2.Size = new Size(261, 53);
            label2.TabIndex = 1;
            label2.Text = "KULANICI ADI :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(705, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(705, 265);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(274, 238);
            label3.Name = "label3";
            label3.Size = new Size(143, 53);
            label3.TabIndex = 3;
            label3.Text = "ŞİFRE : ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(459, 460);
            button1.Name = "button1";
            button1.Size = new Size(300, 118);
            button1.TabIndex = 5;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(705, 350);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 23);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(274, 323);
            label4.Name = "label4";
            label4.Size = new Size(360, 53);
            label4.TabIndex = 6;
            label4.Text = "DOĞRULAMA KODU : ";
            // 
            // doğrulamakodu
            // 
            doğrulamakodu.AutoSize = true;
            doğrulamakodu.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            doğrulamakodu.Location = new Point(274, 359);
            doğrulamakodu.Name = "doğrulamakodu";
            doğrulamakodu.Size = new Size(0, 23);
            doğrulamakodu.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(21, 28);
            button2.Name = "button2";
            button2.Size = new Size(95, 31);
            button2.TabIndex = 9;
            button2.Text = "Geri Dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // doğrulamalbl
            // 
            doğrulamalbl.AutoSize = true;
            doğrulamalbl.Location = new Point(625, 353);
            doğrulamalbl.Name = "doğrulamalbl";
            doğrulamalbl.Size = new Size(38, 15);
            doğrulamalbl.TabIndex = 10;
            doğrulamalbl.Text = "label5";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(21, 92);
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
            label5.Location = new Point(513, 429);
            label5.Name = "label5";
            label5.Size = new Size(198, 28);
            label5.TabIndex = 23;
            label5.Text = "şifre ve kul adı : yönetici";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1220, 708);
            Controls.Add(label5);
            Controls.Add(button7);
            Controls.Add(doğrulamalbl);
            Controls.Add(button2);
            Controls.Add(doğrulamakodu);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private TextBox textBox3;
        private Label label4;
        private Label doğrulamakodu;
        private Button button2;
        private Label doğrulamalbl;
        private Button button7;
        private Label label5;
    }
}