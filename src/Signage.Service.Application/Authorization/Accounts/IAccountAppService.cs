using System.Threading.Tasks;
using Abp.Application.Services;
using Signage.Service.Authorization.Accounts.Dto;

namespace Signage.Service.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
