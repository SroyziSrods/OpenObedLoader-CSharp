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
            VKServer.DownloadSticker(4272, Path: @"C:\Users\User\Desktop\test"); // downloading "glasses with mustache" sticker from URL: vk.com/sticker/1-4272-512
        }
    }
}
