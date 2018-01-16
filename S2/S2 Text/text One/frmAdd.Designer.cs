namespace text_One
{
    partial class frmAdd
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblShi = new System.Windows.Forms.Label();
            this.lblYuName = new System.Windows.Forms.Label();
            this.lblLuName = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtShi = new System.Windows.Forms.TextBox();
            this.txtYuName = new System.Windows.Forms.TextBox();
            this.txtluName = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdd.Location = new System.Drawing.Point(127, 28);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(157, 28);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "会议室预订";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(84, 127);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 15);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "预定日期：";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(84, 170);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(67, 15);
            this.lblRoom.TabIndex = 1;
            this.lblRoom.Text = "会议室：";
            // 
            // lblShi
            // 
            this.lblShi.AutoSize = true;
            this.lblShi.Location = new System.Drawing.Point(84, 208);
            this.lblShi.Name = "lblShi";
            this.lblShi.Size = new System.Drawing.Size(82, 15);
            this.lblShi.TabIndex = 1;
            this.lblShi.Text = "预定事由：";
            // 
            // lblYuName
            // 
            this.lblYuName.AutoSize = true;
            this.lblYuName.Location = new System.Drawing.Point(84, 249);
            this.lblYuName.Name = "lblYuName";
            this.lblYuName.Size = new System.Drawing.Size(67, 15);
            this.lblYuName.TabIndex = 1;
            this.lblYuName.Text = "预定人：";
            // 
            // lblLuName
            // 
            this.lblLuName.AutoSize = true;
            this.lblLuName.Location = new System.Drawing.Point(84, 287);
            this.lblLuName.Name = "lblLuName";
            this.lblLuName.Size = new System.Drawing.Size(67, 15);
            this.lblLuName.TabIndex = 1;
            this.lblLuName.Text = "录入人：";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(172, 124);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(161, 25);
            this.txtTime.TabIndex = 2;
            // 
            // txtShi
            // 
            this.txtShi.Location = new System.Drawing.Point(172, 205);
            this.txtShi.Name = "txtShi";
            this.txtShi.Size = new System.Drawing.Size(326, 25);
            this.txtShi.TabIndex = 2;
            // 
            // txtYuName
            // 
            this.txtYuName.Location = new System.Drawing.Point(172, 246);
            this.txtYuName.Name = "txtYuName";
            this.txtYuName.Size = new System.Drawing.Size(161, 25);
            this.txtYuName.TabIndex = 2;
            // 
            // txtluName
            // 
            this.txtluName.Location = new System.Drawing.Point(172, 284);
            this.txtluName.Name = "txtluName";
            this.txtluName.Size = new System.Drawing.Size(161, 25);
            this.txtluName.TabIndex = 2;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(172, 167);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(161, 25);
            this.txtRoom.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 385);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "确定";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(184, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(297, 385);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 456);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtluName);
            this.Controls.Add(this.txtYuName);
            this.Controls.Add(this.txtShi);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblLuName);
            this.Controls.Add(this.lblYuName);
            this.Controls.Add(this.lblShi);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblAdd);
            this.Name = "frmAdd";
            this.Text = "会议室预订录入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblShi;
        private System.Windows.Forms.Label lblYuName;
        private System.Windows.Forms.Label lblLuName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtShi;
        private System.Windows.Forms.TextBox txtYuName;
        private System.Windows.Forms.TextBox txtluName;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}