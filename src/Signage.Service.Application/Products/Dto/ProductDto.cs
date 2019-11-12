using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Organizations;
using Signage.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Signage.Service.Products.Dto
{
    [AutoMapTo(typeof(Product))]
    class ProductDto: EntityDto, IMustHaveTenant, IMustHaveOrganizationUnit
    {
        public virtual int TenantId { get; set; }

        public virtual long OrganizationUnitId { get; set; }

        public virtual string Name { get; set; }

        public virtual float Price { get; set; }
    }
}

