namespace MyOffice
{
    partial class frmShow
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
            this.lvOffice = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEvaluation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chScorce = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvOffice
            // 
            this.lvOffice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chAge,
            this.chEvaluation,
            this.chScorce});
            this.lvOffice.FullRowSelect = true;
            this.lvOffice.Location = new System.Drawing.Point(12, 12);
            this.lvOffice.Name = "lvOffice";
            this.lvOffice.Size = new System.Drawing.Size(665, 369);
            this.lvOffice.TabIndex = 0;
            this.lvOffice.UseCompatibleStateImageBehavior = false;
            this.lvOffice.View = System.Windows.Forms.View.Details;
            this.lvOffice.DoubleClick += new System.EventHandler(this.lvOffice_DoubleClick);
            // 
            // chID
            // 
            this.chID.Text = "工号";
            // 
            // chName
            // 
            this.chName.Text = "姓名";
            // 
            // chAge
            // 
            this.chAge.Text = "年龄";
            // 
            // chEvaluation
            // 
            this.chEvaluation.Text = "评价";
            // 
            // chScorce
            // 
            this.chScorce.Text = "年度得分";
            this.chScorce.Width = 148;
            // 
            // frmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 393);
            this.Controls.Add(this.lvOffice);
            this.Name = "frmShow";
            this.Text = "查看评分";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvOffice;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.ColumnHeader chEvaluation;
        private System.Windows.Forms.ColumnHeader chScorce;
    }
}

