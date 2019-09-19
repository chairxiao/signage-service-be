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
        public int DownloadTaskQueSize { get; set; } // 1000
    }
}
