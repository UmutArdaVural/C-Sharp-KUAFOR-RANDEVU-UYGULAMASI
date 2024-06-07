namespace C__PROJE_BAŞLANGIÇ
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
            button1 = new Button();
            button2 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 154);
            label1.Name = "label1";
            label1.Size = new Size(1026, 76);
            label1.TabIndex = 0;
            label1.Text = "Kuaför Randevu Uygulaması ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(338, 283);
            label2.Name = "label2";
            label2.Size = new Size(605, 57);
            label2.TabIndex = 1;
            label2.Text = "Hangi Kullanıcı Girişi ";
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(338, 438);
            button1.Name = "button1";
            button1.Size = new Size(278, 118);
            button1.TabIndex = 2;
            button1.Text = "Yönetici ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(780, 438);
            button2.Name = "button2";
            button2.Size = new Size(271, 118);
            button2.TabIndex = 3;
            button2.Text = "ÇALIŞAN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(12, 22);
            button7.Name = "button7";
            button7.Size = new Size(95, 50);
            button7.TabIndex = 22;
            button7.Text = "Uygulamadan çık";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1339, 758);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button7;
    }
}
