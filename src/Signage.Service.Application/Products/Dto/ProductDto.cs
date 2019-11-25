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
    class ProductDto: EntityDto<int>
    {
        public int TenantId { get; set; }

        public  long OrganizationUnitId { get; set; }

        public  string Name { get; set; }

        public  float Price { get; set; }
    }
}

