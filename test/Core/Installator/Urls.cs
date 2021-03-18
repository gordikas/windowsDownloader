using System;
using System.Collections.Generic;
using System.Text;

namespace test.Core.Installator
{
    class Urls
    {
        private static void AddUrls(string url)
        {
            Downloader.UrlsFiles.Add(url);
        }
        private static void AddUrlsMsi(string url)
        {
            Downloader.UrlsFilesMsi.Add(url);
        }
        public static void AddAllUrls()
        {
            AddUrls("http://discord.com/api/download?platform=win");
            AddUrls("https://dl.tlgrm.click/desktop/win");
            AddUrls("https://download.mozilla.org/?product=firefox-stub&os=win&lang=ru");
            AddUrls("https://ru.download.nvidia.com/GFE/GFEClient/3.21.0.36/GeForce_Experience_v3.21.0.36.exe");
            AddUrls("https://go.microsoft.com/fwlink/?linkid=874338");
            AddUrls("https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe");
            AddUrls("https://github.com/henrypp/memreduct/releases/download/v.3.3.5/memreduct-3.3.5-setup.exe");
            AddUrls("https://github.com/git-for-windows/git/releases/download/v2.31.0.windows.1/Git-2.31.0-64-bit.exe");
            AddUrlsMsi("https://download.tortoisegit.org/tgit/2.11.0.0/TortoiseGit-2.11.0.0-64bit.msi");
            AddUrls("https://cdn.soft-download.ru?s=7kSn4o2UH9_vOzkWzG8bcw&pf=Microsoft_Visual_Studio_Setup.exe&pt=Visual Studio&src=softcatalog.info&ref=www.google.com&cid=1504239817.1616102867");
            AddUrls("https://cdn-fastly.obsproject.com/downloads/OBS-Studio-26.1.1-Full-Installer-x64.exe");
    }
}
