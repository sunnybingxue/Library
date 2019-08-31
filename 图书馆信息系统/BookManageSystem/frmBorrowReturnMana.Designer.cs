namespace BookManageSystem
{
    partial class frmBorrowReturnMana
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBorrow = new System.Windows.Forms.TabPage();
            this.btEnter = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbBname1 = new System.Windows.Forms.Label();
            this.lbBname = new System.Windows.Forms.Label();
            this.lbRname1 = new System.Windows.Forms.Label();
            this.lbRname = new System.Windows.Forms.Label();
            this.lbTrueName1 = new System.Windows.Forms.Label();
            this.lbTrueNum = new System.Windows.Forms.Label();
            this.dtkYReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtkBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.tbLendNum = new System.Windows.Forms.TextBox();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.cbReader = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabReturn = new System.Windows.Forms.TabPage();
            this.btSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbGBookName = new System.Windows.Forms.Label();
            this.lbGReaderName = new System.Windows.Forms.Label();
            this.cbGReaderID = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbGBookID = new System.Windows.Forms.ComboBox();
            this.btGEnter = new System.Windows.Forms.Button();
            this.btGCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbFmoney = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtkSreturn = new System.Windows.Forms.DateTimePicker();
            this.dtkGYreturn = new System.Windows.Forms.DateTimePicker();
            this.dtkGLendDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGLendNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.formStatus1 = new BookManageSystem.FormStatus();
            this.tabControl1.SuspendLayout();
            this.tabBorrow.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabReturn.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBorrow);
            this.tabControl1.Controls.Add(this.tabReturn);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBorrow
            // 
            this.tabBorrow.Controls.Add(this.btEnter);
            this.tabBorrow.Controls.Add(this.btCancel);
            this.tabBorrow.Controls.Add(this.groupBox1);
            this.tabBorrow.Location = new System.Drawing.Point(4, 21);
            this.tabBorrow.Name = "tabBorrow";
            this.tabBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.tabBorrow.Size = new System.Drawing.Size(836, 470);
            this.tabBorrow.TabIndex = 0;
            this.tabBorrow.Text = "图书借阅";
            this.tabBorrow.UseVisualStyleBackColor = true;
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(322, 332);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(75, 23);
            this.btEnter.TabIndex = 3;
            this.btEnter.Text = "借阅";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(450, 332);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbBname1);
            this.groupBox1.Controls.Add(this.lbBname);
            this.groupBox1.Controls.Add(this.lbRname1);
            this.groupBox1.Controls.Add(this.lbRname);
            this.groupBox1.Controls.Add(this.lbTrueName1);
            this.groupBox1.Controls.Add(this.lbTrueNum);
            this.groupBox1.Controls.Add(this.dtkYReturnDate);
            this.groupBox1.Controls.Add(this.dtkBorrowDate);
            this.groupBox1.Controls.Add(this.tbLendNum);
            this.groupBox1.Controls.Add(this.cbBook);
            this.groupBox1.Controls.Add(this.cbReader);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(188, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 219);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "借阅登记";
            // 
            // lbBname1
            // 
            this.lbBname1.AutoSize = true;
            this.lbBname1.ForeColor = System.Drawing.Color.Blue;
            this.lbBname1.Location = new System.Drawing.Point(304, 59);
            this.lbBname1.Name = "lbBname1";
            this.lbBname1.Size = new System.Drawing.Size(47, 12);
            this.lbBname1.TabIndex = 11;
            this.lbBname1.Text = "label11";
            this.lbBname1.Visible = false;
            // 
            // lbBname
            // 
            this.lbBname.AutoSize = true;
            this.lbBname.ForeColor = System.Drawing.Color.Red;
            this.lbBname.Location = new System.Drawing.Point(246, 59);
            this.lbBname.Name = "lbBname";
            this.lbBname.Size = new System.Drawing.Size(53, 12);
            this.lbBname.TabIndex = 10;
            this.lbBname.Text = "图书名称";
            this.lbBname.Visible = false;
            // 
            // lbRname1
            // 
            this.lbRname1.AutoSize = true;
            this.lbRname1.ForeColor = System.Drawing.Color.Blue;
            this.lbRname1.Location = new System.Drawing.Point(92, 60);
            this.lbRname1.Name = "lbRname1";
            this.lbRname1.Size = new System.Drawing.Size(41, 12);
            this.lbRname1.TabIndex = 9;
            this.lbRname1.Text = "label9";
            this.lbRname1.Visible = false;
            // 
            // lbRname
            // 
            this.lbRname.AutoSize = true;
            this.lbRname.ForeColor = System.Drawing.Color.Red;
            this.lbRname.Location = new System.Drawing.Point(37, 60);
            this.lbRname.Name = "lbRname";
            this.lbRname.Size = new System.Drawing.Size(53, 12);
            this.lbRname.TabIndex = 8;
            this.lbRname.Text = "读者姓名";
            this.lbRname.Visible = false;
            // 
            // lbTrueName1
            // 
            this.lbTrueName1.AutoSize = true;
            this.lbTrueName1.ForeColor = System.Drawing.Color.Blue;
            this.lbTrueName1.Location = new System.Drawing.Point(92, 117);
            this.lbTrueName1.Name = "lbTrueName1";
            this.lbTrueName1.Size = new System.Drawing.Size(41, 12);
            this.lbTrueName1.TabIndex = 7;
            this.lbTrueName1.Text = "label6";
            this.lbTrueName1.Visible = false;
            // 
            // lbTrueNum
            // 
            this.lbTrueNum.AutoSize = true;
            this.lbTrueNum.ForeColor = System.Drawing.Color.Red;
            this.lbTrueNum.Location = new System.Drawing.Point(35, 117);
            this.lbTrueNum.Name = "lbTrueNum";
            this.lbTrueNum.Size = new System.Drawing.Size(53, 12);
            this.lbTrueNum.TabIndex = 6;
            this.lbTrueNum.Text = "实际数量";
            this.lbTrueNum.Visible = false;
            // 
            // dtkYReturnDate
            // 
            this.dtkYReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtkYReturnDate.Location = new System.Drawing.Point(94, 149);
            this.dtkYReturnDate.Name = "dtkYReturnDate";
            this.dtkYReturnDate.Size = new System.Drawing.Size(130, 21);
            this.dtkYReturnDate.TabIndex = 5;
            // 
            // dtkBorrowDate
            // 
            this.dtkBorrowDate.Enabled = false;
            this.dtkBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtkBorrowDate.Location = new System.Drawing.Point(304, 86);
            this.dtkBorrowDate.Name = "dtkBorrowDate";
            this.dtkBorrowDate.Size = new System.Drawing.Size(138, 21);
            this.dtkBorrowDate.TabIndex = 4;
            // 
            // tbLendNum
            // 
            this.tbLendNum.Location = new System.Drawing.Point(94, 86);
            this.tbLendNum.Name = "tbLendNum";
            this.tbLendNum.Size = new System.Drawing.Size(129, 21);
            this.tbLendNum.TabIndex = 3;
            // 
            // cbBook
            // 
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(304, 31);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(138, 20);
            this.cbBook.TabIndex = 2;
            this.cbBook.TextChanged += new System.EventHandler(this.cbBook_TextChanged);
            // 
            // cbReader
            // 
            this.cbReader.FormattingEnabled = true;
            this.cbReader.Location = new System.Drawing.Point(94, 31);
            this.cbReader.Name = "cbReader";
            this.cbReader.Size = new System.Drawing.Size(130, 20);
            this.cbReader.TabIndex = 1;
            this.cbReader.TextChanged += new System.EventHandler(this.cbReader_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "应归还日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "借阅日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "借阅数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "图书编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者编号";
            // 
            // tabReturn
            // 
            this.tabReturn.Controls.Add(this.btSearch);
            this.tabReturn.Controls.Add(this.groupBox3);
            this.tabReturn.Controls.Add(this.btGEnter);
            this.tabReturn.Controls.Add(this.btGCancel);
            this.tabReturn.Controls.Add(this.groupBox2);
            this.tabReturn.Location = new System.Drawing.Point(4, 21);
            this.tabReturn.Name = "tabReturn";
            this.tabReturn.Padding = new System.Windows.Forms.Padding(3);
            this.tabReturn.Size = new System.Drawing.Size(836, 470);
            this.tabReturn.TabIndex = 1;
            this.tabReturn.Text = "图书归还";
            this.tabReturn.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(667, 74);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 9;
            this.btSearch.Text = "查询";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbGBookName);
            this.groupBox3.Controls.Add(this.lbGReaderName);
            this.groupBox3.Controls.Add(this.cbGReaderID);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cbGBookID);
            this.groupBox3.Location = new System.Drawing.Point(186, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 84);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "借阅查询";
            // 
            // lbGBookName
            // 
            this.lbGBookName.AutoSize = true;
            this.lbGBookName.Location = new System.Drawing.Point(288, 61);
            this.lbGBookName.Name = "lbGBookName";
            this.lbGBookName.Size = new System.Drawing.Size(0, 12);
            this.lbGBookName.TabIndex = 4;
            // 
            // lbGReaderName
            // 
            this.lbGReaderName.AutoSize = true;
            this.lbGReaderName.Location = new System.Drawing.Point(78, 61);
            this.lbGReaderName.Name = "lbGReaderName";
            this.lbGReaderName.Size = new System.Drawing.Size(0, 12);
            this.lbGReaderName.TabIndex = 3;
            // 
            // cbGReaderID
            // 
            this.cbGReaderID.FormattingEnabled = true;
            this.cbGReaderID.Location = new System.Drawing.Point(79, 31);
            this.cbGReaderID.Name = "cbGReaderID";
            this.cbGReaderID.Size = new System.Drawing.Size(130, 20);
            this.cbGReaderID.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "读者编号";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(229, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "图书编号";
            // 
            // cbGBookID
            // 
            this.cbGBookID.FormattingEnabled = true;
            this.cbGBookID.Location = new System.Drawing.Point(289, 31);
            this.cbGBookID.Name = "cbGBookID";
            this.cbGBookID.Size = new System.Drawing.Size(138, 20);
            this.cbGBookID.TabIndex = 2;
            // 
            // btGEnter
            // 
            this.btGEnter.Location = new System.Drawing.Point(320, 350);
            this.btGEnter.Name = "btGEnter";
            this.btGEnter.Size = new System.Drawing.Size(75, 23);
            this.btGEnter.TabIndex = 6;
            this.btGEnter.Text = "归还";
            this.btGEnter.UseVisualStyleBackColor = true;
            this.btGEnter.Click += new System.EventHandler(this.btGEnter_Click);
            // 
            // btGCancel
            // 
            this.btGCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btGCancel.Location = new System.Drawing.Point(448, 350);
            this.btGCancel.Name = "btGCancel";
            this.btGCancel.Size = new System.Drawing.Size(75, 23);
            this.btGCancel.TabIndex = 7;
            this.btGCancel.Text = "取消";
            this.btGCancel.UseVisualStyleBackColor = true;
            this.btGCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFmoney);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtkSreturn);
            this.groupBox2.Controls.Add(this.dtkGYreturn);
            this.groupBox2.Controls.Add(this.dtkGLendDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbGLendNum);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(186, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 180);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "归还登记";
            // 
            // tbFmoney
            // 
            this.tbFmoney.Location = new System.Drawing.Point(80, 133);
            this.tbFmoney.Name = "tbFmoney";
            this.tbFmoney.ReadOnly = true;
            this.tbFmoney.Size = new System.Drawing.Size(129, 21);
            this.tbFmoney.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "应处罚金";
            // 
            // dtkSreturn
            // 
            this.dtkSreturn.Enabled = false;
            this.dtkSreturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtkSreturn.Location = new System.Drawing.Point(290, 85);
            this.dtkSreturn.Name = "dtkSreturn";
            this.dtkSreturn.Size = new System.Drawing.Size(137, 21);
            this.dtkSreturn.TabIndex = 5;
            // 
            // dtkGYreturn
            // 
            this.dtkGYreturn.Enabled = false;
            this.dtkGYreturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtkGYreturn.Location = new System.Drawing.Point(79, 85);
            this.dtkGYreturn.Name = "dtkGYreturn";
            this.dtkGYreturn.Size = new System.Drawing.Size(130, 21);
            this.dtkGYreturn.TabIndex = 5;
            // 
            // dtkGLendDate
            // 
            this.dtkGLendDate.Enabled = false;
            this.dtkGLendDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtkGLendDate.Location = new System.Drawing.Point(290, 36);
            this.dtkGLendDate.Name = "dtkGLendDate";
            this.dtkGLendDate.Size = new System.Drawing.Size(138, 21);
            this.dtkGLendDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "实归还日期";
            // 
            // tbGLendNum
            // 
            this.tbGLendNum.Location = new System.Drawing.Point(80, 36);
            this.tbGLendNum.Name = "tbGLendNum";
            this.tbGLendNum.ReadOnly = true;
            this.tbGLendNum.Size = new System.Drawing.Size(129, 21);
            this.tbGLendNum.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "应归还日期";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "借阅日期";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "借阅数量";
            // 
            // formStatus1
            // 
            this.formStatus1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formStatus1.Location = new System.Drawing.Point(0, 469);
            this.formStatus1.Name = "formStatus1";
            this.formStatus1.Size = new System.Drawing.Size(844, 26);
            this.formStatus1.TabIndex = 1;
            // 
            // frmBorrowReturnMana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 495);
            this.Controls.Add(this.formStatus1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(852, 529);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(852, 529);
            this.Name = "frmBorrowReturnMana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借阅管理";
            this.Load += new System.EventHandler(this.frmBorrowReturnMana_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBorrow.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabReturn.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbBname1;
        private System.Windows.Forms.Label lbBname;
        private System.Windows.Forms.Label lbRname1;
        private System.Windows.Forms.Label lbRname;
        private System.Windows.Forms.Label lbTrueName1;
        private System.Windows.Forms.Label lbTrueNum;
        private System.Windows.Forms.DateTimePicker dtkYReturnDate;
        private System.Windows.Forms.DateTimePicker dtkBorrowDate;
        private System.Windows.Forms.TextBox tbLendNum;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.ComboBox cbReader;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FormStatus formStatus1;
        internal System.Windows.Forms.TabControl tabControl1;
        internal System.Windows.Forms.TabPage tabBorrow;
        internal System.Windows.Forms.TabPage tabReturn;
        private System.Windows.Forms.Button btGEnter;
        private System.Windows.Forms.Button btGCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtkGYreturn;
        private System.Windows.Forms.DateTimePicker dtkGLendDate;
        private System.Windows.Forms.TextBox tbGLendNum;
        private System.Windows.Forms.ComboBox cbGBookID;
        private System.Windows.Forms.ComboBox cbGReaderID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbGBookName;
        private System.Windows.Forms.Label lbGReaderName;
        private System.Windows.Forms.TextBox tbFmoney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtkSreturn;
        private System.Windows.Forms.Label label3;
    }
}