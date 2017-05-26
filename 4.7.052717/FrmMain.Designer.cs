namespace ElswordVoice
{
    partial class FrmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timLoad = new System.Windows.Forms.Timer(this.components);
            this.bwkRecover = new System.ComponentModel.BackgroundWorker();
            this.bwkReplace = new System.ComponentModel.BackgroundWorker();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.noficon = new System.Windows.Forms.NotifyIcon(this.components);
            this.conMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.itemRecovery = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.sep4 = new System.Windows.Forms.ToolStripSeparator();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.timAlert = new System.Windows.Forms.Timer(this.components);
            this.conMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.item_Exit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.conMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            this.conMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timLoad
            // 
            this.timLoad.Interval = 300;
            this.timLoad.Tick += new System.EventHandler(this.timLoad_Tick);
            // 
            // bwkRecover
            // 
            this.bwkRecover.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwkRecover_DoWork);
            this.bwkRecover.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwkRecover_RunWorkerCompleted);
            // 
            // bwkReplace
            // 
            this.bwkReplace.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwkReplace_DoWork);
            this.bwkReplace.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwkReplace_RunWorkerCompleted);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picExit.Image = global::ElswordVoice.Properties.Resources.imgExit2;
            this.picExit.Location = new System.Drawing.Point(158, 78);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(64, 59);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 1;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // noficon
            // 
            this.noficon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.noficon.ContextMenuStrip = this.conMenu;
            this.noficon.Text = "123";
            this.noficon.Visible = true;
            this.noficon.DoubleClick += new System.EventHandler(this.noficon_DoubleClick);
            // 
            // conMenu
            // 
            this.conMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemVersion,
            this.itemOpen,
            this.sep1,
            this.itemUpdate,
            this.sep2,
            this.itemInfo,
            this.sep3,
            this.itemRecovery,
            this.itemMsg,
            this.itemAbout,
            this.sep4,
            this.itemExit});
            this.conMenu.Name = "contextMenuStrip1";
            this.conMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.conMenu.Size = new System.Drawing.Size(135, 204);
            // 
            // itemVersion
            // 
            this.itemVersion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.itemVersion.Enabled = false;
            this.itemVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.itemVersion.Name = "itemVersion";
            this.itemVersion.Size = new System.Drawing.Size(134, 22);
            this.itemVersion.ToolTipText = "版本君：我不能按ㄛ~";
            // 
            // itemOpen
            // 
            this.itemOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.Size = new System.Drawing.Size(134, 22);
            this.itemOpen.Text = "打開主視窗";
            this.itemOpen.ToolTipText = "打開轉換器~";
            this.itemOpen.Click += new System.EventHandler(this.itemOpen_Click);
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(131, 6);
            // 
            // itemUpdate
            // 
            this.itemUpdate.BackColor = System.Drawing.Color.Transparent;
            this.itemUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.itemUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.itemUpdate.Image = global::ElswordVoice.Properties.Resources.itemUpdate;
            this.itemUpdate.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.itemUpdate.Name = "itemUpdate";
            this.itemUpdate.Size = new System.Drawing.Size(134, 22);
            this.itemUpdate.Text = "檢查更新";
            this.itemUpdate.ToolTipText = "檢查看看有沒有新的版本OwO";
            this.itemUpdate.Click += new System.EventHandler(this.itemUpdate_Click);
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(131, 6);
            // 
            // itemInfo
            // 
            this.itemInfo.Name = "itemInfo";
            this.itemInfo.Size = new System.Drawing.Size(134, 22);
            this.itemInfo.Text = "公告消息";
            this.itemInfo.ToolTipText = "讀取目前軟體的公告。";
            this.itemInfo.Click += new System.EventHandler(this.itemInfo_Click);
            // 
            // sep3
            // 
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(131, 6);
            // 
            // itemRecovery
            // 
            this.itemRecovery.Name = "itemRecovery";
            this.itemRecovery.Size = new System.Drawing.Size(134, 22);
            this.itemRecovery.Text = "手動還原";
            this.itemRecovery.ToolTipText = "如果要完全取消使用日配，請點擊此。";
            this.itemRecovery.Click += new System.EventHandler(this.itemRecovery_Click);
            // 
            // itemMsg
            // 
            this.itemMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.itemMsg.Name = "itemMsg";
            this.itemMsg.Size = new System.Drawing.Size(134, 22);
            this.itemMsg.Text = "問題回報";
            this.itemMsg.ToolTipText = "傳送問題回報，有Ｍail者記得填寫\r\n不然沒辦法回信呀 QAQ";
            this.itemMsg.Click += new System.EventHandler(this.itemMsg_Click);
            // 
            // itemAbout
            // 
            this.itemAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.itemAbout.Name = "itemAbout";
            this.itemAbout.Size = new System.Drawing.Size(134, 22);
            this.itemAbout.Text = "關於";
            this.itemAbout.ToolTipText = "看看現在你用der是蛇馬版本?";
            this.itemAbout.Click += new System.EventHandler(this.itemAbout_Click);
            // 
            // sep4
            // 
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(131, 6);
            // 
            // itemExit
            // 
            this.itemExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(134, 22);
            this.itemExit.Text = "結束";
            this.itemExit.ToolTipText = "不要拋7ˋ我 QAQ";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // picLoad
            // 
            this.picLoad.BackColor = System.Drawing.Color.Transparent;
            this.picLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLoad.Cursor = System.Windows.Forms.Cursors.Default;
            this.picLoad.Image = global::ElswordVoice.Properties.Resources.loading2;
            this.picLoad.Location = new System.Drawing.Point(12, 199);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(256, 150);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoad.TabIndex = 4;
            this.picLoad.TabStop = false;
            this.picLoad.Visible = false;
            // 
            // timAlert
            // 
            this.timAlert.Interval = 1000;
            this.timAlert.Tick += new System.EventHandler(this.timAlert_Tick);
            // 
            // conMain
            // 
            this.conMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_Exit});
            this.conMain.Name = "contextMenuStrip1";
            this.conMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.conMain.Size = new System.Drawing.Size(99, 26);
            // 
            // item_Exit
            // 
            this.item_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.item_Exit.Name = "item_Exit";
            this.item_Exit.Size = new System.Drawing.Size(98, 22);
            this.item_Exit.Text = "結束";
            this.item_Exit.ToolTipText = "不要拋7ˋ我 QAQ";
            this.item_Exit.Click += new System.EventHandler(this.item_Exit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(350, 495);
            this.ContextMenuStrip = this.conMain;
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.picExit);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElswordVoice";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.conMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            this.conMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timLoad;
        private System.ComponentModel.BackgroundWorker bwkRecover;
        private System.ComponentModel.BackgroundWorker bwkReplace;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.NotifyIcon noficon;
        private System.Windows.Forms.ContextMenuStrip conMenu;
        private System.Windows.Forms.ToolStripMenuItem itemVersion;
        private System.Windows.Forms.ToolStripMenuItem itemOpen;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripMenuItem itemUpdate;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripMenuItem itemMsg;
        private System.Windows.Forms.ToolStripMenuItem itemAbout;
        private System.Windows.Forms.ToolStripSeparator sep4;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.Timer timAlert;
        private System.Windows.Forms.ContextMenuStrip conMain;
        private System.Windows.Forms.ToolStripMenuItem item_Exit;
        private System.Windows.Forms.ToolStripMenuItem itemRecovery;
        private System.Windows.Forms.ToolStripSeparator sep3;
        private System.Windows.Forms.ToolStripMenuItem itemInfo;
    }
}

