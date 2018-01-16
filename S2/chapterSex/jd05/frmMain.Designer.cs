namespace jd05
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnCircle = new System.Windows.Forms.RadioButton();
            this.rbtnRect = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnRed = new System.Windows.Forms.RadioButton();
            this.rbtnYellow = new System.Windows.Forms.RadioButton();
            this.rbtnBlue = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnRect);
            this.groupBox1.Controls.Add(this.rbtnCircle);
            this.groupBox1.Location = new System.Drawing.Point(386, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "圆形";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnBlue);
            this.groupBox2.Controls.Add(this.rbtnYellow);
            this.groupBox2.Controls.Add(this.rbtnRed);
            this.groupBox2.Location = new System.Drawing.Point(386, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "颜色";
            // 
            // rbtnCircle
            // 
            this.rbtnCircle.AutoSize = true;
            this.rbtnCircle.Location = new System.Drawing.Point(22, 34);
            this.rbtnCircle.Name = "rbtnCircle";
            this.rbtnCircle.Size = new System.Drawing.Size(58, 19);
            this.rbtnCircle.TabIndex = 0;
            this.rbtnCircle.TabStop = true;
            this.rbtnCircle.Text = "圆形";
            this.rbtnCircle.UseVisualStyleBackColor = true;
            // 
            // rbtnRect
            // 
            this.rbtnRect.AutoSize = true;
            this.rbtnRect.Location = new System.Drawing.Point(22, 76);
            this.rbtnRect.Name = "rbtnRect";
            this.rbtnRect.Size = new System.Drawing.Size(58, 19);
            this.rbtnRect.TabIndex = 1;
            this.rbtnRect.TabStop = true;
            this.rbtnRect.Text = "矩形";
            this.rbtnRect.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(52, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 267);
            this.panel1.TabIndex = 2;
            // 
            // rbtnRed
            // 
            this.rbtnRed.AutoSize = true;
            this.rbtnRed.Location = new System.Drawing.Point(22, 24);
            this.rbtnRed.Name = "rbtnRed";
            this.rbtnRed.Size = new System.Drawing.Size(58, 19);
            this.rbtnRed.TabIndex = 0;
            this.rbtnRed.TabStop = true;
            this.rbtnRed.Text = "红色";
            this.rbtnRed.UseVisualStyleBackColor = true;
            // 
            // rbtnYellow
            // 
            this.rbtnYellow.AutoSize = true;
            this.rbtnYellow.Location = new System.Drawing.Point(22, 58);
            this.rbtnYellow.Name = "rbtnYellow";
            this.rbtnYellow.Size = new System.Drawing.Size(58, 19);
            this.rbtnYellow.TabIndex = 1;
            this.rbtnYellow.TabStop = true;
            this.rbtnYellow.Text = "黄色";
            this.rbtnYellow.UseVisualStyleBackColor = true;
            // 
            // rbtnBlue
            // 
            this.rbtnBlue.AutoSize = true;
            this.rbtnBlue.Location = new System.Drawing.Point(22, 96);
            this.rbtnBlue.Name = "rbtnBlue";
            this.rbtnBlue.Size = new System.Drawing.Size(58, 19);
            this.rbtnBlue.TabIndex = 1;
            this.rbtnBlue.TabStop = true;
            this.rbtnBlue.Text = "蓝色";
            this.rbtnBlue.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(510, 303);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(77, 33);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "绘制";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 363);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnRect;
        private System.Windows.Forms.RadioButton rbtnCircle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnBlue;
        private System.Windows.Forms.RadioButton rbtnYellow;
        private System.Windows.Forms.RadioButton rbtnRed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
    }
}

