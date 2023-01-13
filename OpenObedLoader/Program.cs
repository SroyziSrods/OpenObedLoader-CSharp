using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenObedLoader.Network;

namespace OpenObedLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi!");
            // example using
            VKServer.DownloadSticker(4272, 512, @"C:\Users\User\Desktop\test"); // 1st arg = Sticker Image ID, 2nd arg = Size (max value is 512 ig), 3rd arg = path to save on disk
            VKServer.DownloadGift(1, 512, @"C:\Users\User\Desktop\test"); //  // 1st arg = Gift Image ID, 2nd arg = Size (max value is 512 ig), 3rd arg = path to save on disk
        }
    }
}
