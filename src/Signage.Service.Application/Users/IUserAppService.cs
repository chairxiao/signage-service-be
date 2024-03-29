using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Signage.Service.Roles.Dto;
using Signage.Service.Users.Dto;

namespace Signage.Service.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
