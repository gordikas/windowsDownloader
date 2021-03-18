using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace test.Core.Installator
{
    class Installator
    {
        private void InstallFile(string filename)
        {
            Process.Start(filename);
        }
        private void InstallFile(int filename)
        {
            Process process = new Process();
            process.StartInfo.FileName = "msiexec.exe";
            process.StartInfo.Arguments = string.Format(" /i \"{0}\" ALLUSERS=1", Downloader.pathFiles + $"{filename}.msi");
            process.Start();
            process.WaitForExit();
        }
        public void InstallAllFiles()
        {
            for (int i = 0; i != Downloader.UrlsFiles.Count; i++)
            {
                InstallFile(Downloader.pathFiles + $"{i}.exe");
            }
            for (int i = 0; i != Downloader.UrlsFilesMsi.Count; i++)
            {
                InstallFile(i);
            }
        }

        private void DeleteFile(string filename)
        {
            try
            {
                System.IO.File.Delete(filename);
            }
            catch { }     
        }
        public  void DeleteAllFiles()
        {
            for (int i = 0; i != Downloader.UrlsFiles.Count; i++)
            {
                DeleteFile(Downloader.pathFiles + $"{i}.exe");
            }       
        }
    }
}
