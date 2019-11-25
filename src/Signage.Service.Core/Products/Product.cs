using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Signage.Products
{
    public class Product : Entity, IMustHaveTenant, IMustHaveOrganizationUnit
    {
        public virtual int TenantId { get; set; }

        public virtual long OrganizationUnitId { get; set; }

        public virtual string Name { get; set; }

        public virtual float Price { get; set; }
        public Product()
        {
        }

        public Product(int tenantId, long organizationUnitId, string name, float price)
        {
            TenantId = tenantId;
            OrganizationUnitId = organizationUnitId;
            Name = name;
            Price = price;
        }
    }
}
