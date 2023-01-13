using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenObedLoader
{
    class Downloader
    {
        public static int DownloadImage(Uri ImageUrl, string FilePath = null)
        {
            if (FilePath == null)
            {
                FilePath = Utilities.Configuration.DefaultDownloadPath + "\\" + "image.png";
            }

            int ReturnValue = 1;
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile(ImageUrl, FilePath);
                } catch(Exception exc)
                {
                    ReturnValue = 0;
                }
            }
            return ReturnValue;
        }
    }
}
