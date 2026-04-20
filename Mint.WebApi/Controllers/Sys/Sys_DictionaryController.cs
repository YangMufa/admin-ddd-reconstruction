using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Mint.Infrastructure.Data;Controllers.Basic;
using Mint.Infrastructure.Data;Extensions;
using Mint.Infrastructure.Data;Filters;
using Mint.Application.Services.IServices;

namespace Mint.WebApi.Controllers.Controllers
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
