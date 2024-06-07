namespace C__PROJE_BAŞLANGIÇ
{
    partial class calışanlarıgörüntüle
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
            label1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            button7 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(47, 36);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "Geri Dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(537, 54);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 22;
            label1.Text = "ÇALIŞANLAR";
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.SnapToGrid;
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.AutoArrange = false;
            listView1.BackColor = SystemColors.Info;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader8, columnHeader4, columnHeader5, columnHeader7, columnHeader9 });
            listView1.GridLines = true;
            listView1.LabelEdit = true;
            listView1.Location = new Point(47, 110);
            listView1.Name = "listView1";
            listView1.RightToLeft = RightToLeft.Yes;
            listView1.Size = new Size(1178, 699);
            listView1.TabIndex = 21;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "İSİM";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "SOYİSİM";
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "İŞE GİRİŞ TARİHİ";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "GÜNLÜK ÇALIŞMA SAATİ";
            columnHeader8.TextAlign = HorizontalAlignment.Right;
            columnHeader8.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "KİMLİKNO";
            columnHeader4.TextAlign = HorizontalAlignment.Right;
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "TELEFON NO ";
            columnHeader5.TextAlign = HorizontalAlignment.Right;
            columnHeader5.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "TATİL HAKKI";
            columnHeader7.TextAlign = HorizontalAlignment.Right;
            columnHeader7.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "MAAŞ";
            columnHeader9.TextAlign = HorizontalAlignment.Right;
            columnHeader9.Width = 150;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(160, 36);
            button7.Name = "button7";
            button7.Size = new Size(95, 50);
            button7.TabIndex = 26;
            button7.Text = "Uygulamadan çık";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // calışanlarıgörüntüle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 855);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "calışanlarıgörüntüle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "calışanlarıgörüntüle";
            Load += calışanlarıgörüntüle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader9;
        private Button button7;
    }
}