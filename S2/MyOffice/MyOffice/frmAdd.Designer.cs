namespace MyOffice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSex);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息维护";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "保存";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 152);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 25);
            this.txtName.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(109, 103);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(150, 25);
            this.txtAge.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 25);
            this.txtId.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(66, 106);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 15);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "年龄";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(66, 203);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(37, 15);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "性别";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(66, 155);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(66, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "工号";
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(109, 200);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(150, 23);
            this.cboSex.TabIndex = 4;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 375);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdd";
            this.Text = "员工信息维护";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cboSex;
    }
}