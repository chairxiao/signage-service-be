using Abp.Dependency;
using Abp.Threading.BackgroundWorkers;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Signage.Service
{
    public class DownloadService: BackgroundWorkerBase, ISingletonDependency
    {

        

        public override void Start()
        {
            base.Start();
            FileSystemWatcher fsw = new FileSystemWatcher();
            
            Logger.Info("started");
        }
        public override void Stop()
        {
            base.Stop();
            Logger.Info("Stop");
        }
        public override void WaitToStop()
        {
            Logger.Info("WaitToStop");
            base.WaitToStop();
        }
    }
}
