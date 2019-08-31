namespace BookManageSystem
{
    partial class frmBookSortManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookSortManage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddSort = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteSort = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSortCaption = new System.Windows.Forms.TextBox();
            this.tbSortID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAllSortInfo = new System.Windows.Forms.DataGridView();
            this.formStatus1 = new BookManageSystem.FormStatus();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSortInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddSort,
            this.tsbDeleteSort});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(526, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddSort
            // 
            this.tsbAddSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddSort.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddSort.Image")));
            this.tsbAddSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddSort.Name = "tsbAddSort";
            this.tsbAddSort.Size = new System.Drawing.Size(57, 22);
            this.tsbAddSort.Text = "添加类别";
            this.tsbAddSort.Click += new System.EventHandler(this.tsbAddSort_Click);
            // 
            // tsbDeleteSort
            // 
            this.tsbDeleteSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteSort.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteSort.Image")));
            this.tsbDeleteSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteSort.Name = "tsbDeleteSort";
            this.tsbDeleteSort.Size = new System.Drawing.Size(57, 22);
            this.tsbDeleteSort.Text = "删除类别";
            this.tsbDeleteSort.Click += new System.EventHandler(this.tsbDeleteSort_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSortCaption);
            this.groupBox1.Controls.Add(this.tbSortID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类别信息";
            // 
            // tbSortCaption
            // 
            this.tbSortCaption.Location = new System.Drawing.Point(292, 17);
            this.tbSortCaption.Name = "tbSortCaption";
            this.tbSortCaption.Size = new System.Drawing.Size(126, 21);
            this.tbSortCaption.TabIndex = 1;
            // 
            // tbSortID
            // 
            this.tbSortID.Location = new System.Drawing.Point(81, 17);
            this.tbSortID.Name = "tbSortID";
            this.tbSortID.Size = new System.Drawing.Size(115, 21);
            this.tbSortID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "类别说明";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类别编号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAllSortInfo);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 223);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "所有类别信息";
            // 
            // dgvAllSortInfo
            // 
            this.dgvAllSortInfo.AllowUserToAddRows = false;
            this.dgvAllSortInfo.AllowUserToDeleteRows = false;
            this.dgvAllSortInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllSortInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllSortInfo.Location = new System.Drawing.Point(3, 17);
            this.dgvAllSortInfo.Name = "dgvAllSortInfo";
            this.dgvAllSortInfo.ReadOnly = true;
            this.dgvAllSortInfo.RowTemplate.Height = 23;
            this.dgvAllSortInfo.Size = new System.Drawing.Size(496, 203);
            this.dgvAllSortInfo.TabIndex = 2;
            // 
            // formStatus1
            // 
            this.formStatus1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formStatus1.Location = new System.Drawing.Point(0, 349);
            this.formStatus1.Name = "formStatus1";
            this.formStatus1.Size = new System.Drawing.Size(526, 26);
            this.formStatus1.TabIndex = 3;
            // 
            // frmBookSortManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 375);
            this.Controls.Add(this.formStatus1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookSortManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书卡片类别管理";
            this.Load += new System.EventHandler(this.frmBookSortManage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSortInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddSort;
        private System.Windows.Forms.ToolStripButton tsbDeleteSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAllSortInfo;
        private System.Windows.Forms.TextBox tbSortCaption;
        private System.Windows.Forms.TextBox tbSortID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FormStatus formStatus1;
    }
}