namespace sj02
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
            this.components = new System.ComponentModel.Container();
            this.gbSE = new System.Windows.Forms.GroupBox();
            this.dgvJobList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.执行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完成情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSE
            // 
            this.gbSE.Controls.Add(this.dgvJobList);
            this.gbSE.Location = new System.Drawing.Point(12, 12);
            this.gbSE.Name = "gbSE";
            this.gbSE.Size = new System.Drawing.Size(645, 403);
            this.gbSE.TabIndex = 0;
            this.gbSE.TabStop = false;
            this.gbSE.Text = "姓名";
            // 
            // dgvJobList
            // 
            this.dgvJobList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3});
            this.dgvJobList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvJobList.Location = new System.Drawing.Point(20, 24);
            this.dgvJobList.MultiSelect = false;
            this.dgvJobList.Name = "dgvJobList";
            this.dgvJobList.RowTemplate.Height = 27;
            this.dgvJobList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobList.Size = new System.Drawing.Size(604, 355);
            this.dgvJobList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.执行ToolStripMenuItem,
            this.完成情况ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 52);
            // 
            // 执行ToolStripMenuItem
            // 
            this.执行ToolStripMenuItem.Name = "执行ToolStripMenuItem";
            this.执行ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.执行ToolStripMenuItem.Text = "执行";
            this.执行ToolStripMenuItem.Click += new System.EventHandler(this.执行ToolStripMenuItem_Click);
            // 
            // 完成情况ToolStripMenuItem
            // 
            this.完成情况ToolStripMenuItem.Name = "完成情况ToolStripMenuItem";
            this.完成情况ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.完成情况ToolStripMenuItem.Text = "完成情况";
            this.完成情况ToolStripMenuItem.Click += new System.EventHandler(this.完成情况ToolStripMenuItem_Click);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "工作名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Type";
            this.Column1.HeaderText = "工作类型";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Description";
            this.Column3.HeaderText = "工作描述";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 427);
            this.Controls.Add(this.gbSE);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.gbSE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSE;
        private System.Windows.Forms.DataGridView dgvJobList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 执行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完成情况ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

