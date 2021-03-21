using System.IO;

namespace Elvo.Config
{
    class Data
    {
        /**
         * 資料路徑設定 － 2016/02/14 IncrEdibLe (Robby)
         * 
         * Elsword －－ Data(.kom / .temp)
         *      |
         *      |  －－ Elvo －－ Ex_Voice (.kom)
         */

        // Folder Path
        private DirectoryInfo AppPath = new DirectoryInfo(System.Windows.Forms.Application.StartupPath);
        private string DataPath = string.Empty;
        private string ExChangePath = string.Empty;

        // Files List
        private string[] CustomFiles;
        private string[] RemainFiles;

        public string GetThisPath()
        {
            return AppPath.FullName.ToString();
        }

        public string GetInstallPath()
        {
            return AppPath.Parent.FullName.ToString();
        }

        public string GetDataPath()
        {
            DataPath = Path.Combine(AppPath.Parent.FullName.ToString(), @"data\");
            if (!Directory.Exists(DataPath))
            {
                Directory.CreateDirectory(DataPath);
            }
            return DataPath;
        }

        public string GetExChangePath()
        {
            ExChangePath = Path.Combine(AppPath.FullName.ToString(), @"Ex_Voice\");
            if (!Directory.Exists(ExChangePath))
            {
                Directory.CreateDirectory(ExChangePath);
            }
            return ExChangePath;
        }

        public string[] GetCustomFiles()
        {
            string[] files = Directory.GetFiles(GetExChangePath(), "*.kom");
            CustomFiles = new string[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                CustomFiles[i] = Path.GetFileName(files[i]);
            }
            return CustomFiles;
        }

        public string[] GetRemainFiles()
        {
            string[] files = Directory.GetFiles(GetDataPath(), "*.temp");
            RemainFiles = new string[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                RemainFiles[i] = Path.GetFileName(files[i]);
            }
            return RemainFiles;
        }

    }
}
