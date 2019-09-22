using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Text;

namespace Signage.Service
{
    public class InfoplayConfig
    {
        public string RootPath { get; set; }
        public string[] WatcherPaths { get; set; }
    }
}
