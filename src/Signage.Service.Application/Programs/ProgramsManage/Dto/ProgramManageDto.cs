using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Signage.Service.Programs.ProgramsManage
{
    [AutoMapTo(typeof(ProgramManage))]
    public class ProgramManageDto:EntityDto<int>
    {
        public int Type { get; set; }
        public bool HasChecked { get; set; }

        public bool? IsActive { get; set; }
        public int UserID { get; set; }

    }
}
