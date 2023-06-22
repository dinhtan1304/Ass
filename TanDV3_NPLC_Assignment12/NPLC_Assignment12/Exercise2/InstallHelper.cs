using System.Net;

namespace NPLC_Assignment12.Exercise2
{
    public class InstallHelper
    {
        private readonly IFileDownloader _fileDownloader;
        private string _setupDestinationFile;

        public InstallHelper(IFileDownloader fileDownloader)
        {
            _fileDownloader = fileDownloader;
        }

        public bool DownloadInstaller(string customerName, string installerName)
        {
            try
            {
                _fileDownloader.DownloadFile(string.Format("http://example.com/{0}/{1}", customerName, installerName), _setupDestinationFile);
                return true;
            }
            catch (WebException)
            {
                return false;
            }
        }
    }

}
