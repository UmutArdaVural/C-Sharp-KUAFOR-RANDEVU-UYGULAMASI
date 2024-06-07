namespace C__PROJE_BAŞLANGIÇ
{
    partial class Form6
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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(562, 267);
            button2.Name = "button2";
            button2.Size = new Size(279, 156);
            button2.TabIndex = 6;
            button2.Text = "Randevu Bölümü";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(195, 267);
            button1.Name = "button1";
            button1.Size = new Size(279, 156);
            button1.TabIndex = 5;
            button1.Text = "ÇALIŞAN BÖLÜMÜ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(274, 123);
            label1.Name = "label1";
            label1.Size = new Size(489, 50);
            label1.TabIndex = 4;
            label1.Text = "YAPILCAK İŞLEM BÖLÜMÜ ";
            // 
            // button3
            // 
            button3.Location = new Point(28, 31);
            button3.Name = "button3";
            button3.Size = new Size(95, 29);
            button3.TabIndex = 21;
            button3.Text = "Geri Dön";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(28, 85);
            button7.Name = "button7";
            button7.Size = new Size(95, 50);
            button7.TabIndex = 23;
            button7.Text = "Uygulamadan çık";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1052, 636);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button3;
        private Button button7;
    }
}