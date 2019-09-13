using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Signage.Service.MultiTenancy.Dto;

namespace Signage.Service.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

