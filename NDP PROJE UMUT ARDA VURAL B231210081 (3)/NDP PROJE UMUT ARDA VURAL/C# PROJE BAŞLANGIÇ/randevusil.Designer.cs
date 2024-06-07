namespace C__PROJE_BAŞLANGIÇ
{
    partial class randevusil
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
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 23);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 28;
            button1.Text = "Geri Dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(363, 23);
            label2.Name = "label2";
            label2.Size = new Size(317, 50);
            label2.TabIndex = 27;
            label2.Text = "RANDEVU SİLME";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(310, 128);
            label1.Name = "label1";
            label1.Size = new Size(288, 37);
            label1.TabIndex = 29;
            label1.Text = "Randevu Numarası  : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(621, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 30;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(621, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 23);
            textBox2.TabIndex = 32;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(310, 209);
            label3.Name = "label3";
            label3.Size = new Size(77, 37);
            label3.TabIndex = 31;
            label3.Text = "AD : ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(621, 310);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 23);
            textBox3.TabIndex = 34;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(310, 295);
            label4.Name = "label4";
            label4.Size = new Size(128, 37);
            label4.TabIndex = 33;
            label4.Text = "SOYAD : ";
            // 
            // button2
            // 
            button2.Location = new Point(433, 381);
            button2.Name = "button2";
            button2.Size = new Size(195, 98);
            button2.TabIndex = 37;
            button2.Text = "Randevuyu Sil ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(14, 62);
            button7.Name = "button7";
            button7.Size = new Size(95, 50);
            button7.TabIndex = 38;
            button7.Text = "Uygulamadan çık";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // randevusil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1086, 541);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "randevusil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "randevusil";
            Load += randevusil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button2;
        private Button button7;
    }
}