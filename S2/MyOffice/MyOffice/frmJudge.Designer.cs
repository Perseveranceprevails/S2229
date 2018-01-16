namespace MyOffice
{
    partial class frmJudge
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEvaluation = new System.Windows.Forms.Label();
            this.lblScorce = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEvaluation = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnEvaluation = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(61, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "员工姓名：";
            // 
            // lblEvaluation
            // 
            this.lblEvaluation.AutoSize = true;
            this.lblEvaluation.Location = new System.Drawing.Point(61, 106);
            this.lblEvaluation.Name = "lblEvaluation";
            this.lblEvaluation.Size = new System.Drawing.Size(82, 15);
            this.lblEvaluation.TabIndex = 0;
            this.lblEvaluation.Text = "填写评价：";
            // 
            // lblScorce
            // 
            this.lblScorce.AutoSize = true;
            this.lblScorce.Location = new System.Drawing.Point(61, 238);
            this.lblScorce.Name = "lblScorce";
            this.lblScorce.Size = new System.Drawing.Size(82, 15);
            this.lblScorce.TabIndex = 0;
            this.lblScorce.Text = "年度评分：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 48);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(219, 25);
            this.txtName.TabIndex = 1;
            // 
            // txtEvaluation
            // 
            this.txtEvaluation.Location = new System.Drawing.Point(149, 103);
            this.txtEvaluation.Multiline = true;
            this.txtEvaluation.Name = "txtEvaluation";
            this.txtEvaluation.Size = new System.Drawing.Size(219, 104);
            this.txtEvaluation.TabIndex = 1;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(149, 235);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(219, 25);
            this.txtScore.TabIndex = 1;
            // 
            // btnEvaluation
            // 
            this.btnEvaluation.Location = new System.Drawing.Point(131, 312);
            this.btnEvaluation.Name = "btnEvaluation";
            this.btnEvaluation.Size = new System.Drawing.Size(78, 30);
            this.btnEvaluation.TabIndex = 2;
            this.btnEvaluation.Text = "评分";
            this.btnEvaluation.UseVisualStyleBackColor = true;
            this.btnEvaluation.Click += new System.EventHandler(this.btnEvaluation_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(259, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "取消";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // frmJudge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 408);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEvaluation);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtEvaluation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblScorce);
            this.Controls.Add(this.lblEvaluation);
            this.Controls.Add(this.lblName);
            this.Name = "frmJudge";
            this.Text = "评分";
            this.Load += new System.EventHandler(this.frmJudge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEvaluation;
        private System.Windows.Forms.Label lblScorce;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEvaluation;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnEvaluation;
        private System.Windows.Forms.Button btnClear;
    }
}