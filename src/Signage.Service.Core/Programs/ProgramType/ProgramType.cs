using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Signage.Service.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Signage.Service.Programs.ProgramType
{
    public class ProgramType : Entity { 
        [Required]
        //[MaxLength(Common.CoreConst.MaxLength)]
        [StringLength(1000)]
        public string Name { get; set; }
    }
}
