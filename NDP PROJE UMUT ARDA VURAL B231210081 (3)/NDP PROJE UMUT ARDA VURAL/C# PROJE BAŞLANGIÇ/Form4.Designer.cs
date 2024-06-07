namespace C__PROJE_BAŞLANGIÇ
{
    partial class Form4
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(130, 288);
            button1.Name = "button1";
            button1.Size = new Size(254, 110);
            button1.TabIndex = 0;
            button1.Text = "RANDEVU OLUŞTUR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(780, 491);
            button2.Name = "button2";
            button2.Size = new Size(261, 110);
            button2.TabIndex = 1;
            button2.Text = "RANDEVU GÖRÜNTÜLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(534, 288);
            button3.Name = "button3";
            button3.Size = new Size(261, 110);
            button3.TabIndex = 2;
            button3.Text = "RANDEVU DÜZENLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(294, 491);
            button4.Name = "button4";
            button4.Size = new Size(261, 110);
            button4.TabIndex = 3;
            button4.Text = "TARİHE GÖRE RANDEVU GÖRÜNTÜLE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(364, 117);
            label1.Name = "label1";
            label1.Size = new Size(676, 86);
            label1.TabIndex = 4;
            label1.Text = "RANDEVU İŞLEMLERİ";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(927, 288);
            button5.Name = "button5";
            button5.Size = new Size(261, 110);
            button5.TabIndex = 5;
            button5.Text = "RANDEVU SİL ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(37, 30);
            button6.Name = "button6";
            button6.Size = new Size(95, 23);
            button6.TabIndex = 20;
            button6.Text = "Geri Dön";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(37, 87);
            button7.Name = "button7";
            button7.Size = new Size(95, 50);
            button7.TabIndex = 21;
            button7.Text = "Uygulamadan çık";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1308, 702);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.AppWorkspace;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}