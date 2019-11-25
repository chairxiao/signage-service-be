using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Signage.Service.Programs.ProgramsManage
{
    public class ProgramManage
    {
        public virtual int Type { get; set; }
        public virtual bool HasChecked { get; set; }

        public virtual bool? IsActive { get; set; }
        public virtual  int UserID { get; set; }
        public ProgramManage()
        {

        }

    }
}
