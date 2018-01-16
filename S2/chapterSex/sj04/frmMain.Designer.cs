namespace sj04
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculation);
            this.groupBox1.Controls.Add(this.txtNum2);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.txtNum1);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计算";
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(440, 47);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(82, 24);
            this.btnCalculation.TabIndex = 3;
            this.btnCalculation.Text = "计算";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(313, 46);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(103, 25);
            this.txtNum2.TabIndex = 2;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(154, 48);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(126, 23);
            this.cboType.TabIndex = 1;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(29, 46);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(108, 25);
            this.txtNum1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "计算结果";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(307, 134);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(55, 15);
            this.lblSum.TabIndex = 2;
            this.lblSum.Text = "label2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 173);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSum;
    }
}

