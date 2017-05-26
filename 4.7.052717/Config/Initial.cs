using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ElswordVoice.Config
{
    class Initial
    {
        /**
         *表單通用設定 － 2016/02/14 IncrEdibLe (Robby)
         */

        Config.Text txt = new Config.Text();

        private ToolTip tip = new ToolTip();
        private Point point = new Point();


        public void SetToolTip(Control con, string msg)
        {
            tip.SetToolTip(con, msg);
        }

        public Point SetLocation(int w, int h)
        {
            // 主表單位置 (右下角)
            point.X = Screen.PrimaryScreen.WorkingArea.Width - w + 100;
            point.Y = Screen.PrimaryScreen.WorkingArea.Height - h;
            return point;
        }

        public void CheckUpdate(string _new, string _old, bool msgpass)
        {
            if (_new == "")
            {
                MessageBox.Show(txt.msg_vererror, txt.msg_title_update, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (_new != _old)
            {
                DialogResult UpdateResult = MessageBox.Show(txt.msg_verno, txt.msg_title_update, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (UpdateResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Properties.Resources.Blog); // Pixnet Blog
                }
            }
            else
            {
                if (msgpass == true)
                {
                    MessageBox.Show(txt.msg_verok, txt.msg_title_update, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool LoadCheck()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                return true;
            }
            return false;
        }
    }
}
