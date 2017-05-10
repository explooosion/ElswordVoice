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
    public partial class FrmAbout : Form
    {
        /**
          *關於表單 － 2016/02/14 IncrEdibLe (Robby)
          */

        Config.Initial ini = new Config.Initial();
        Config.Text txt = new Config.Text();

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private const int WM_LBUTTONDBLCLK = 0x00A3;

        public FrmAbout()
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

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            lbAbout.Text = Properties.Resources.Version;
            picAbout.Image = Properties.Resources.about;

            // ToolTip
            ini.SetToolTip(picExit, txt.tip_exit);
        }


        private void picExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Image = Properties.Resources.control_exit1;
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.Image = Properties.Resources.control_exit2;
        }

        private void lnkBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.Blog); // Pixnet Blog
        }

        private void lnkElsInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.ElsInfo); // Pixnet Blog
        }

        private void lnkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.GitHub); // Pixnet Blog
        }

        private void lnkDot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.DotBlogs); // Pixnet Blog
        }


    }
}
