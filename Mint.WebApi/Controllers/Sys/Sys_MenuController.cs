using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Mint.Infrastructure.Data;Controllers.Basic;
using Mint.Infrastructure.Data;Enums;
using Mint.Infrastructure.Data;Filters;
using Mint.Entity.DomainModels;
using Mint.Application.Services.IServices;

namespace Mint.WebApi.Controllers.Controllers
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
