namespace BookManageSystem
{
    partial class frmManagePannel
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
            this.btBookInfoManage = new System.Windows.Forms.Button();
            this.btReaderInfoManage = new System.Windows.Forms.Button();
            this.btLendMange = new System.Windows.Forms.Button();
            this.btSysInfoManage = new System.Windows.Forms.Button();
            this.btUserPurviewMange = new System.Windows.Forms.Button();
            this.rtBtInformation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btBookInfoManage
            // 
            this.btBookInfoManage.BackColor = System.Drawing.SystemColors.Control;
            this.btBookInfoManage.Location = new System.Drawing.Point(23, 25);
            this.btBookInfoManage.Name = "btBookInfoManage";
            this.btBookInfoManage.Size = new System.Drawing.Size(177, 46);
            this.btBookInfoManage.TabIndex = 0;
            this.btBookInfoManage.Text = "图书卡片管理";
            this.btBookInfoManage.UseVisualStyleBackColor = true;
            this.btBookInfoManage.MouseLeave += new System.EventHandler(this.btBookInfoManage_MouseLeave);
            this.btBookInfoManage.Click += new System.EventHandler(this.btBookInfoManage_Click);
            this.btBookInfoManage.MouseEnter += new System.EventHandler(this.btBookInfoManage_MouseEnter);
            // 
            // btReaderInfoManage
            // 
            this.btReaderInfoManage.Location = new System.Drawing.Point(23, 77);
            this.btReaderInfoManage.Name = "btReaderInfoManage";
            this.btReaderInfoManage.Size = new System.Drawing.Size(177, 46);
            this.btReaderInfoManage.TabIndex = 1;
            this.btReaderInfoManage.Text = "读者信息维护";
            this.btReaderInfoManage.UseVisualStyleBackColor = true;
            this.btReaderInfoManage.MouseLeave += new System.EventHandler(this.btReaderInfoManage_MouseLeave);
            this.btReaderInfoManage.Click += new System.EventHandler(this.btReaderInfoManage_Click);
            this.btReaderInfoManage.MouseEnter += new System.EventHandler(this.btReaderInfoManage_MouseEnter);
            // 
            // btLendMange
            // 
            this.btLendMange.Location = new System.Drawing.Point(23, 129);
            this.btLendMange.Name = "btLendMange";
            this.btLendMange.Size = new System.Drawing.Size(177, 46);
            this.btLendMange.TabIndex = 2;
            this.btLendMange.Text = "图书借阅管理";
            this.btLendMange.UseVisualStyleBackColor = true;
            this.btLendMange.MouseLeave += new System.EventHandler(this.btLendMange_MouseLeave);
            this.btLendMange.Click += new System.EventHandler(this.btLendMange_Click);
            this.btLendMange.MouseEnter += new System.EventHandler(this.btLendMange_MouseEnter);
            // 
            // btSysInfoManage
            // 
            this.btSysInfoManage.Location = new System.Drawing.Point(23, 181);
            this.btSysInfoManage.Name = "btSysInfoManage";
            this.btSysInfoManage.Size = new System.Drawing.Size(177, 46);
            this.btSysInfoManage.TabIndex = 3;
            this.btSysInfoManage.Text = "系统信息查询";
            this.btSysInfoManage.UseVisualStyleBackColor = true;
            this.btSysInfoManage.MouseLeave += new System.EventHandler(this.btSysInfoManage_MouseLeave);
            this.btSysInfoManage.Click += new System.EventHandler(this.btSysInfoManage_Click);
            this.btSysInfoManage.MouseEnter += new System.EventHandler(this.btSysInfoManage_MouseEnter);
            // 
            // btUserPurviewMange
            // 
            this.btUserPurviewMange.Location = new System.Drawing.Point(23, 233);
            this.btUserPurviewMange.Name = "btUserPurviewMange";
            this.btUserPurviewMange.Size = new System.Drawing.Size(177, 46);
            this.btUserPurviewMange.TabIndex = 4;
            this.btUserPurviewMange.Text = "用户权限管理";
            this.btUserPurviewMange.UseVisualStyleBackColor = true;
            this.btUserPurviewMange.MouseLeave += new System.EventHandler(this.btUserPurviewMange_MouseLeave);
            this.btUserPurviewMange.Click += new System.EventHandler(this.btUserPurviewMange_Click);
            this.btUserPurviewMange.MouseEnter += new System.EventHandler(this.btUserPurviewMange_MouseEnter);
            // 
            // rtBtInformation
            // 
            this.rtBtInformation.BackColor = System.Drawing.SystemColors.Control;
            this.rtBtInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtBtInformation.Location = new System.Drawing.Point(226, 25);
            this.rtBtInformation.Name = "rtBtInformation";
            this.rtBtInformation.ReadOnly = true;
            this.rtBtInformation.Size = new System.Drawing.Size(323, 254);
            this.rtBtInformation.TabIndex = 1;
            this.rtBtInformation.Text = "";
            // 
            // frmManagePannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 302);
            this.ControlBox = false;
            this.Controls.Add(this.rtBtInformation);
            this.Controls.Add(this.btUserPurviewMange);
            this.Controls.Add(this.btSysInfoManage);
            this.Controls.Add(this.btLendMange);
            this.Controls.Add(this.btReaderInfoManage);
            this.Controls.Add(this.btBookInfoManage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManagePannel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "菜单管理";
            this.Load += new System.EventHandler(this.frmManagePannel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBookInfoManage;
        private System.Windows.Forms.Button btReaderInfoManage;
        private System.Windows.Forms.Button btLendMange;
        private System.Windows.Forms.Button btSysInfoManage;
        private System.Windows.Forms.Button btUserPurviewMange;
        private System.Windows.Forms.RichTextBox rtBtInformation;
    }
}