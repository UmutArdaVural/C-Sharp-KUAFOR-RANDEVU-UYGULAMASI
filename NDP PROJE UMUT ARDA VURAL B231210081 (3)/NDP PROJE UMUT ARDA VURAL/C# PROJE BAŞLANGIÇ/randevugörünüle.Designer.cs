namespace C__PROJE_BAŞLANGIÇ
{
    partial class randevugörünüle
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            label1 = new Label();
            button2 = new Button();
            button7 = new Button();
            SuspendLayout();
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
            listView1.Location = new Point(24, 77);
            listView1.Name = "listView1";
            listView1.RightToLeft = RightToLeft.Yes;
            listView1.Size = new Size(1277, 642);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Randevu Numarası";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "AD";
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "SOYAD";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "GÜZELLİK UZMANI";
            columnHeader8.TextAlign = HorizontalAlignment.Right;
            columnHeader8.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "İŞLEM";
            columnHeader4.TextAlign = HorizontalAlignment.Right;
            columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ÜCRET";
            columnHeader5.TextAlign = HorizontalAlignment.Right;
            columnHeader5.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "TARİH";
            columnHeader7.TextAlign = HorizontalAlignment.Right;
            columnHeader7.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "İLETİŞİM BİLGİLERİ ";
            columnHeader9.TextAlign = HorizontalAlignment.Right;
            columnHeader9.Width = 150;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(521, 28);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 1;
            label1.Text = "RANDEVULAR ";
            // 
            // button2
            // 
            button2.Location = new Point(24, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 20;
            button2.Text = "Geri Dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(125, 12);
            button7.Name = "button7";
            button7.Size = new Size(95, 50);
            button7.TabIndex = 23;
            button7.Text = "Uygulamadan çık";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // randevugörünüle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1325, 731);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "randevugörünüle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "randevugörünüle";
            Load += randevugörünüle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private Label label1;
        private ColumnHeader columnHeader8;
        private Button button2;
        private ColumnHeader columnHeader9;
        private Button button7;
    }
}