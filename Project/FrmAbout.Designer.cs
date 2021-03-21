namespace Elvo
{
    partial class FrmAbout
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
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.lbAboutTitle = new System.Windows.Forms.Label();
            this.lbAbout = new System.Windows.Forms.Label();
            this.lbDesign = new System.Windows.Forms.Label();
            this.lbDesignTitle = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lnkBlog = new System.Windows.Forms.LinkLabel();
            this.lnkElsInfo = new System.Windows.Forms.LinkLabel();
            this.lnkGit = new System.Windows.Forms.LinkLabel();
            this.lnkDot = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // picAbout
            // 
            this.picAbout.BackColor = System.Drawing.Color.Transparent;
            this.picAbout.Cursor = System.Windows.Forms.Cursors.Default;
            this.picAbout.Image = global::Elvo.Properties.Resources.about;
            this.picAbout.Location = new System.Drawing.Point(0, 0);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(270, 155);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAbout.TabIndex = 1;
            this.picAbout.TabStop = false;
            // 
            // lbAboutTitle
            // 
            this.lbAboutTitle.AutoSize = true;
            this.lbAboutTitle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbAboutTitle.ForeColor = System.Drawing.Color.White;
            this.lbAboutTitle.Location = new System.Drawing.Point(49, 166);
            this.lbAboutTitle.Name = "lbAboutTitle";
            this.lbAboutTitle.Size = new System.Drawing.Size(68, 17);
            this.lbAboutTitle.TabIndex = 2;
            this.lbAboutTitle.Text = "Version：";
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbAbout.ForeColor = System.Drawing.Color.White;
            this.lbAbout.Location = new System.Drawing.Point(117, 166);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(34, 17);
            this.lbAbout.TabIndex = 3;
            this.lbAbout.Text = "版本";
            // 
            // lbDesign
            // 
            this.lbDesign.AutoSize = true;
            this.lbDesign.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbDesign.ForeColor = System.Drawing.Color.White;
            this.lbDesign.Location = new System.Drawing.Point(117, 193);
            this.lbDesign.Name = "lbDesign";
            this.lbDesign.Size = new System.Drawing.Size(126, 17);
            this.lbDesign.TabIndex = 5;
            this.lbDesign.Text = "IncrEdbiLe (Robby)";
            // 
            // lbDesignTitle
            // 
            this.lbDesignTitle.AutoSize = true;
            this.lbDesignTitle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbDesignTitle.ForeColor = System.Drawing.Color.White;
            this.lbDesignTitle.Location = new System.Drawing.Point(49, 193);
            this.lbDesignTitle.Name = "lbDesignTitle";
            this.lbDesignTitle.Size = new System.Drawing.Size(64, 17);
            this.lbDesignTitle.TabIndex = 4;
            this.lbDesignTitle.Text = "Design：";
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::Elvo.Properties.Resources.control_exit1;
            this.picExit.Location = new System.Drawing.Point(238, 242);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(20, 20);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 6;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // lnkBlog
            // 
            this.lnkBlog.AutoSize = true;
            this.lnkBlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkBlog.ForeColor = System.Drawing.Color.White;
            this.lnkBlog.LinkColor = System.Drawing.Color.White;
            this.lnkBlog.Location = new System.Drawing.Point(50, 224);
            this.lnkBlog.Name = "lnkBlog";
            this.lnkBlog.Size = new System.Drawing.Size(103, 12);
            this.lnkBlog.TabIndex = 9;
            this.lnkBlog.TabStop = true;
            this.lnkBlog.Text = "艾爾之光日配 Blog";
            this.lnkBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBlog_LinkClicked);
            // 
            // lnkElsInfo
            // 
            this.lnkElsInfo.AutoSize = true;
            this.lnkElsInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkElsInfo.ForeColor = System.Drawing.Color.White;
            this.lnkElsInfo.LinkColor = System.Drawing.Color.White;
            this.lnkElsInfo.Location = new System.Drawing.Point(50, 250);
            this.lnkElsInfo.Name = "lnkElsInfo";
            this.lnkElsInfo.Size = new System.Drawing.Size(52, 12);
            this.lnkElsInfo.TabIndex = 10;
            this.lnkElsInfo.TabStop = true;
            this.lnkElsInfo.Text = "FaceBook";
            this.lnkElsInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkElsInfo_LinkClicked);
            // 
            // lnkGit
            // 
            this.lnkGit.AutoSize = true;
            this.lnkGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkGit.ForeColor = System.Drawing.Color.White;
            this.lnkGit.LinkColor = System.Drawing.Color.White;
            this.lnkGit.Location = new System.Drawing.Point(110, 250);
            this.lnkGit.Name = "lnkGit";
            this.lnkGit.Size = new System.Drawing.Size(39, 12);
            this.lnkGit.TabIndex = 11;
            this.lnkGit.TabStop = true;
            this.lnkGit.Text = "GitHub";
            this.lnkGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGit_LinkClicked);
            // 
            // lnkDot
            // 
            this.lnkDot.AutoSize = true;
            this.lnkDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkDot.ForeColor = System.Drawing.Color.White;
            this.lnkDot.LinkColor = System.Drawing.Color.White;
            this.lnkDot.Location = new System.Drawing.Point(156, 250);
            this.lnkDot.Name = "lnkDot";
            this.lnkDot.Size = new System.Drawing.Size(49, 12);
            this.lnkDot.TabIndex = 12;
            this.lnkDot.TabStop = true;
            this.lnkDot.Text = "DotBlogs";
            this.lnkDot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDot_LinkClicked);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(137)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(270, 280);
            this.Controls.Add(this.lnkDot);
            this.Controls.Add(this.lnkGit);
            this.Controls.Add(this.lnkElsInfo);
            this.Controls.Add(this.lnkBlog);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lbDesign);
            this.Controls.Add(this.lbDesignTitle);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.lbAboutTitle);
            this.Controls.Add(this.picAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAbout";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.Label lbAboutTitle;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.Label lbDesign;
        private System.Windows.Forms.Label lbDesignTitle;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.LinkLabel lnkBlog;
        private System.Windows.Forms.LinkLabel lnkElsInfo;
        private System.Windows.Forms.LinkLabel lnkGit;
        private System.Windows.Forms.LinkLabel lnkDot;
    }
}