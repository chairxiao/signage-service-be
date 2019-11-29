using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Signage.Service.Programs.ProgramType.Dto
{
    [AutoMapFrom(typeof(ProgramType))]
    public class ProgramTypeDto : EntityDto
    {
        public string Name { get; set; }
    }
}
