using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mint.Infrastructure.Data;Controllers.Basic;
using Mint.Infrastructure.Data;Enums;
using Mint.Infrastructure.Data;Filters;
using Mint.Entity.AttributeManager;
using Mint.Entity.DomainModels;
using Mint.Application.Services.IServices;

namespace Mint.WebApi.Controllers.Controllers
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


