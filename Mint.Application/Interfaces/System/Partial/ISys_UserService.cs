using Mint.Core.BaseProvider;
using Mint.Core.Utilities;
using Mint.Entity.DomainModels;
using System.Threading.Tasks;

namespace Mint.Sys.IServices
{
    public partial interface ISys_UserService
    {

        Task<WebResponseContent> Login(LoginInfo loginInfo, bool verificationCode = true);
        Task<WebResponseContent> ReplaceToken();
        Task<WebResponseContent> ModifyPwd(string oldPwd, string newPwd);
        Task<WebResponseContent> GetCurrentUserInfo();
    }
}

