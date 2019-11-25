using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Signage.Service.Programs.ProgramsManage.Dto
{
    class PagedProgramManageResultRequestDto: PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
