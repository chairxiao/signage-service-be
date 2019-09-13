using System.Threading.Tasks;
using Signage.Service.Configuration.Dto;

namespace Signage.Service.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
