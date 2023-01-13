using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenObedLoader.Network
{
    class VKServer
    {
        public static int DownloadSticker(int Identifier, int Quality = 512, string Path = null)
        {
            if (Path == null)
            {
                Path = Utilities.Configuration.DefaultDownloadPath;
            }

            if (!System.IO.Directory.Exists(Path))
            {
                System.IO.Directory.CreateDirectory(Path);
            }

            int ReturnValue = Downloader.DownloadImage(new Uri($"https://{Utilities.Configuration.VKServerURL}/sticker/1-{Identifier}-{Quality}"), $"{Path}/{Identifier}.png");
            return ReturnValue;
        }

        public static int DownloadGift(int Identifier, int Quality = 512, string Path = null)
        {
            if (Path == null)
            {
                Path = Utilities.Configuration.DefaultDownloadPath;
            }

            if (!System.IO.Directory.Exists(Path))
            {
                System.IO.Directory.CreateDirectory(Path);
            }

            int ReturnValue = Downloader.DownloadImage(new Uri($"https://{Utilities.Configuration.VKServerURL}/sticker/4-{Identifier}-{Quality}"), $"{Path}/{Identifier}.png");
            return ReturnValue;
        }
    }
}
