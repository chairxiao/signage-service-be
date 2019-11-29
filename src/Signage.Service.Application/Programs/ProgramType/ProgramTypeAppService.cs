using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Signage.Service.Authorization;
using Signage.Service.Programs.ProgramType.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Signage.Service.Programs.ProgramType
{
    [AbpAuthorize(PermissionNames.Pages_Programs)]

    public class ProgramTypeAppService : CrudAppService<ProgramType, ProgramTypeDto>
    {
        public ProgramTypeAppService(IRepository<ProgramType, int> repository)
            : base(repository)
        {

        }
    }
}