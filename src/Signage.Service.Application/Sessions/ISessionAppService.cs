using System.Threading.Tasks;
using Abp.Application.Services;
using Signage.Service.Sessions.Dto;

namespace Signage.Service.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
