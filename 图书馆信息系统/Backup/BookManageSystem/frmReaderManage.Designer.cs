namespace BookManageSystem
{
    partial class frmReaderManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReaderManage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddNewReader = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateReader = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteReader = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefreshAllReader = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAllReader = new System.Windows.Forms.DataGridView();
            this.formStatus1 = new BookManageSystem.FormStatus();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReader)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddNewReader,
            this.tsbUpdateReader,
            this.tsbDeleteReader,
            this.toolStripSeparator2,
            this.tsbRefreshAllReader});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(865, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddNewReader
            // 
            this.tsbAddNewReader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddNewReader.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddNewReader.Image")));
            this.tsbAddNewReader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNewReader.Name = "tsbAddNewReader";
            this.tsbAddNewReader.Size = new System.Drawing.Size(71, 22);
            this.tsbAddNewReader.Text = "添加新读者";
            this.tsbAddNewReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAddNewReader.Click += new System.EventHandler(this.tsbAddNewReader_Click);
            // 
            // tsbUpdateReader
            // 
            this.tsbUpdateReader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbUpdateReader.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdateReader.Image")));
            this.tsbUpdateReader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateReader.Name = "tsbUpdateReader";
            this.tsbUpdateReader.Size = new System.Drawing.Size(83, 22);
            this.tsbUpdateReader.Text = "修改读者信息";
            this.tsbUpdateReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUpdateReader.Click += new System.EventHandler(this.tsbUpdateReader_Click);
            // 
            // tsbDeleteReader
            // 
            this.tsbDeleteReader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteReader.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteReader.Image")));
            this.tsbDeleteReader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteReader.Name = "tsbDeleteReader";
            this.tsbDeleteReader.Size = new System.Drawing.Size(83, 22);
            this.tsbDeleteReader.Text = "删除读者信息";
            this.tsbDeleteReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDeleteReader.Click += new System.EventHandler(this.tsbDeleteReader_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefreshAllReader
            // 
            this.tsbRefreshAllReader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRefreshAllReader.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefreshAllReader.Image")));
            this.tsbRefreshAllReader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefreshAllReader.Name = "tsbRefreshAllReader";
            this.tsbRefreshAllReader.Size = new System.Drawing.Size(155, 22);
            this.tsbRefreshAllReader.Text = "刷新显示当前所有读者信息";
            this.tsbRefreshAllReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRefreshAllReader.Click += new System.EventHandler(this.tsbRefreshAllReader_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvAllReader);
            this.groupBox1.Location = new System.Drawing.Point(4, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 433);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "所有读者信息";
            // 
            // dgvAllReader
            // 
            this.dgvAllReader.AllowUserToAddRows = false;
            this.dgvAllReader.AllowUserToDeleteRows = false;
            this.dgvAllReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllReader.Location = new System.Drawing.Point(3, 17);
            this.dgvAllReader.Name = "dgvAllReader";
            this.dgvAllReader.ReadOnly = true;
            this.dgvAllReader.RowTemplate.Height = 23;
            this.dgvAllReader.Size = new System.Drawing.Size(852, 413);
            this.dgvAllReader.TabIndex = 3;
            // 
            // formStatus1
            // 
            this.formStatus1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formStatus1.Location = new System.Drawing.Point(0, 476);
            this.formStatus1.Name = "formStatus1";
            this.formStatus1.Size = new System.Drawing.Size(865, 26);
            this.formStatus1.TabIndex = 3;
            // 
            // frmReaderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 502);
            this.Controls.Add(this.formStatus1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReaderManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读者信息维护";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddNewReader;
        private System.Windows.Forms.ToolStripButton tsbUpdateReader;
        private System.Windows.Forms.ToolStripButton tsbDeleteReader;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbRefreshAllReader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAllReader;
        private FormStatus formStatus1;
    }
}