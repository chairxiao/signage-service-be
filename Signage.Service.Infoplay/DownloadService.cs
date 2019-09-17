using Abp.Dependency;
using Abp.Threading.BackgroundWorkers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Signage.Service
{
    class DownloadService: BackgroundWorkerBase, ISingletonDependency
    {
        public override void Start()
        {
            base.Start();
        }
        public override void Stop()
        {
            base.Stop();
        }
        public override void WaitToStop()
        {
            base.WaitToStop();
        }
    }
}
