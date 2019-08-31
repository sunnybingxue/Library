namespace BookManageSystem
{
    partial class frmSystemInfoSearch
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
            this.tpBookInfo = new System.Windows.Forms.TabPage();
            this.btBookInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBPublish = new System.Windows.Forms.TextBox();
            this.tbBAuthor = new System.Windows.Forms.TextBox();
            this.tbBName = new System.Windows.Forms.TextBox();
            this.tbBSortID = new System.Windows.Forms.TextBox();
            this.tbBBookID = new System.Windows.Forms.TextBox();
            this.cbBName = new System.Windows.Forms.CheckBox();
            this.cbBSortID = new System.Windows.Forms.CheckBox();
            this.cbBBookID = new System.Windows.Forms.CheckBox();
            this.cbBPublish = new System.Windows.Forms.CheckBox();
            this.cbBAuthor = new System.Windows.Forms.CheckBox();
            this.tpReaderInfo = new System.Windows.Forms.TabPage();
            this.btReader = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comRSex = new System.Windows.Forms.ComboBox();
            this.tbRDept = new System.Windows.Forms.TextBox();
            this.tbREmail = new System.Windows.Forms.TextBox();
            this.tbROffice = new System.Windows.Forms.TextBox();
            this.tbRPhone = new System.Windows.Forms.TextBox();
            this.tbRName = new System.Windows.Forms.TextBox();
            this.cbRPhone = new System.Windows.Forms.CheckBox();
            this.tbRID = new System.Windows.Forms.TextBox();
            this.cbRSex = new System.Windows.Forms.CheckBox();
            this.cbRName = new System.Windows.Forms.CheckBox();
            this.cbRID = new System.Windows.Forms.CheckBox();
            this.cbREmail = new System.Windows.Forms.CheckBox();
            this.cbRDept = new System.Windows.Forms.CheckBox();
            this.cbROffice = new System.Windows.Forms.CheckBox();
            this.tpLendInfo = new System.Windows.Forms.TabPage();
            this.btLend = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.numFlag = new System.Windows.Forms.ComboBox();
            this.tbLlendNum = new System.Windows.Forms.TextBox();
            this.tbLReaderID = new System.Windows.Forms.TextBox();
            this.tbLBookID = new System.Windows.Forms.TextBox();
            this.cbLlendNum = new System.Windows.Forms.CheckBox();
            this.cbLReaderID = new System.Windows.Forms.CheckBox();
            this.cbLBookID = new System.Windows.Forms.CheckBox();
            this.cbLlenddate = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.formStatus1 = new BookManageSystem.FormStatus();
            this.tabControl1.SuspendLayout();
            this.tpBookInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpReaderInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpLendInfo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpBookInfo);
            this.tabControl1.Controls.Add(this.tpReaderInfo);
            this.tabControl1.Controls.Add(this.tpLendInfo);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 149);
            this.tabControl1.TabIndex = 0;
            // 
            // tpBookInfo
            // 
            this.tpBookInfo.Controls.Add(this.btBookInfo);
            this.tpBookInfo.Controls.Add(this.groupBox1);
            this.tpBookInfo.Location = new System.Drawing.Point(4, 21);
            this.tpBookInfo.Name = "tpBookInfo";
            this.tpBookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookInfo.Size = new System.Drawing.Size(875, 124);
            this.tpBookInfo.TabIndex = 0;
            this.tpBookInfo.Text = "图书信息查询";
            this.tpBookInfo.UseVisualStyleBackColor = true;
            // 
            // btBookInfo
            // 
            this.btBookInfo.Location = new System.Drawing.Point(753, 49);
            this.btBookInfo.Name = "btBookInfo";
            this.btBookInfo.Size = new System.Drawing.Size(84, 38);
            this.btBookInfo.TabIndex = 1;
            this.btBookInfo.Text = "查询";
            this.btBookInfo.UseVisualStyleBackColor = true;
            this.btBookInfo.Click += new System.EventHandler(this.btBookInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBPublish);
            this.groupBox1.Controls.Add(this.tbBAuthor);
            this.groupBox1.Controls.Add(this.tbBName);
            this.groupBox1.Controls.Add(this.tbBSortID);
            this.groupBox1.Controls.Add(this.tbBBookID);
            this.groupBox1.Controls.Add(this.cbBName);
            this.groupBox1.Controls.Add(this.cbBSortID);
            this.groupBox1.Controls.Add(this.cbBBookID);
            this.groupBox1.Controls.Add(this.cbBPublish);
            this.groupBox1.Controls.Add(this.cbBAuthor);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // tbBPublish
            // 
            this.tbBPublish.Location = new System.Drawing.Point(298, 59);
            this.tbBPublish.Name = "tbBPublish";
            this.tbBPublish.Size = new System.Drawing.Size(358, 21);
            this.tbBPublish.TabIndex = 3;
            // 
            // tbBAuthor
            // 
            this.tbBAuthor.Location = new System.Drawing.Point(87, 59);
            this.tbBAuthor.Name = "tbBAuthor";
            this.tbBAuthor.Size = new System.Drawing.Size(110, 21);
            this.tbBAuthor.TabIndex = 3;
            // 
            // tbBName
            // 
            this.tbBName.Location = new System.Drawing.Point(492, 25);
            this.tbBName.Name = "tbBName";
            this.tbBName.Size = new System.Drawing.Size(164, 21);
            this.tbBName.TabIndex = 3;
            // 
            // tbBSortID
            // 
            this.tbBSortID.Location = new System.Drawing.Point(298, 25);
            this.tbBSortID.Name = "tbBSortID";
            this.tbBSortID.Size = new System.Drawing.Size(110, 21);
            this.tbBSortID.TabIndex = 3;
            // 
            // tbBBookID
            // 
            this.tbBBookID.Location = new System.Drawing.Point(87, 25);
            this.tbBBookID.Name = "tbBBookID";
            this.tbBBookID.Size = new System.Drawing.Size(110, 21);
            this.tbBBookID.TabIndex = 3;
            // 
            // cbBName
            // 
            this.cbBName.AutoSize = true;
            this.cbBName.Location = new System.Drawing.Point(414, 30);
            this.cbBName.Name = "cbBName";
            this.cbBName.Size = new System.Drawing.Size(72, 16);
            this.cbBName.TabIndex = 0;
            this.cbBName.Text = "图书名称";
            this.cbBName.UseVisualStyleBackColor = true;
            // 
            // cbBSortID
            // 
            this.cbBSortID.AutoSize = true;
            this.cbBSortID.Location = new System.Drawing.Point(203, 30);
            this.cbBSortID.Name = "cbBSortID";
            this.cbBSortID.Size = new System.Drawing.Size(96, 16);
            this.cbBSortID.TabIndex = 2;
            this.cbBSortID.Text = "图书类别编号";
            this.cbBSortID.UseVisualStyleBackColor = true;
            // 
            // cbBBookID
            // 
            this.cbBBookID.AutoSize = true;
            this.cbBBookID.Location = new System.Drawing.Point(20, 30);
            this.cbBBookID.Name = "cbBBookID";
            this.cbBBookID.Size = new System.Drawing.Size(72, 16);
            this.cbBBookID.TabIndex = 1;
            this.cbBBookID.Text = "图书编号";
            this.cbBBookID.UseVisualStyleBackColor = true;
            // 
            // cbBPublish
            // 
            this.cbBPublish.AutoSize = true;
            this.cbBPublish.Location = new System.Drawing.Point(203, 64);
            this.cbBPublish.Name = "cbBPublish";
            this.cbBPublish.Size = new System.Drawing.Size(60, 16);
            this.cbBPublish.TabIndex = 0;
            this.cbBPublish.Text = "出版社";
            this.cbBPublish.UseVisualStyleBackColor = true;
            // 
            // cbBAuthor
            // 
            this.cbBAuthor.AutoSize = true;
            this.cbBAuthor.Location = new System.Drawing.Point(20, 64);
            this.cbBAuthor.Name = "cbBAuthor";
            this.cbBAuthor.Size = new System.Drawing.Size(48, 16);
            this.cbBAuthor.TabIndex = 0;
            this.cbBAuthor.Text = "作者";
            this.cbBAuthor.UseVisualStyleBackColor = true;
            // 
            // tpReaderInfo
            // 
            this.tpReaderInfo.Controls.Add(this.btReader);
            this.tpReaderInfo.Controls.Add(this.groupBox3);
            this.tpReaderInfo.Location = new System.Drawing.Point(4, 21);
            this.tpReaderInfo.Name = "tpReaderInfo";
            this.tpReaderInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpReaderInfo.Size = new System.Drawing.Size(875, 124);
            this.tpReaderInfo.TabIndex = 1;
            this.tpReaderInfo.Text = "读者信息查询";
            this.tpReaderInfo.UseVisualStyleBackColor = true;
            // 
            // btReader
            // 
            this.btReader.Location = new System.Drawing.Point(753, 49);
            this.btReader.Name = "btReader";
            this.btReader.Size = new System.Drawing.Size(84, 38);
            this.btReader.TabIndex = 2;
            this.btReader.Text = "查询";
            this.btReader.UseVisualStyleBackColor = true;
            this.btReader.Click += new System.EventHandler(this.btReader_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comRSex);
            this.groupBox3.Controls.Add(this.tbRDept);
            this.groupBox3.Controls.Add(this.tbREmail);
            this.groupBox3.Controls.Add(this.tbROffice);
            this.groupBox3.Controls.Add(this.tbRPhone);
            this.groupBox3.Controls.Add(this.tbRName);
            this.groupBox3.Controls.Add(this.cbRPhone);
            this.groupBox3.Controls.Add(this.tbRID);
            this.groupBox3.Controls.Add(this.cbRSex);
            this.groupBox3.Controls.Add(this.cbRName);
            this.groupBox3.Controls.Add(this.cbRID);
            this.groupBox3.Controls.Add(this.cbREmail);
            this.groupBox3.Controls.Add(this.cbRDept);
            this.groupBox3.Controls.Add(this.cbROffice);
            this.groupBox3.Location = new System.Drawing.Point(6, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(730, 98);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询条件";
            // 
            // comRSex
            // 
            this.comRSex.FormattingEnabled = true;
            this.comRSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comRSex.Location = new System.Drawing.Point(493, 15);
            this.comRSex.Name = "comRSex";
            this.comRSex.Size = new System.Drawing.Size(84, 20);
            this.comRSex.TabIndex = 4;
            this.comRSex.Text = "男";
            // 
            // tbRDept
            // 
            this.tbRDept.Location = new System.Drawing.Point(272, 41);
            this.tbRDept.Name = "tbRDept";
            this.tbRDept.Size = new System.Drawing.Size(136, 21);
            this.tbRDept.TabIndex = 3;
            // 
            // tbREmail
            // 
            this.tbREmail.Location = new System.Drawing.Point(87, 67);
            this.tbREmail.Name = "tbREmail";
            this.tbREmail.Size = new System.Drawing.Size(110, 21);
            this.tbREmail.TabIndex = 3;
            // 
            // tbROffice
            // 
            this.tbROffice.Location = new System.Drawing.Point(87, 41);
            this.tbROffice.Name = "tbROffice";
            this.tbROffice.Size = new System.Drawing.Size(110, 21);
            this.tbROffice.TabIndex = 3;
            // 
            // tbRPhone
            // 
            this.tbRPhone.Location = new System.Drawing.Point(492, 41);
            this.tbRPhone.Name = "tbRPhone";
            this.tbRPhone.Size = new System.Drawing.Size(164, 21);
            this.tbRPhone.TabIndex = 3;
            // 
            // tbRName
            // 
            this.tbRName.Location = new System.Drawing.Point(272, 15);
            this.tbRName.Name = "tbRName";
            this.tbRName.Size = new System.Drawing.Size(136, 21);
            this.tbRName.TabIndex = 3;
            // 
            // cbRPhone
            // 
            this.cbRPhone.AutoSize = true;
            this.cbRPhone.Location = new System.Drawing.Point(414, 46);
            this.cbRPhone.Name = "cbRPhone";
            this.cbRPhone.Size = new System.Drawing.Size(72, 16);
            this.cbRPhone.TabIndex = 0;
            this.cbRPhone.Text = "联系电话";
            this.cbRPhone.UseVisualStyleBackColor = true;
            // 
            // tbRID
            // 
            this.tbRID.Location = new System.Drawing.Point(87, 15);
            this.tbRID.Name = "tbRID";
            this.tbRID.Size = new System.Drawing.Size(110, 21);
            this.tbRID.TabIndex = 3;
            // 
            // cbRSex
            // 
            this.cbRSex.AutoSize = true;
            this.cbRSex.Location = new System.Drawing.Point(414, 20);
            this.cbRSex.Name = "cbRSex";
            this.cbRSex.Size = new System.Drawing.Size(72, 16);
            this.cbRSex.TabIndex = 0;
            this.cbRSex.Text = "读者性别";
            this.cbRSex.UseVisualStyleBackColor = true;
            // 
            // cbRName
            // 
            this.cbRName.AutoSize = true;
            this.cbRName.Location = new System.Drawing.Point(203, 20);
            this.cbRName.Name = "cbRName";
            this.cbRName.Size = new System.Drawing.Size(72, 16);
            this.cbRName.TabIndex = 2;
            this.cbRName.Text = "读者姓名";
            this.cbRName.UseVisualStyleBackColor = true;
            // 
            // cbRID
            // 
            this.cbRID.AutoSize = true;
            this.cbRID.Location = new System.Drawing.Point(20, 20);
            this.cbRID.Name = "cbRID";
            this.cbRID.Size = new System.Drawing.Size(72, 16);
            this.cbRID.TabIndex = 1;
            this.cbRID.Text = "读者编号";
            this.cbRID.UseVisualStyleBackColor = true;
            // 
            // cbREmail
            // 
            this.cbREmail.AutoSize = true;
            this.cbREmail.Location = new System.Drawing.Point(20, 72);
            this.cbREmail.Name = "cbREmail";
            this.cbREmail.Size = new System.Drawing.Size(54, 16);
            this.cbREmail.TabIndex = 0;
            this.cbREmail.Text = "Email";
            this.cbREmail.UseVisualStyleBackColor = true;
            // 
            // cbRDept
            // 
            this.cbRDept.AutoSize = true;
            this.cbRDept.Location = new System.Drawing.Point(203, 46);
            this.cbRDept.Name = "cbRDept";
            this.cbRDept.Size = new System.Drawing.Size(72, 16);
            this.cbRDept.TabIndex = 0;
            this.cbRDept.Text = "工作单位";
            this.cbRDept.UseVisualStyleBackColor = true;
            // 
            // cbROffice
            // 
            this.cbROffice.AutoSize = true;
            this.cbROffice.Location = new System.Drawing.Point(20, 46);
            this.cbROffice.Name = "cbROffice";
            this.cbROffice.Size = new System.Drawing.Size(72, 16);
            this.cbROffice.TabIndex = 0;
            this.cbROffice.Text = "读者职务";
            this.cbROffice.UseVisualStyleBackColor = true;
            // 
            // tpLendInfo
            // 
            this.tpLendInfo.Controls.Add(this.btLend);
            this.tpLendInfo.Controls.Add(this.groupBox4);
            this.tpLendInfo.Location = new System.Drawing.Point(4, 21);
            this.tpLendInfo.Name = "tpLendInfo";
            this.tpLendInfo.Size = new System.Drawing.Size(875, 124);
            this.tpLendInfo.TabIndex = 2;
            this.tpLendInfo.Text = "图书借阅信息查询";
            this.tpLendInfo.UseVisualStyleBackColor = true;
            // 
            // btLend
            // 
            this.btLend.Location = new System.Drawing.Point(753, 49);
            this.btLend.Name = "btLend";
            this.btLend.Size = new System.Drawing.Size(84, 38);
            this.btLend.TabIndex = 3;
            this.btLend.Text = "查询";
            this.btLend.UseVisualStyleBackColor = true;
            this.btLend.Click += new System.EventHandler(this.btLend_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dtpEndTime);
            this.groupBox4.Controls.Add(this.dtpStartTime);
            this.groupBox4.Controls.Add(this.numFlag);
            this.groupBox4.Controls.Add(this.tbLlendNum);
            this.groupBox4.Controls.Add(this.tbLReaderID);
            this.groupBox4.Controls.Add(this.tbLBookID);
            this.groupBox4.Controls.Add(this.cbLlendNum);
            this.groupBox4.Controls.Add(this.cbLReaderID);
            this.groupBox4.Controls.Add(this.cbLBookID);
            this.groupBox4.Controls.Add(this.cbLlenddate);
            this.groupBox4.Location = new System.Drawing.Point(6, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(730, 98);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查询条件";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartTime.Location = new System.Drawing.Point(98, 63);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(137, 21);
            this.dtpStartTime.TabIndex = 5;
            // 
            // numFlag
            // 
            this.numFlag.FormattingEnabled = true;
            this.numFlag.Items.AddRange(new object[] {
            ">",
            "=",
            "<"});
            this.numFlag.Location = new System.Drawing.Point(483, 23);
            this.numFlag.Name = "numFlag";
            this.numFlag.Size = new System.Drawing.Size(38, 20);
            this.numFlag.TabIndex = 4;
            this.numFlag.Text = "=";
            // 
            // tbLlendNum
            // 
            this.tbLlendNum.Location = new System.Drawing.Point(527, 23);
            this.tbLlendNum.Name = "tbLlendNum";
            this.tbLlendNum.Size = new System.Drawing.Size(118, 21);
            this.tbLlendNum.TabIndex = 3;
            // 
            // tbLReaderID
            // 
            this.tbLReaderID.Location = new System.Drawing.Point(274, 23);
            this.tbLReaderID.Name = "tbLReaderID";
            this.tbLReaderID.Size = new System.Drawing.Size(134, 21);
            this.tbLReaderID.TabIndex = 3;
            // 
            // tbLBookID
            // 
            this.tbLBookID.Location = new System.Drawing.Point(87, 23);
            this.tbLBookID.Name = "tbLBookID";
            this.tbLBookID.Size = new System.Drawing.Size(110, 21);
            this.tbLBookID.TabIndex = 3;
            // 
            // cbLlendNum
            // 
            this.cbLlendNum.AutoSize = true;
            this.cbLlendNum.Location = new System.Drawing.Point(414, 28);
            this.cbLlendNum.Name = "cbLlendNum";
            this.cbLlendNum.Size = new System.Drawing.Size(72, 16);
            this.cbLlendNum.TabIndex = 0;
            this.cbLlendNum.Text = "借阅数量";
            this.cbLlendNum.UseVisualStyleBackColor = true;
            // 
            // cbLReaderID
            // 
            this.cbLReaderID.AutoSize = true;
            this.cbLReaderID.Location = new System.Drawing.Point(203, 28);
            this.cbLReaderID.Name = "cbLReaderID";
            this.cbLReaderID.Size = new System.Drawing.Size(72, 16);
            this.cbLReaderID.TabIndex = 2;
            this.cbLReaderID.Text = "读者编号";
            this.cbLReaderID.UseVisualStyleBackColor = true;
            // 
            // cbLBookID
            // 
            this.cbLBookID.AutoSize = true;
            this.cbLBookID.Location = new System.Drawing.Point(20, 28);
            this.cbLBookID.Name = "cbLBookID";
            this.cbLBookID.Size = new System.Drawing.Size(72, 16);
            this.cbLBookID.TabIndex = 1;
            this.cbLBookID.Text = "图书编号";
            this.cbLBookID.UseVisualStyleBackColor = true;
            // 
            // cbLlenddate
            // 
            this.cbLlenddate.AutoSize = true;
            this.cbLlenddate.Location = new System.Drawing.Point(20, 66);
            this.cbLlenddate.Name = "cbLlenddate";
            this.cbLlenddate.Size = new System.Drawing.Size(72, 16);
            this.cbLlenddate.TabIndex = 0;
            this.cbLlenddate.Text = "借阅日期";
            this.cbLlenddate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvSearchResult);
            this.groupBox2.Location = new System.Drawing.Point(6, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 374);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询结果";
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.AllowUserToAddRows = false;
            this.dgvSearchResult.AllowUserToDeleteRows = false;
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchResult.Location = new System.Drawing.Point(3, 17);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.ReadOnly = true;
            this.dgvSearchResult.RowTemplate.Height = 23;
            this.dgvSearchResult.Size = new System.Drawing.Size(869, 354);
            this.dgvSearchResult.TabIndex = 0;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndTime.Location = new System.Drawing.Point(270, 63);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(138, 21);
            this.dtpEndTime.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "-->";
            // 
            // formStatus1
            // 
            this.formStatus1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formStatus1.Location = new System.Drawing.Point(0, 535);
            this.formStatus1.Name = "formStatus1";
            this.formStatus1.Size = new System.Drawing.Size(885, 26);
            this.formStatus1.TabIndex = 1;
            // 
            // frmSystemInfoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.formStatus1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmSystemInfoSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统信息查询";
            this.Load += new System.EventHandler(this.frmSystemInfoSearch_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpBookInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpReaderInfo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpLendInfo.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FormStatus formStatus1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.Button btReader;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbRDept;
        private System.Windows.Forms.TextBox tbREmail;
        private System.Windows.Forms.TextBox tbROffice;
        private System.Windows.Forms.TextBox tbRPhone;
        private System.Windows.Forms.TextBox tbRName;
        private System.Windows.Forms.CheckBox cbRPhone;
        private System.Windows.Forms.TextBox tbRID;
        private System.Windows.Forms.CheckBox cbRSex;
        private System.Windows.Forms.CheckBox cbRName;
        private System.Windows.Forms.CheckBox cbRID;
        private System.Windows.Forms.CheckBox cbREmail;
        private System.Windows.Forms.CheckBox cbRDept;
        private System.Windows.Forms.CheckBox cbROffice;
        private System.Windows.Forms.Button btBookInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBPublish;
        private System.Windows.Forms.TextBox tbBAuthor;
        private System.Windows.Forms.TextBox tbBName;
        private System.Windows.Forms.TextBox tbBSortID;
        private System.Windows.Forms.TextBox tbBBookID;
        private System.Windows.Forms.CheckBox cbBName;
        private System.Windows.Forms.CheckBox cbBSortID;
        private System.Windows.Forms.CheckBox cbBBookID;
        private System.Windows.Forms.CheckBox cbBPublish;
        private System.Windows.Forms.CheckBox cbBAuthor;
        private System.Windows.Forms.Button btLend;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbLlendNum;
        private System.Windows.Forms.TextBox tbLReaderID;
        private System.Windows.Forms.TextBox tbLBookID;
        private System.Windows.Forms.CheckBox cbLlendNum;
        private System.Windows.Forms.CheckBox cbLReaderID;
        private System.Windows.Forms.CheckBox cbLBookID;
        private System.Windows.Forms.CheckBox cbLlenddate;
        private System.Windows.Forms.ComboBox numFlag;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.ComboBox comRSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        internal System.Windows.Forms.TabPage tpBookInfo;
        internal System.Windows.Forms.TabPage tpReaderInfo;
        internal System.Windows.Forms.TabPage tpLendInfo;
        internal System.Windows.Forms.TabControl tabControl1;
    }
}