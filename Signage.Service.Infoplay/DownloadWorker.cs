using Abp.Dependency;
using Abp.Threading.BackgroundWorkers;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Signage.Service
{
    public class DownloadWorker: BackgroundWorkerBase, ISingletonDependency
    {
        private DownloadService downloadService;
           
        public DownloadWorker(DownloadService downloadService)
        {
            this.downloadService = downloadService;
        }
        public override void Start()
        {
            downloadService.Start();

            Logger.Info("started");
        }
        public override void Stop()
        {
            downloadService.Stop();
            Logger.Info("Stop");
        }
        public override void WaitToStop()
        {
            Logger.Info("WaitToStop");
            base.WaitToStop();
        }
    }
}
