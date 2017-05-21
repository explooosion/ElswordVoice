using System;

using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ElswordVoice.Config
{
    class Controller
    {
        /**
          *檔案存取變更方法 － 2016/02/14 IncrEdibLe (Robby)
          */

        #region 將目錄(game)底下的檔案命名為 *.kom.temp
        public void RenameToTemp(string path, string[] files)
        {
            foreach (string file in files)
            {
                if (isExists(path, file))
                {
                    try
                    {
                        File.Move(Path.Combine(path, file), Path.Combine(path, file + ".temp"));
                        Application.DoEvents();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }
        #endregion

        public void RenameToKom(string path, string[] files)
        {
            foreach (string file in files)
            {
                if (isExists(path, file))
                {
                    try
                    {
                        File.Move(Path.Combine(path, file), Path.Combine(path, file.Replace(".temp", "")));
                        Application.DoEvents();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }

        #region 從指定目錄(Ex_Voice)底下複製所有檔案到目標目錄
        public void CopyCustomFiles(string sourcepath, string targetpath, string[] files)
        {
            foreach (string file in files)
            {
                if (isExists(sourcepath, file))
                {
                    try
                    {
                        File.Copy(Path.Combine(sourcepath, file), Path.Combine(targetpath, file), true);    // OverWrite
                        Application.DoEvents();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }
        #endregion

        #region 刪除遊戲目錄底下的.temp
        public void DeleteCustomFiles(string path, string[] files)
        {
            foreach (string file in files)
            {
                if (isExists(path, file) && isExists(path, file.Replace(".temp", "")))
                {
                    try
                    {
                        File.Delete(Path.Combine(path, file.Replace(".temp", "")));
                        Application.DoEvents();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }
        #endregion

        public void DeleteRegedit()
        {
            // 刪除註冊檔 避免系統判斷檔案被異動過
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\ElswordINT\TW\PatcherOption\", true);

            if (regkey.OpenSubKey("MARK_INVALID") != null)
            {
                regkey.DeleteSubKeyTree("MARK_INVALID");
            }
        }

        private bool isExists(string path, string file)
        {
            if (File.Exists(Path.Combine(path, file)))
            {
                return true;
            }
            Console.WriteLine("File:{0},is not exists", file);
            return false;
        }
    }
}
