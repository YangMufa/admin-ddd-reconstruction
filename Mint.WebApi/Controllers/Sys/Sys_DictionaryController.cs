using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Mint.Core.Controllers.Basic;
using Mint.Core.Extensions;
using Mint.Core.Filters;
using Mint.Sys.IServices;

namespace Mint.Sys.Controllers
{
    [Route("api/Sys_Dictionary")]
    public partial class Sys_DictionaryController : ApiBaseController<ISys_DictionaryService>
    {
        public Sys_DictionaryController(ISys_DictionaryService service)
        : base("System", "System", "Sys_Dictionary", service)
        {
        }
    }
}
