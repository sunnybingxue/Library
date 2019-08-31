namespace BookManageSystem
{
    partial class frmBookInfoAddOrUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lBookSortMark = new System.Windows.Forms.Label();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.cbBookSortID = new System.Windows.Forms.ComboBox();
            this.dtpBookResDate = new System.Windows.Forms.DateTimePicker();
            this.rtbBookSummary = new System.Windows.Forms.RichTextBox();
            this.tbLendNum = new System.Windows.Forms.TextBox();
            this.tbBookRealNum = new System.Windows.Forms.TextBox();
            this.tbBookPrice = new System.Windows.Forms.TextBox();
            this.tbBookPublish = new System.Windows.Forms.TextBox();
            this.tbBookAutor = new System.Windows.Forms.TextBox();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btEnter = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.formStatus1 = new BookManageSystem.FormStatus();
            this.lValidate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lValidate);
            this.groupBox1.Controls.Add(this.lBookSortMark);
            this.groupBox1.Controls.Add(this.dtpPublishDate);
            this.groupBox1.Controls.Add(this.cbBookSortID);
            this.groupBox1.Controls.Add(this.dtpBookResDate);
            this.groupBox1.Controls.Add(this.rtbBookSummary);
            this.groupBox1.Controls.Add(this.tbLendNum);
            this.groupBox1.Controls.Add(this.tbBookRealNum);
            this.groupBox1.Controls.Add(this.tbBookPrice);
            this.groupBox1.Controls.Add(this.tbBookPublish);
            this.groupBox1.Controls.Add(this.tbBookAutor);
            this.groupBox1.Controls.Add(this.tbBookID);
            this.groupBox1.Controls.Add(this.tbBookName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // lBookSortMark
            // 
            this.lBookSortMark.AutoSize = true;
            this.lBookSortMark.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lBookSortMark.ForeColor = System.Drawing.Color.Blue;
            this.lBookSortMark.Location = new System.Drawing.Point(351, 49);
            this.lBookSortMark.Name = "lBookSortMark";
            this.lBookSortMark.Size = new System.Drawing.Size(0, 11);
            this.lBookSortMark.TabIndex = 11;
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublishDate.Location = new System.Drawing.Point(79, 129);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(167, 21);
            this.dtpPublishDate.TabIndex = 5;
            // 
            // cbBookSortID
            // 
            this.cbBookSortID.FormattingEnabled = true;
            this.cbBookSortID.Location = new System.Drawing.Point(350, 26);
            this.cbBookSortID.Name = "cbBookSortID";
            this.cbBookSortID.Size = new System.Drawing.Size(169, 20);
            this.cbBookSortID.TabIndex = 1;
            this.cbBookSortID.TextChanged += new System.EventHandler(this.cbBookSortID_TextChanged);
            // 
            // dtpBookResDate
            // 
            this.dtpBookResDate.Enabled = false;
            this.dtpBookResDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookResDate.Location = new System.Drawing.Point(79, 304);
            this.dtpBookResDate.Name = "dtpBookResDate";
            this.dtpBookResDate.Size = new System.Drawing.Size(167, 21);
            this.dtpBookResDate.TabIndex = 10;
            this.dtpBookResDate.Value = new System.DateTime(2008, 12, 25, 0, 0, 0, 0);
            // 
            // rtbBookSummary
            // 
            this.rtbBookSummary.Location = new System.Drawing.Point(80, 209);
            this.rtbBookSummary.Name = "rtbBookSummary";
            this.rtbBookSummary.Size = new System.Drawing.Size(439, 82);
            this.rtbBookSummary.TabIndex = 9;
            this.rtbBookSummary.Text = "";
            // 
            // tbLendNum
            // 
            this.tbLendNum.Location = new System.Drawing.Point(322, 169);
            this.tbLendNum.Name = "tbLendNum";
            this.tbLendNum.Size = new System.Drawing.Size(197, 21);
            this.tbLendNum.TabIndex = 8;
            // 
            // tbBookRealNum
            // 
            this.tbBookRealNum.Location = new System.Drawing.Point(79, 169);
            this.tbBookRealNum.Name = "tbBookRealNum";
            this.tbBookRealNum.Size = new System.Drawing.Size(167, 21);
            this.tbBookRealNum.TabIndex = 7;
            // 
            // tbBookPrice
            // 
            this.tbBookPrice.Location = new System.Drawing.Point(322, 130);
            this.tbBookPrice.Name = "tbBookPrice";
            this.tbBookPrice.Size = new System.Drawing.Size(197, 21);
            this.tbBookPrice.TabIndex = 6;
            // 
            // tbBookPublish
            // 
            this.tbBookPublish.Location = new System.Drawing.Point(322, 96);
            this.tbBookPublish.Name = "tbBookPublish";
            this.tbBookPublish.Size = new System.Drawing.Size(197, 21);
            this.tbBookPublish.TabIndex = 4;
            // 
            // tbBookAutor
            // 
            this.tbBookAutor.Location = new System.Drawing.Point(79, 96);
            this.tbBookAutor.Name = "tbBookAutor";
            this.tbBookAutor.Size = new System.Drawing.Size(167, 21);
            this.tbBookAutor.TabIndex = 3;
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(79, 26);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(167, 21);
            this.tbBookID.TabIndex = 0;
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(79, 61);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(440, 21);
            this.tbBookName.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "登记日期";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "借出数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "定价";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "内容摘要";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "出版社";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "图书类别编号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "实际数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "出版日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "作者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "图书名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书编号";
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(166, 368);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(92, 23);
            this.btEnter.TabIndex = 11;
            this.btEnter.Text = "添加或修改";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(302, 368);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(92, 23);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // formStatus1
            // 
            this.formStatus1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formStatus1.Location = new System.Drawing.Point(0, 403);
            this.formStatus1.Name = "formStatus1";
            this.formStatus1.Size = new System.Drawing.Size(581, 26);
            this.formStatus1.TabIndex = 1;
            // 
            // lValidate
            // 
            this.lValidate.AutoSize = true;
            this.lValidate.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lValidate.ForeColor = System.Drawing.Color.Blue;
            this.lValidate.Location = new System.Drawing.Point(322, 193);
            this.lValidate.Name = "lValidate";
            this.lValidate.Size = new System.Drawing.Size(0, 11);
            this.lValidate.TabIndex = 12;
            // 
            // frmBookInfoAddOrUpdate
            // 
            this.AcceptButton = this.btEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(581, 429);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.formStatus1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookInfoAddOrUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加新卡片";
            this.Load += new System.EventHandler(this.frmBookInfoAddOrUpdate_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBookInfoAddOrUpdate_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBookResDate;
        private System.Windows.Forms.RichTextBox rtbBookSummary;
        private System.Windows.Forms.TextBox tbLendNum;
        private System.Windows.Forms.TextBox tbBookRealNum;
        private System.Windows.Forms.TextBox tbBookPrice;
        private System.Windows.Forms.TextBox tbBookPublish;
        private System.Windows.Forms.TextBox tbBookAutor;
        private System.Windows.Forms.ComboBox cbBookSortID;
        private FormStatus formStatus1;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.Label lBookSortMark;
        private System.Windows.Forms.Label lValidate;
    }
}