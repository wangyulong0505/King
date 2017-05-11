using System.Threading.Tasks;
using Abp.Application.Services;
using King.Authorization.Accounts.Dto;

namespace King.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
