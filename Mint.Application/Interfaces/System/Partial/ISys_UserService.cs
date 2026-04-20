using Mint.Infrastructure.Data;BaseProvider;
using Mint.Infrastructure.Data;Utilities;
using Mint.Entity.DomainModels;
using System.Threading.Tasks;

namespace Mint.Application.IServices
{
    public partial interface ISys_UserService
    {

        Task<WebResponseContent> Login(LoginInfo loginInfo, bool verificationCode = true);
        Task<WebResponseContent> ReplaceToken();
        Task<WebResponseContent> ModifyPwd(string oldPwd, string newPwd);
        Task<WebResponseContent> GetCurrentUserInfo();
    }
}

