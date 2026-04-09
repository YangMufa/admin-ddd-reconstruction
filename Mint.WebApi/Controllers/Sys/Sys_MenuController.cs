using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Mint.Core.Controllers.Basic;
using Mint.Core.Enums;
using Mint.Core.Filters;
using Mint.Entity.DomainModels;
using Mint.Sys.IServices;

namespace Mint.Sys.Controllers
{
    [Route("api/menu")]
    [ApiController, JWTAuthorize()]
    public partial class Sys_MenuController : ApiBaseController<ISys_MenuService>
    {
        private ISys_MenuService _service { get; set; }
        public Sys_MenuController(ISys_MenuService service) :
            base("System", "System", "Sys_Menu", service)
        {
            _service = service;
        } 
    }
}
