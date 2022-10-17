using System.Threading.Tasks;
using Abp.Application.Services;
using Bookstore.Configuration.Dto;

namespace Bookstore.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}