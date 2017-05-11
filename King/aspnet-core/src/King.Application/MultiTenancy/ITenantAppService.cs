using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using King.MultiTenancy.Dto;

namespace King.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
