using System;
using System.Collections.Generic;
using System.Text;

namespace Signage.Service
{
    public class DownloadServiceConfig
    {
        public string[][] HostMaps { get; set; }
        public string[] PriorUriKeys { get; set; }
        public int HttpClientTimeoutSec { get; set; } //60
        public int DownloadTaskQueSize { get; set; } // 200
        public string TempDownloadRoot { get; set; }

        public DownloadServiceConfig()
        {
            HostMaps = new string[][] { };
             HttpClientTimeoutSec = 60;
            DownloadTaskQueSize = 200;
        }

    }
    public static class DownloadServiceConfigExtensions
    {
        public static string GetDestUri(this DownloadServiceConfig downloadServiceConfig, string srcUri)
        {
            string rc = srcUri;
            foreach (var hostMap in downloadServiceConfig.HostMaps)
            {
                if (hostMap.Length != 2) continue;
                if (srcUri.Contains(hostMap[0]))
                {
                    return rc.Replace(hostMap[0], hostMap[1]);
                }
            }
            return rc;
        }
    }
}
