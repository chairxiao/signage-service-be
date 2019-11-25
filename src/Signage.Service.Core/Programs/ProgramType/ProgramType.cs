using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Signage.Service.Programs.ProgramType
{
    public class ProgramType:Entity
    {
        [Required]
        //[MaxLength(Common.CoreConst.MaxLength)]
        public string Name { get; set; }
    }
}
