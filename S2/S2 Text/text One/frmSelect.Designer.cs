namespace text_One
{
    partial class frmSelect
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
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestineDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoardroomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestineReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestineMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(128, 47);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(97, 15);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "会议室名称：";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(231, 44);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(314, 25);
            this.txtRoom.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(568, 43);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // dgvRoom
            // 
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DestineDate,
            this.BoardroomName,
            this.DestineReason,
            this.DestineMan,
            this.NoteMan});
            this.dgvRoom.Location = new System.Drawing.Point(35, 75);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowTemplate.Height = 27;
            this.dgvRoom.Size = new System.Drawing.Size(721, 361);
            this.dgvRoom.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DestineDate
            // 
            this.DestineDate.DataPropertyName = "DestineDate";
            this.DestineDate.HeaderText = "预定日期";
            this.DestineDate.Name = "DestineDate";
            this.DestineDate.ReadOnly = true;
            // 
            // BoardroomName
            // 
            this.BoardroomName.DataPropertyName = "BoardroomName";
            this.BoardroomName.HeaderText = "会议室";
            this.BoardroomName.Name = "BoardroomName";
            this.BoardroomName.ReadOnly = true;
            // 
            // DestineReason
            // 
            this.DestineReason.DataPropertyName = "DestineReason";
            this.DestineReason.HeaderText = "预定事由";
            this.DestineReason.Name = "DestineReason";
            this.DestineReason.ReadOnly = true;
            // 
            // DestineMan
            // 
            this.DestineMan.DataPropertyName = "DestineMan";
            this.DestineMan.HeaderText = "预定人";
            this.DestineMan.Name = "DestineMan";
            this.DestineMan.ReadOnly = true;
            // 
            // NoteMan
            // 
            this.NoteMan.DataPropertyName = "NoteMan";
            this.NoteMan.HeaderText = "录入人";
            this.NoteMan.Name = "NoteMan";
            this.NoteMan.ReadOnly = true;
            // 
            // frmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 472);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.lblRoom);
            this.Name = "frmSelect";
            this.Text = "预定记录";
            this.Load += new System.EventHandler(this.frmSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestineDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoardroomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestineReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestineMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteMan;
    }
}