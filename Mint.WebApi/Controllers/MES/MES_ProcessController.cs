/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MES_ProcessController编写
 */
using Microsoft.AspNetCore.Mvc;
using Mint.Core.Controllers.Basic;
using Mint.Entity.AttributeManager;
using Mint.MES.IServices;
namespace Mint.MES.Controllers
{
    [Route("api/MES_Process")]
    [PermissionTable(Name = "MES_Process")]
    public partial class MES_ProcessController : ApiBaseController<IMES_ProcessService>
    {
        public MES_ProcessController(IMES_ProcessService service)
        : base(service)
        {
        }
    }
}

