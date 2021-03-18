using System.Net;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace test.Core.Installator
{
    public class Downloader
    {
        public static List<string> UrlsFilesMsi = new List<string>();
        public static List<string> UrlsFiles = new List<string>();
        public static string pathFiles = @"c:\";

        private void DownloadWallPaper()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://images.wallpaperscraft.ru/image/domik_les_art_131857_1920x1080.jpg", @"C:\Users\pasha\Pictures\WallPaper.jpg");
        }
        private void DownloadFile(string fileurl,string fileName)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(fileurl, pathFiles + fileName);
        }
        
        public  void DownloadAllFiles()
        {
            for (int i = 0; i != UrlsFiles.Count; i++)
            {
                DownloadFile(UrlsFiles[i], $"{i}.exe");
            }
            for (int i = 0; i != UrlsFilesMsi.Count; i++)
            {
                DownloadFile(UrlsFilesMsi[i], $"{i}.msi");
            }
            DownloadWallPaper();
        }

    }
}
