namespace ElswordVoice
{
    partial class FrmInfo
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
            this.components = new System.ComponentModel.Container();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.lbInfoContent = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.timeInfo = new System.Windows.Forms.Timer(this.components);
            this.lbInfoDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // picInfo
            // 
            this.picInfo.BackColor = System.Drawing.Color.Transparent;
            this.picInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picInfo.Image = global::ElswordVoice.Properties.Resources.info;
            this.picInfo.Location = new System.Drawing.Point(25, 38);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(60, 60);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInfo.TabIndex = 0;
            this.picInfo.TabStop = false;
            // 
            // lbInfoContent
            // 
            this.lbInfoContent.AutoSize = true;
            this.lbInfoContent.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbInfoContent.ForeColor = System.Drawing.Color.White;
            this.lbInfoContent.Location = new System.Drawing.Point(91, 55);
            this.lbInfoContent.Name = "lbInfoContent";
            this.lbInfoContent.Size = new System.Drawing.Size(369, 26);
            this.lbInfoContent.TabIndex = 1;
            this.lbInfoContent.Text = "歡迎使用,使用上有任何問題請回報唷~";
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::ElswordVoice.Properties.Resources.control_exit1;
            this.picExit.Location = new System.Drawing.Point(468, 7);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(20, 20);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // timeInfo
            // 
            this.timeInfo.Enabled = true;
            this.timeInfo.Interval = 10;
            this.timeInfo.Tick += new System.EventHandler(this.timeInfo_Tick);
            // 
            // lbInfoDate
            // 
            this.lbInfoDate.AutoSize = true;
            this.lbInfoDate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbInfoDate.ForeColor = System.Drawing.Color.White;
            this.lbInfoDate.Location = new System.Drawing.Point(1, 3);
            this.lbInfoDate.Name = "lbInfoDate";
            this.lbInfoDate.Size = new System.Drawing.Size(72, 24);
            this.lbInfoDate.TabIndex = 8;
            this.lbInfoDate.Text = "公告－ ";
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(137)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(500, 100);
            this.Controls.Add(this.lbInfoDate);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lbInfoContent);
            this.Controls.Add(this.picInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInfo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Label lbInfoContent;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Timer timeInfo;
        private System.Windows.Forms.Label lbInfoDate;
    }
}