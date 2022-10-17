using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Bookstore.Roles.Dto;
using Bookstore.Users.Dto;

namespace Bookstore.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}