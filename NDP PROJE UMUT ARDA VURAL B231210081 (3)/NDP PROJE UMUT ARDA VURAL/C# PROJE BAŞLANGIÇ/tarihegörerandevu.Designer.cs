namespace C__PROJE_BAŞLANGIÇ
{
    partial class tarihegörerandevu
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
            button1 = new Button();
            label2 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            button3 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(-187, -157);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "Geri Dön";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(310, -141);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 22;
            label1.Text = "RANDEVULAR ";
            // 
            // button1
            // 
            button1.Location = new Point(25, 28);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 26;
            button1.Text = "Geri Dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(454, 28);
            label2.Name = "label2";
            label2.Size = new Size(345, 32);
            label2.TabIndex = 25;
            label2.Text = "TARİHE GÖRE RANDEVULAR ";
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.Default;
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BackColor = SystemColors.Info;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader8, columnHeader4, columnHeader5, columnHeader7, columnHeader9 });
            listView1.GridLines = true;
            listView1.LabelEdit = true;
            listView1.Location = new Point(58, 397);
            listView1.Name = "listView1";
            listView1.RightToLeft = RightToLeft.Yes;
            listView1.Size = new Size(1226, 529);
            listView1.TabIndex = 24;
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
            columnHeader4.Width = 200;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePicker1.Location = new Point(668, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(308, 35);
            dateTimePicker1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(298, 147);
            label3.Name = "label3";
            label3.Size = new Size(292, 25);
            label3.TabIndex = 28;
            label3.Text = "Görmek istediğiniz tarigi giriniz";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(550, 257);
            button3.Name = "button3";
            button3.Size = new Size(208, 82);
            button3.TabIndex = 29;
            button3.Text = "Randevu Göster ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(25, 71);
            button7.Name = "button7";
            button7.Size = new Size(95, 50);
            button7.TabIndex = 30;
            button7.Text = "Uygulamadan çık";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // tarihegörerandevu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1309, 958);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "tarihegörerandevu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "tarihegörerandevu";
            Load += tarihegörerandevu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label1;
        private Button button1;
        private Label label2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader9;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button button3;
        private Button button7;
    }
}