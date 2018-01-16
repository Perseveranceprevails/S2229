namespace WindowsFormsApplication1
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
            this.btnJob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJob
            // 
            this.btnJob.Location = new System.Drawing.Point(83, 49);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(154, 40);
            this.btnJob.TabIndex = 0;
            this.btnJob.Text = "员工汇报工作";
            this.btnJob.UseVisualStyleBackColor = true;
            this.btnJob.Click += new System.EventHandler(this.btnJob_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 156);
            this.Controls.Add(this.btnJob);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJob;
    }
}

