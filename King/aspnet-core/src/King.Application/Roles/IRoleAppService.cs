using System.Threading.Tasks;
using Abp.Application.Services;
using King.Roles.Dto;

namespace King.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
