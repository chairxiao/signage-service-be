using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Signage.Service.Programs.ProgramType.Dto
{
    [AutoMapTo(typeof(ProgramType))]
    class CreateProgramTypeInput
    {
    }
}
