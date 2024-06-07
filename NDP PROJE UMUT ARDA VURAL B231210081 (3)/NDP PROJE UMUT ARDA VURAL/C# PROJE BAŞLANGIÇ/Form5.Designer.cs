namespace C__PROJE_BAŞLANGIÇ
{
    partial class Form5
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(414, 120);
            label1.Name = "label1";
            label1.Size = new Size(480, 65);
            label1.TabIndex = 0;
            label1.Text = "ÇALIŞAN İŞLEMLERİ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(120, 286);
            button1.Name = "button1";
            button1.Size = new Size(174, 95);
            button1.TabIndex = 1;
            button1.Text = "ÇALIŞANLARI GÖRÜNTÜLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(446, 286);
            button2.Name = "button2";
            button2.Size = new Size(174, 95);
            button2.TabIndex = 2;
            button2.Text = "ÇALIŞAN EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(749, 286);
            button3.Name = "button3";
            button3.Size = new Size(174, 95);
            button3.TabIndex = 3;
            button3.Text = "ÇALIŞAN SİL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(37, 28);
            button4.Name = "button4";
            button4.Size = new Size(95, 33);
            button4.TabIndex = 20;
            button4.Text = "Geri Dön";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(37, 94);
            button7.Name = "button7";
            button7.Size = new Size(95, 50);
            button7.TabIndex = 22;
            button7.Text = "Uygulamadan çık";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(1011, 286);
            button5.Name = "button5";
            button5.Size = new Size(174, 95);
            button5.TabIndex = 23;
            button5.Text = "ÇALIŞANLARI DÜZENLE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1298, 639);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button7;
        private Button button5;
    }
}