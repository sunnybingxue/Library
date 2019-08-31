namespace BookManageSystem
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.tsMenuItemSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改口令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemBookInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.图书卡片管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemReader = new System.Windows.Forms.ToolStripMenuItem();
            this.读者信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemLend = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.归还图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.图书信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书借阅查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemPurview = new System.Windows.Forms.ToolStripMenuItem();
            this.用户权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.formStatus1 = new BookManageSystem.FormStatus();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemSystem,
            this.tsMenuItemBookInfo,
            this.tsMenuItemReader,
            this.tsMenuItemLend,
            this.tsMenuItemSearch,
            this.tsMenuItemPurview,
            this.tsMenuItemWindow});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1028, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // tsMenuItemSystem
            // 
            this.tsMenuItemSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销用户ToolStripMenuItem,
            this.修改口令ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.tsMenuItemSystem.Name = "tsMenuItemSystem";
            this.tsMenuItemSystem.Size = new System.Drawing.Size(59, 20);
            this.tsMenuItemSystem.Text = "系统(&S)";
            // 
            // 注销用户ToolStripMenuItem
            // 
            this.注销用户ToolStripMenuItem.Name = "注销用户ToolStripMenuItem";
            this.注销用户ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.注销用户ToolStripMenuItem.Text = "注销用户";
            this.注销用户ToolStripMenuItem.Click += new System.EventHandler(this.注销用户ToolStripMenuItem_Click);
            // 
            // 修改口令ToolStripMenuItem
            // 
            this.修改口令ToolStripMenuItem.Name = "修改口令ToolStripMenuItem";
            this.修改口令ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.修改口令ToolStripMenuItem.Text = "修改口令";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // tsMenuItemBookInfo
            // 
            this.tsMenuItemBookInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书卡片管理ToolStripMenuItem});
            this.tsMenuItemBookInfo.Name = "tsMenuItemBookInfo";
            this.tsMenuItemBookInfo.Size = new System.Drawing.Size(107, 20);
            this.tsMenuItemBookInfo.Text = "图书卡片管理(&B)";
            // 
            // 图书卡片管理ToolStripMenuItem
            // 
            this.图书卡片管理ToolStripMenuItem.Name = "图书卡片管理ToolStripMenuItem";
            this.图书卡片管理ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.图书卡片管理ToolStripMenuItem.Text = "图书卡片管理";
            this.图书卡片管理ToolStripMenuItem.Click += new System.EventHandler(this.图书卡片管理ToolStripMenuItem_Click);
            // 
            // tsMenuItemReader
            // 
            this.tsMenuItemReader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读者信息维护ToolStripMenuItem});
            this.tsMenuItemReader.Name = "tsMenuItemReader";
            this.tsMenuItemReader.Size = new System.Drawing.Size(107, 20);
            this.tsMenuItemReader.Text = "读者信息维护(&R)";
            // 
            // 读者信息维护ToolStripMenuItem
            // 
            this.读者信息维护ToolStripMenuItem.Name = "读者信息维护ToolStripMenuItem";
            this.读者信息维护ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.读者信息维护ToolStripMenuItem.Text = "读者信息维护";
            this.读者信息维护ToolStripMenuItem.Click += new System.EventHandler(this.读者信息维护ToolStripMenuItem_Click);
            // 
            // tsMenuItemLend
            // 
            this.tsMenuItemLend.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借阅图书ToolStripMenuItem,
            this.归还图书ToolStripMenuItem});
            this.tsMenuItemLend.Name = "tsMenuItemLend";
            this.tsMenuItemLend.Size = new System.Drawing.Size(107, 20);
            this.tsMenuItemLend.Text = "图书借阅管理(&L)";
            // 
            // 借阅图书ToolStripMenuItem
            // 
            this.借阅图书ToolStripMenuItem.Name = "借阅图书ToolStripMenuItem";
            this.借阅图书ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.借阅图书ToolStripMenuItem.Text = "借阅图书";
            this.借阅图书ToolStripMenuItem.Click += new System.EventHandler(this.借阅图书ToolStripMenuItem_Click);
            // 
            // 归还图书ToolStripMenuItem
            // 
            this.归还图书ToolStripMenuItem.Name = "归还图书ToolStripMenuItem";
            this.归还图书ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.归还图书ToolStripMenuItem.Text = "归还图书";
            this.归还图书ToolStripMenuItem.Click += new System.EventHandler(this.归还图书ToolStripMenuItem_Click);
            // 
            // tsMenuItemSearch
            // 
            this.tsMenuItemSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书信息查询ToolStripMenuItem,
            this.读者信息查询ToolStripMenuItem,
            this.图书借阅查询ToolStripMenuItem});
            this.tsMenuItemSearch.Name = "tsMenuItemSearch";
            this.tsMenuItemSearch.Size = new System.Drawing.Size(107, 20);
            this.tsMenuItemSearch.Text = "系统信息查询(&I)";
            // 
            // 图书信息查询ToolStripMenuItem
            // 
            this.图书信息查询ToolStripMenuItem.Name = "图书信息查询ToolStripMenuItem";
            this.图书信息查询ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.图书信息查询ToolStripMenuItem.Text = "图书信息查询";
            this.图书信息查询ToolStripMenuItem.Click += new System.EventHandler(this.图书信息查询ToolStripMenuItem_Click);
            // 
            // 读者信息查询ToolStripMenuItem
            // 
            this.读者信息查询ToolStripMenuItem.Name = "读者信息查询ToolStripMenuItem";
            this.读者信息查询ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.读者信息查询ToolStripMenuItem.Text = "读者信息查询";
            this.读者信息查询ToolStripMenuItem.Click += new System.EventHandler(this.读者信息查询ToolStripMenuItem_Click);
            // 
            // 图书借阅查询ToolStripMenuItem
            // 
            this.图书借阅查询ToolStripMenuItem.Name = "图书借阅查询ToolStripMenuItem";
            this.图书借阅查询ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.图书借阅查询ToolStripMenuItem.Text = "图书借阅查询";
            this.图书借阅查询ToolStripMenuItem.Click += new System.EventHandler(this.图书借阅查询ToolStripMenuItem_Click);
            // 
            // tsMenuItemPurview
            // 
            this.tsMenuItemPurview.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户权限管理ToolStripMenuItem});
            this.tsMenuItemPurview.Name = "tsMenuItemPurview";
            this.tsMenuItemPurview.Size = new System.Drawing.Size(107, 20);
            this.tsMenuItemPurview.Text = "用户权限管理(&P)";
            // 
            // 用户权限管理ToolStripMenuItem
            // 
            this.用户权限管理ToolStripMenuItem.Name = "用户权限管理ToolStripMenuItem";
            this.用户权限管理ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.用户权限管理ToolStripMenuItem.Text = "用户权限管理";
            this.用户权限管理ToolStripMenuItem.Click += new System.EventHandler(this.用户权限管理ToolStripMenuItem_Click);
            // 
            // tsMenuItemWindow
            // 
            this.tsMenuItemWindow.Name = "tsMenuItemWindow";
            this.tsMenuItemWindow.Size = new System.Drawing.Size(41, 20);
            this.tsMenuItemWindow.Text = "窗口";
            this.tsMenuItemWindow.DropDownOpening += new System.EventHandler(this.tsMenuItemWindow_DropDownOpening);
            // 
            // formStatus1
            // 
            this.formStatus1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formStatus1.Location = new System.Drawing.Point(0, 516);
            this.formStatus1.Name = "formStatus1";
            this.formStatus1.Size = new System.Drawing.Size(1028, 26);
            this.formStatus1.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 542);
            this.Controls.Add(this.formStatus1);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "图书管理信息系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemSystem;
        private System.Windows.Forms.ToolStripMenuItem 注销用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改口令ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemBookInfo;
        private System.Windows.Forms.ToolStripMenuItem 图书卡片管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemReader;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemLend;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemSearch;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemPurview;
        private System.Windows.Forms.ToolStripMenuItem 读者信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 归还图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书借阅查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户权限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemWindow;
        private FormStatus formStatus1;
    }
}

