using System;
using test.Core.Optimization.Regedit;
using System.Windows.Forms;


namespace test
{

    public partial class Form1 : Form
    {
        Core.Installator.Downloader downloader = new Core.Installator.Downloader();
        Core.Installator.Installator installator = new Core.Installator.Installator();
        public Form1()
        {
            InitializeComponent();
            Core.Installator.Urls.AddAllUrls();
        }

        private void download_Click(object sender, EventArgs e)
        {
            download.Text = "Подождите...";
            this.Cursor = Cursors.WaitCursor;

            downloader.DownloadAllFiles();       
            System.Threading.Thread.Sleep(50);

            this.Cursor = Cursors.Default;
            download.Text = "Скачано!";

        }

        private void install_Click(object sender, EventArgs e)
        {
            installator.InstallAllFiles();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            delete.Text = "Подождите...";
            this.Cursor = Cursors.WaitCursor;

            installator.DeleteAllFiles();
            System.Threading.Thread.Sleep(50);

            this.Cursor = Cursors.Default;
            delete.Text = "В корзине!";
        }

        private void regedit_Click(object sender, EventArgs e)
        {
            Regedit.AllRegedit();
        }
    }
}
