using Abp.Dependency;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Signage.Service
{
    public class FileDownloadService : PeriodicBackgroundWorkerBase, ISingletonDependency
    {
        //2: Getting a logger using property injection
        public ILogger Logger { get; set; }


        private int counter=0;
        public FileDownloadService(AbpTimer timer) :base(timer)
        {
            Logger = NullLogger.Instance;
            timer.Period = 5 * 1000;
        }
        protected override void DoWork()
        {
            counter++;
            Logger.Info($"DoWork:{counter}");
        }
    }
}
