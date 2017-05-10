using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ElswordVoice
{
    public partial class FrmMessage : Form
    {
        /**
          *意見表單 － 2016/02/14 IncrEdibLe (Robby)
          */

        Config.Initial ini = new Config.Initial();
        Config.Net net = new Config.Net();
        Config.Text txt = new Config.Text();

        bool Check = true;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private const int WM_LBUTTONDBLCLK = 0x00A3;

        public FrmMessage()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDBLCLK)
            {
                return;
            }

            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
            }
            base.WndProc(ref m);
        }

        private void FrmMessage_Load(object sender, EventArgs e)
        {
            ini.SetToolTip(picViewPhoto, txt.tip_view);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string _from = txtEmail.Text;
            foreach (Control con in this.Controls)
            {
                if (con is TextBox)
                {
                    if (((TextBox)con).Text == "")
                    {
                        if (((TextBox)con).Name == "txtEmail")
                        {
                            _from = "ta7382@yahoo.com.tw";
                        }
                        else
                        {
                            Check = false;
                        }
                    }
                }
            }

            if (Check == false)
            {
                MessageBox.Show(txt.msg_unpass, txt.msg_title_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Check = true;
                return;
            }

            net.SetMail(_from, "ta7382@gmail.com", txtName.Text, txtSubject.Text, txtContent.Text, lbPhotoName.Text, lbPhotoAddr.Text);
            try
            {
                net.SendMail();
                MessageBox.Show(txt.msg_send, txt.msg_title_say, MessageBoxButtons.OK, MessageBoxIcon.Error);
                EndForm();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {

            if (dialogPhoto.ShowDialog() == DialogResult.OK)
            {
                lbPhotoName.Text = Path.GetFileName(dialogPhoto.FileName);
                lbPhotoAddr.Text = Path.GetFullPath(dialogPhoto.FileName); //完整路徑
                picViewPhoto.Image = Image.FromFile(Path.GetFullPath(dialogPhoto.FileName));
            }
            else
            {
                lbPhotoName.Text = "無";
                lbPhotoAddr.Text = "-";
                picViewPhoto.Image = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EndForm();
        }

        private void EndForm()
        {
            this.ResetText();
            this.Dispose();
            this.Close();
        }

    }
}
