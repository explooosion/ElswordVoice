namespace ElswordVoice
{
    partial class FrmMessage
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lbPhoto = new System.Windows.Forms.Label();
            this.lbPhotoName = new System.Windows.Forms.Label();
            this.picViewPhoto = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhotoAddr = new System.Windows.Forms.Label();
            this.dialogPhoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picViewPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(24, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(97, 21);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "*角色暱稱：";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.BackColor = System.Drawing.Color.Transparent;
            this.lbSubject.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbSubject.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSubject.ForeColor = System.Drawing.Color.White;
            this.lbSubject.Location = new System.Drawing.Point(203, 13);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(65, 21);
            this.lbSubject.TabIndex = 1;
            this.lbSubject.Text = "*主旨：";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.BackColor = System.Drawing.Color.Transparent;
            this.lbContent.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbContent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbContent.ForeColor = System.Drawing.Color.White;
            this.lbContent.Location = new System.Drawing.Point(24, 156);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(65, 21);
            this.lbContent.TabIndex = 2;
            this.lbContent.Text = "*內文：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtName.Location = new System.Drawing.Point(28, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 29);
            this.txtName.TabIndex = 1;
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtSubject.Location = new System.Drawing.Point(207, 38);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(196, 29);
            this.txtSubject.TabIndex = 2;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtContent.Location = new System.Drawing.Point(28, 195);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(375, 97);
            this.txtContent.TabIndex = 4;
            // 
            // lbPhoto
            // 
            this.lbPhoto.AutoSize = true;
            this.lbPhoto.BackColor = System.Drawing.Color.Transparent;
            this.lbPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPhoto.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPhoto.ForeColor = System.Drawing.Color.White;
            this.lbPhoto.Location = new System.Drawing.Point(24, 327);
            this.lbPhoto.Name = "lbPhoto";
            this.lbPhoto.Size = new System.Drawing.Size(90, 21);
            this.lbPhoto.TabIndex = 6;
            this.lbPhoto.Text = "附加圖片：";
            // 
            // lbPhotoName
            // 
            this.lbPhotoName.AutoSize = true;
            this.lbPhotoName.BackColor = System.Drawing.Color.Transparent;
            this.lbPhotoName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPhotoName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPhotoName.ForeColor = System.Drawing.Color.White;
            this.lbPhotoName.Location = new System.Drawing.Point(120, 327);
            this.lbPhotoName.Name = "lbPhotoName";
            this.lbPhotoName.Size = new System.Drawing.Size(26, 21);
            this.lbPhotoName.TabIndex = 7;
            this.lbPhotoName.Text = "無";
            // 
            // picViewPhoto
            // 
            this.picViewPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(182)))));
            this.picViewPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picViewPhoto.Location = new System.Drawing.Point(28, 367);
            this.picViewPhoto.Name = "picViewPhoto";
            this.picViewPhoto.Size = new System.Drawing.Size(375, 130);
            this.picViewPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picViewPhoto.TabIndex = 8;
            this.picViewPhoto.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(137)))), ((int)(((byte)(207)))));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(247, 530);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 35);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "發送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(137)))), ((int)(((byte)(207)))));
            this.btnAddPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPhoto.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAddPhoto.Location = new System.Drawing.Point(328, 320);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(75, 35);
            this.btnAddPhoto.TabIndex = 5;
            this.btnAddPhoto.Text = "瀏覽...";
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(137)))), ((int)(((byte)(207)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(328, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtEmail.Location = new System.Drawing.Point(28, 113);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(375, 29);
            this.txtEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(24, 84);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(307, 21);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email（這樣才能回信唷，留白則自動）：";
            // 
            // lbPhotoAddr
            // 
            this.lbPhotoAddr.AutoSize = true;
            this.lbPhotoAddr.BackColor = System.Drawing.Color.Transparent;
            this.lbPhotoAddr.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPhotoAddr.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPhotoAddr.ForeColor = System.Drawing.Color.White;
            this.lbPhotoAddr.Location = new System.Drawing.Point(25, 500);
            this.lbPhotoAddr.Name = "lbPhotoAddr";
            this.lbPhotoAddr.Size = new System.Drawing.Size(14, 17);
            this.lbPhotoAddr.TabIndex = 14;
            this.lbPhotoAddr.Text = "-";
            // 
            // FrmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(137)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(432, 581);
            this.Controls.Add(this.lbPhotoAddr);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.picViewPhoto);
            this.Controls.Add(this.lbPhotoName);
            this.Controls.Add(this.lbPhoto);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMessage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMessage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picViewPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lbPhoto;
        private System.Windows.Forms.Label lbPhotoName;
        private System.Windows.Forms.PictureBox picViewPhoto;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhotoAddr;
        private System.Windows.Forms.OpenFileDialog dialogPhoto;
    }
}