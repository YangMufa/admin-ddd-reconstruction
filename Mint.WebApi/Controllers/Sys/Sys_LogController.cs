using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mint.Infrastructure.Data;Controllers.Basic;
using Mint.Infrastructure.Data;DBManager;
using Mint.Entity.DomainModels;
using Mint.Application.Services.IServices;

namespace Mint.WebApi.Controllers.Controllers
{
    [Route("api/Sys_Log")]
    public partial class Sys_LogController : ApiBaseController<ISys_LogService>
    {
        public Sys_LogController(ISys_LogService service)
        : base("System", "System", "Sys_Log", service)
        {
        }
    }
}
