using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Bookstore.MultiTenancy.Dto;

namespace Bookstore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
