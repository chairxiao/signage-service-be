using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Organizations;
using Signage.Products;
using Signage.Service.Authorization.Users;
using Signage.Service.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signage.Service.Products
{
    //[AbpAuthorize(PermissionNames.Pages_Products)]
    public class ProductsAppService : ServiceAppServiceBase
    {
        //实体仓储，实体继承自IMustHaveOrganizationUnit
        private readonly IRepository<Product> _productRepository;
        //OU仓储，通过此仓储读取OU
        private readonly IRepository<OrganizationUnit, long> _organizationUnitRepository;
        //用户数据Manager
        private readonly UserManager _userManager;

        //构造函数，DI注入

        public ProductsAppService(
            IRepository<Product> productRepository, 
            IRepository<OrganizationUnit, long> organizationUnitRepository,
            UserManager userManager
            )
        {
            _productRepository = productRepository;
            _organizationUnitRepository = organizationUnitRepository;
            _userManager = userManager;
        }
        //根据组织节点Id查询所有的Products，包含子Product
        [UnitOfWork]//UnitOfWork支持事务
        public virtual List<Product> GetProductsInOuIncludingChildren(long organizationUnitId)
        {
            //根据组织节点id，获取code
            var code = _organizationUnitRepository.Get(organizationUnitId).Code;

            //查询组织节点开头的所有节点，这样避免了递归查询，提升了效率，也是Code定义的目的所在
            var query =
                from product in _productRepository.GetAll()
                join organizationUnit in _organizationUnitRepository.GetAll() on product.OrganizationUnitId equals organizationUnit.Id
                where organizationUnit.Code.StartsWith(code)
                select product;

            return query.ToList();
        }

        //根据用户查询Product
        //查询用户关联的组织节点，再根据组织节点，查询关联的Product
        public async Task<List<Product>> GetProductsForUserAsync(long userId)
        {
            var user = await _userManager.GetUserByIdAsync(userId);
            var organizationUnits = await _userManager.GetOrganizationUnitsAsync(user);
            var organizationUnitIds = organizationUnits.Select(ou => ou.Id);

            return await _productRepository.GetAllListAsync(p => organizationUnitIds.Contains(p.OrganizationUnitId));
        }

        //同上个函数类似，查询中加入了子节点
        [UnitOfWork]
        public virtual async Task<List<Product>> GetProductsForUserIncludingChildOusAsync(long userId)
        {
            var user = await _userManager.GetUserByIdAsync(userId);
            var organizationUnits = await _userManager.GetOrganizationUnitsAsync(user);
            var organizationUnitCodes = organizationUnits.Select(ou => ou.Code);

            var query =
                from product in _productRepository.GetAll()
                join organizationUnit in _organizationUnitRepository.GetAll() on product.OrganizationUnitId equals organizationUnit.Id
                where organizationUnitCodes.Any(code => organizationUnit.Code.StartsWith(code))
                select product;

            return query.ToList();
        }
    }
}
