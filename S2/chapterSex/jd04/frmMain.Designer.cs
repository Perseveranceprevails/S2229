namespace jd04
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnGetmoney = new System.Windows.Forms.Button();
            this.lblmoney1 = new System.Windows.Forms.Label();
            this.lblmoney2 = new System.Windows.Forms.Label();
            this.lblSparmoney = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPassmoney = new System.Windows.Forms.Button();
            this.lblmoney3 = new System.Windows.Forms.Label();
            this.lblCard1 = new System.Windows.Forms.Label();
            this.txtGetmoney = new System.Windows.Forms.TextBox();
            this.txtPassmoney = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBankCard = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBankCard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnInsertCard = new System.Windows.Forms.Button();
            this.btnrefund = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGetmoney);
            this.groupBox1.Controls.Add(this.lblSparmoney);
            this.groupBox1.Controls.Add(this.lblmoney2);
            this.groupBox1.Controls.Add(this.lblmoney1);
            this.groupBox1.Controls.Add(this.btnGetmoney);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询取款";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(34, 36);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 32);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnGetmoney
            // 
            this.btnGetmoney.Location = new System.Drawing.Point(34, 85);
            this.btnGetmoney.Name = "btnGetmoney";
            this.btnGetmoney.Size = new System.Drawing.Size(75, 30);
            this.btnGetmoney.TabIndex = 0;
            this.btnGetmoney.Text = "取款";
            this.btnGetmoney.UseVisualStyleBackColor = true;
            this.btnGetmoney.Click += new System.EventHandler(this.btnGetmoney_Click);
            // 
            // lblmoney1
            // 
            this.lblmoney1.AutoSize = true;
            this.lblmoney1.Location = new System.Drawing.Point(169, 43);
            this.lblmoney1.Name = "lblmoney1";
            this.lblmoney1.Size = new System.Drawing.Size(52, 15);
            this.lblmoney1.TabIndex = 1;
            this.lblmoney1.Text = "余额：";
            // 
            // lblmoney2
            // 
            this.lblmoney2.AutoSize = true;
            this.lblmoney2.Location = new System.Drawing.Point(169, 93);
            this.lblmoney2.Name = "lblmoney2";
            this.lblmoney2.Size = new System.Drawing.Size(45, 15);
            this.lblmoney2.TabIndex = 1;
            this.lblmoney2.Text = "金额:";
            // 
            // lblSparmoney
            // 
            this.lblSparmoney.AutoSize = true;
            this.lblSparmoney.Location = new System.Drawing.Point(243, 44);
            this.lblSparmoney.Name = "lblSparmoney";
            this.lblSparmoney.Size = new System.Drawing.Size(55, 15);
            this.lblSparmoney.TabIndex = 1;
            this.lblSparmoney.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCard);
            this.groupBox2.Controls.Add(this.txtPassmoney);
            this.groupBox2.Controls.Add(this.lblCard1);
            this.groupBox2.Controls.Add(this.lblmoney3);
            this.groupBox2.Controls.Add(this.btnPassmoney);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "转账";
            // 
            // btnPassmoney
            // 
            this.btnPassmoney.Location = new System.Drawing.Point(34, 61);
            this.btnPassmoney.Name = "btnPassmoney";
            this.btnPassmoney.Size = new System.Drawing.Size(75, 28);
            this.btnPassmoney.TabIndex = 0;
            this.btnPassmoney.Text = "转账";
            this.btnPassmoney.UseVisualStyleBackColor = true;
            this.btnPassmoney.Click += new System.EventHandler(this.btnPassmoney_Click);
            // 
            // lblmoney3
            // 
            this.lblmoney3.AutoSize = true;
            this.lblmoney3.Location = new System.Drawing.Point(169, 50);
            this.lblmoney3.Name = "lblmoney3";
            this.lblmoney3.Size = new System.Drawing.Size(52, 15);
            this.lblmoney3.TabIndex = 1;
            this.lblmoney3.Text = "金额：";
            // 
            // lblCard1
            // 
            this.lblCard1.AutoSize = true;
            this.lblCard1.Location = new System.Drawing.Point(169, 94);
            this.lblCard1.Name = "lblCard1";
            this.lblCard1.Size = new System.Drawing.Size(52, 15);
            this.lblCard1.TabIndex = 1;
            this.lblCard1.Text = "账号：";
            // 
            // txtGetmoney
            // 
            this.txtGetmoney.Location = new System.Drawing.Point(217, 90);
            this.txtGetmoney.Name = "txtGetmoney";
            this.txtGetmoney.Size = new System.Drawing.Size(116, 25);
            this.txtGetmoney.TabIndex = 2;
            // 
            // txtPassmoney
            // 
            this.txtPassmoney.Location = new System.Drawing.Point(217, 47);
            this.txtPassmoney.Name = "txtPassmoney";
            this.txtPassmoney.Size = new System.Drawing.Size(116, 25);
            this.txtPassmoney.TabIndex = 2;
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(217, 91);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(116, 25);
            this.txtCard.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Controls.Add(this.lblBankCard);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "详细信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名：";
            // 
            // lblBankCard
            // 
            this.lblBankCard.AutoSize = true;
            this.lblBankCard.Location = new System.Drawing.Point(107, 49);
            this.lblBankCard.Name = "lblBankCard";
            this.lblBankCard.Size = new System.Drawing.Size(55, 15);
            this.lblBankCard.TabIndex = 1;
            this.lblBankCard.Text = "label3";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(107, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "账户：";
            // 
            // txtBankCard
            // 
            this.txtBankCard.Location = new System.Drawing.Point(107, 461);
            this.txtBankCard.Name = "txtBankCard";
            this.txtBankCard.Size = new System.Drawing.Size(118, 25);
            this.txtBankCard.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "密码：";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(313, 461);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(137, 25);
            this.txtPwd.TabIndex = 4;
            // 
            // btnInsertCard
            // 
            this.btnInsertCard.Location = new System.Drawing.Point(71, 511);
            this.btnInsertCard.Name = "btnInsertCard";
            this.btnInsertCard.Size = new System.Drawing.Size(77, 26);
            this.btnInsertCard.TabIndex = 5;
            this.btnInsertCard.Text = "插卡";
            this.btnInsertCard.UseVisualStyleBackColor = true;
            this.btnInsertCard.Click += new System.EventHandler(this.btnInsertCard_Click);
            // 
            // btnrefund
            // 
            this.btnrefund.Location = new System.Drawing.Point(170, 511);
            this.btnrefund.Name = "btnrefund";
            this.btnrefund.Size = new System.Drawing.Size(76, 26);
            this.btnrefund.TabIndex = 5;
            this.btnrefund.Text = "退卡";
            this.btnrefund.UseVisualStyleBackColor = true;
            this.btnrefund.Click += new System.EventHandler(this.btnrefund_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(270, 511);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 549);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnrefund);
            this.Controls.Add(this.btnInsertCard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtBankCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGetmoney;
        private System.Windows.Forms.Label lblSparmoney;
        private System.Windows.Forms.Label lblmoney2;
        private System.Windows.Forms.Label lblmoney1;
        private System.Windows.Forms.Button btnGetmoney;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtPassmoney;
        private System.Windows.Forms.Label lblCard1;
        private System.Windows.Forms.Label lblmoney3;
        private System.Windows.Forms.Button btnPassmoney;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBankCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBankCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnInsertCard;
        private System.Windows.Forms.Button btnrefund;
        private System.Windows.Forms.Button btnClose;
    }
}

