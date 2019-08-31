namespace BookManageSystem
{
    partial class frmBookInfoManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookInfoManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBookSortManage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefreshAllInfo = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAllBookInfo = new System.Windows.Forms.DataGridView();
            this.formStatus1 = new BookManageSystem.FormStatus();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBookSortManage,
            this.toolStripSeparator1,
            this.tsbAddInfo,
            this.tsbUpdateInfo,
            this.tsbDeleteInfo,
            this.toolStripSeparator2,
            this.tsbRefreshAllInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(765, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBookSortManage
            // 
            this.tsbBookSortManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBookSortManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBookSortManage.Name = "tsbBookSortManage";
            this.tsbBookSortManage.Size = new System.Drawing.Size(87, 22);
            this.tsbBookSortManage.Text = " 卡片类别管理";
            this.tsbBookSortManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBookSortManage.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAddInfo
            // 
            this.tsbAddInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddInfo.Image")));
            this.tsbAddInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddInfo.Name = "tsbAddInfo";
            this.tsbAddInfo.Size = new System.Drawing.Size(69, 22);
            this.tsbAddInfo.Text = "添加新卡片";
            this.tsbAddInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAddInfo.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbUpdateInfo
            // 
            this.tsbUpdateInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbUpdateInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdateInfo.Image")));
            this.tsbUpdateInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateInfo.Name = "tsbUpdateInfo";
            this.tsbUpdateInfo.Size = new System.Drawing.Size(81, 22);
            this.tsbUpdateInfo.Text = "修改卡片信息";
            this.tsbUpdateInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUpdateInfo.Click += new System.EventHandler(this.tsbUpdateInfo_Click);
            // 
            // tsbDeleteInfo
            // 
            this.tsbDeleteInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteInfo.Image")));
            this.tsbDeleteInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteInfo.Name = "tsbDeleteInfo";
            this.tsbDeleteInfo.Size = new System.Drawing.Size(81, 22);
            this.tsbDeleteInfo.Text = "删除卡片信息";
            this.tsbDeleteInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDeleteInfo.Click += new System.EventHandler(this.tsbDeleteInfo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefreshAllInfo
            // 
            this.tsbRefreshAllInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRefreshAllInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefreshAllInfo.Image")));
            this.tsbRefreshAllInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefreshAllInfo.Name = "tsbRefreshAllInfo";
            this.tsbRefreshAllInfo.Size = new System.Drawing.Size(153, 22);
            this.tsbRefreshAllInfo.Text = "刷新显示当前所有卡片信息";
            this.tsbRefreshAllInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRefreshAllInfo.Click += new System.EventHandler(this.tsbRefreshAllInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvAllBookInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 429);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前卡片信息";
            // 
            // dgvAllBookInfo
            // 
            this.dgvAllBookInfo.AllowUserToAddRows = false;
            this.dgvAllBookInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllBookInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllBookInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllBookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllBookInfo.Location = new System.Drawing.Point(3, 17);
            this.dgvAllBookInfo.Name = "dgvAllBookInfo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllBookInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllBookInfo.RowTemplate.Height = 23;
            this.dgvAllBookInfo.Size = new System.Drawing.Size(735, 409);
            this.dgvAllBookInfo.TabIndex = 0;
            // 
            // formStatus1
            // 
            this.formStatus1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formStatus1.Location = new System.Drawing.Point(0, 468);
            this.formStatus1.Name = "formStatus1";
            this.formStatus1.Size = new System.Drawing.Size(765, 26);
            this.formStatus1.TabIndex = 2;
            // 
            // frmBookInfoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 494);
            this.Controls.Add(this.formStatus1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookInfoManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书卡片信息管理";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBookSortManage;
        private System.Windows.Forms.ToolStripButton tsbAddInfo;
        private System.Windows.Forms.ToolStripButton tsbUpdateInfo;
        private System.Windows.Forms.ToolStripButton tsbDeleteInfo;
        private System.Windows.Forms.ToolStripButton tsbRefreshAllInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAllBookInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private FormStatus formStatus1;
    }
}