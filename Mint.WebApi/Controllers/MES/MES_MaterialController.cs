/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MES_MaterialController编写
 */
using Microsoft.AspNetCore.Mvc;
using Mint.Infrastructure.Data;Controllers.Basic;
using Mint.Entity.AttributeManager;
using Mint.WebApi.Controllers.IServices;
namespace Mint.WebApi.Controllers.Controllers
{
    [Route("api/MES_Material")]
    [PermissionTable(Name = "MES_Material")]
    public partial class MES_MaterialController : ApiBaseController<IMES_MaterialService>
    {
        public MES_MaterialController(IMES_MaterialService service)
        : base(service)
        {
        }
    }
}

