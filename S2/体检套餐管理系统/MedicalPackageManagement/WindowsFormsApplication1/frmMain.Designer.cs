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
            this.gbMaintenance = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.lblSelectPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSelectName = new System.Windows.Forms.Label();
            this.cbolitemsList = new System.Windows.Forms.ComboBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.cboSetList = new System.Windows.Forms.ComboBox();
            this.lblNameList = new System.Windows.Forms.Label();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnSetAdd = new System.Windows.Forms.Button();
            this.txtSetName = new System.Windows.Forms.TextBox();
            this.lblSetName = new System.Windows.Forms.Label();
            this.gbMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMaintenance
            // 
            this.gbMaintenance.Controls.Add(this.dgvList);
            this.gbMaintenance.Controls.Add(this.lblPrice);
            this.gbMaintenance.Controls.Add(this.btnDelete);
            this.gbMaintenance.Controls.Add(this.btnItemAdd);
            this.gbMaintenance.Controls.Add(this.lblSelectPrice);
            this.gbMaintenance.Controls.Add(this.lblName);
            this.gbMaintenance.Controls.Add(this.lblSelectName);
            this.gbMaintenance.Controls.Add(this.cbolitemsList);
            this.gbMaintenance.Controls.Add(this.lblItems);
            this.gbMaintenance.Controls.Add(this.cboSetList);
            this.gbMaintenance.Controls.Add(this.lblNameList);
            this.gbMaintenance.Location = new System.Drawing.Point(27, 142);
            this.gbMaintenance.Name = "gbMaintenance";
            this.gbMaintenance.Size = new System.Drawing.Size(669, 425);
            this.gbMaintenance.TabIndex = 0;
            this.gbMaintenance.TabStop = false;
            this.gbMaintenance.Text = "检查套餐维护";
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Description,
            this.Price});
            this.dgvList.Location = new System.Drawing.Point(44, 175);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 27;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(581, 231);
            this.dgvList.TabIndex = 10;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "项目名";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "描述";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "价格";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(395, 147);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(15, 15);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "0";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(480, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 28);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Location = new System.Drawing.Point(365, 100);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(83, 28);
            this.btnItemAdd.TabIndex = 7;
            this.btnItemAdd.Text = "添加";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // lblSelectPrice
            // 
            this.lblSelectPrice.AutoSize = true;
            this.lblSelectPrice.Location = new System.Drawing.Point(337, 147);
            this.lblSelectPrice.Name = "lblSelectPrice";
            this.lblSelectPrice.Size = new System.Drawing.Size(52, 15);
            this.lblSelectPrice.TabIndex = 6;
            this.lblSelectPrice.Text = "价格：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(141, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "label1";
            // 
            // lblSelectName
            // 
            this.lblSelectName.AutoSize = true;
            this.lblSelectName.Location = new System.Drawing.Point(75, 147);
            this.lblSelectName.Name = "lblSelectName";
            this.lblSelectName.Size = new System.Drawing.Size(60, 15);
            this.lblSelectName.TabIndex = 4;
            this.lblSelectName.Text = "套餐名:";
            // 
            // cbolitemsList
            // 
            this.cbolitemsList.FormattingEnabled = true;
            this.cbolitemsList.Location = new System.Drawing.Point(435, 49);
            this.cbolitemsList.Name = "cbolitemsList";
            this.cbolitemsList.Size = new System.Drawing.Size(150, 23);
            this.cbolitemsList.TabIndex = 3;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(362, 52);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(67, 15);
            this.lblItems.TabIndex = 2;
            this.lblItems.Text = "检查项目";
            // 
            // cboSetList
            // 
            this.cboSetList.FormattingEnabled = true;
            this.cboSetList.Location = new System.Drawing.Point(148, 49);
            this.cboSetList.Name = "cboSetList";
            this.cboSetList.Size = new System.Drawing.Size(181, 23);
            this.cboSetList.TabIndex = 1;
            this.cboSetList.SelectedIndexChanged += new System.EventHandler(this.cboSetList_SelectedIndexChanged);
            // 
            // lblNameList
            // 
            this.lblNameList.AutoSize = true;
            this.lblNameList.Location = new System.Drawing.Point(75, 52);
            this.lblNameList.Name = "lblNameList";
            this.lblNameList.Size = new System.Drawing.Size(67, 15);
            this.lblNameList.TabIndex = 0;
            this.lblNameList.Text = "套餐列表";
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btnSetAdd);
            this.gbAdd.Controls.Add(this.txtSetName);
            this.gbAdd.Controls.Add(this.lblSetName);
            this.gbAdd.Location = new System.Drawing.Point(27, 12);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(669, 107);
            this.gbAdd.TabIndex = 0;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "新建套餐";
            // 
            // btnSetAdd
            // 
            this.btnSetAdd.Location = new System.Drawing.Point(365, 57);
            this.btnSetAdd.Name = "btnSetAdd";
            this.btnSetAdd.Size = new System.Drawing.Size(76, 25);
            this.btnSetAdd.TabIndex = 2;
            this.btnSetAdd.Text = "添加";
            this.btnSetAdd.UseVisualStyleBackColor = true;
            this.btnSetAdd.Click += new System.EventHandler(this.btnSetAdd_Click);
            // 
            // txtSetName
            // 
            this.txtSetName.Location = new System.Drawing.Point(148, 57);
            this.txtSetName.Name = "txtSetName";
            this.txtSetName.Size = new System.Drawing.Size(181, 25);
            this.txtSetName.TabIndex = 1;
            // 
            // lblSetName
            // 
            this.lblSetName.AutoSize = true;
            this.lblSetName.Location = new System.Drawing.Point(75, 60);
            this.lblSetName.Name = "lblSetName";
            this.lblSetName.Size = new System.Drawing.Size(67, 15);
            this.lblSetName.TabIndex = 0;
            this.lblSetName.Text = "套餐名称";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 579);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.gbMaintenance);
            this.ForeColor = System.Drawing.Color.Black;
            this.Text = "体检套餐管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbMaintenance.ResumeLayout(false);
            this.gbMaintenance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMaintenance;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Label lblSelectPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSelectName;
        private System.Windows.Forms.ComboBox cbolitemsList;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.ComboBox cboSetList;
        private System.Windows.Forms.Label lblNameList;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnSetAdd;
        private System.Windows.Forms.TextBox txtSetName;
        private System.Windows.Forms.Label lblSetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

