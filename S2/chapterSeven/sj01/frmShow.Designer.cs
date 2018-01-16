namespace sj01
{
    partial class frmShow
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
            this.gbShow = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.rbtnSach = new System.Windows.Forms.RadioButton();
            this.rbtnViolin = new System.Windows.Forms.RadioButton();
            this.rbtnPiano = new System.Windows.Forms.RadioButton();
            this.gbShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbShow
            // 
            this.gbShow.Controls.Add(this.btnPlay);
            this.gbShow.Controls.Add(this.rbtnSach);
            this.gbShow.Controls.Add(this.rbtnViolin);
            this.gbShow.Controls.Add(this.rbtnPiano);
            this.gbShow.Location = new System.Drawing.Point(53, 39);
            this.gbShow.Name = "gbShow";
            this.gbShow.Size = new System.Drawing.Size(315, 250);
            this.gbShow.TabIndex = 0;
            this.gbShow.TabStop = false;
            this.gbShow.Text = "....";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(58, 205);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(73, 28);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "演奏";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // rbtnSach
            // 
            this.rbtnSach.AutoSize = true;
            this.rbtnSach.Location = new System.Drawing.Point(58, 153);
            this.rbtnSach.Name = "rbtnSach";
            this.rbtnSach.Size = new System.Drawing.Size(73, 19);
            this.rbtnSach.TabIndex = 2;
            this.rbtnSach.TabStop = true;
            this.rbtnSach.Text = "萨克斯";
            this.rbtnSach.UseVisualStyleBackColor = true;
            // 
            // rbtnViolin
            // 
            this.rbtnViolin.AutoSize = true;
            this.rbtnViolin.Location = new System.Drawing.Point(58, 96);
            this.rbtnViolin.Name = "rbtnViolin";
            this.rbtnViolin.Size = new System.Drawing.Size(73, 19);
            this.rbtnViolin.TabIndex = 1;
            this.rbtnViolin.TabStop = true;
            this.rbtnViolin.Text = "小提琴";
            this.rbtnViolin.UseVisualStyleBackColor = true;
            // 
            // rbtnPiano
            // 
            this.rbtnPiano.AutoSize = true;
            this.rbtnPiano.Location = new System.Drawing.Point(58, 44);
            this.rbtnPiano.Name = "rbtnPiano";
            this.rbtnPiano.Size = new System.Drawing.Size(58, 19);
            this.rbtnPiano.TabIndex = 0;
            this.rbtnPiano.TabStop = true;
            this.rbtnPiano.Text = "钢琴";
            this.rbtnPiano.UseVisualStyleBackColor = true;
            // 
            // frmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 354);
            this.Controls.Add(this.gbShow);
            this.Name = "frmShow";
            this.Text = "frmShow";
            this.gbShow.ResumeLayout(false);
            this.gbShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbShow;
        private System.Windows.Forms.RadioButton rbtnSach;
        private System.Windows.Forms.RadioButton rbtnViolin;
        private System.Windows.Forms.RadioButton rbtnPiano;
        private System.Windows.Forms.Button btnPlay;
    }
}