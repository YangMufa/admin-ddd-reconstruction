using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mint.Core.Controllers.Basic;
using Mint.Core.Enums;
using Mint.Core.Filters;
using Mint.Entity.AttributeManager;
using Mint.Entity.DomainModels;
using Mint.Sys.IServices;

namespace Mint.Sys.Controllers
{
    [Route("api/Sys_Role")]
    [PermissionTable(Name = "Sys_Role")]
    public partial class Sys_RoleController : ApiBaseController<ISys_RoleService>
    {
        public Sys_RoleController(ISys_RoleService service)
        : base("System", "System", "Sys_Role", service)
        {

        }
    }
}


