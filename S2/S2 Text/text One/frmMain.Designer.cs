namespace text_One
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
            this.msDestine = new System.Windows.Forms.MenuStrip();
            this.预定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msDestine.SuspendLayout();
            this.SuspendLayout();
            // 
            // msDestine
            // 
            this.msDestine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.预定ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.msDestine.Location = new System.Drawing.Point(0, 0);
            this.msDestine.Name = "msDestine";
            this.msDestine.Size = new System.Drawing.Size(829, 28);
            this.msDestine.TabIndex = 0;
            this.msDestine.Text = "menuStrip1";
            // 
            // 预定ToolStripMenuItem
            // 
            this.预定ToolStripMenuItem.Name = "预定ToolStripMenuItem";
            this.预定ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.预定ToolStripMenuItem.Text = "预定";
            this.预定ToolStripMenuItem.Click += new System.EventHandler(this.预定ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 687);
            this.Controls.Add(this.msDestine);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msDestine;
            this.Name = "frmMain";
            this.Text = "会议室预订系统";
            this.msDestine.ResumeLayout(false);
            this.msDestine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msDestine;
        private System.Windows.Forms.ToolStripMenuItem 预定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

