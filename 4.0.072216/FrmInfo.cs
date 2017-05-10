using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElswordVoice
{
    public partial class FrmInfo : Form
    {
        /**
          *布告欄表單 － 2016/02/14 IncrEdibLe (Robby)
          */

        Config.Text txt = new Config.Text();
        Config.Initial ini = new Config.Initial();
        Config.Net net = new Config.Net();

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private const int WM_LBUTTONDBLCLK = 0x00A3;

        public FrmInfo()
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

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            // ToolTip
            ini.SetToolTip(picExit, txt.tip_exit);
            ini.SetToolTip(picInfo, txt.tip_info);

            // Info
            lbInfoDate.Text = "公告－ " + net.GetInfoDate();
            lbInfoContent.Text = net.GetInfoContent();

            // Location
            this.Location = ini.SetLocation(this.Width + 400, this.Height + 130);
            picInfo.Location = new Point(510, picInfo.Location.Y);
            lbInfoContent.Location = new Point(570, lbInfoContent.Location.Y);
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void timeInfo_Tick(object sender, EventArgs e)
        {
            var info = picInfo.Location;
            var info_str = lbInfoContent.Location;

            info.X -= 1;
            info_str.X -= 1;

            if (info.X < 0 - lbInfoContent.Width - picInfo.Width)
            {
                info.X = 510;
                info_str.X = 570;
            }

            picInfo.Location = info;
            lbInfoContent.Location = info_str;
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.Image = Properties.Resources.control_exit2;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {

            picExit.Image = Properties.Resources.control_exit1;
        }

    }
}
