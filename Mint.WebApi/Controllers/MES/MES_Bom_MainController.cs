/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MES_Bom_MainController编写
 */
using Microsoft.AspNetCore.Mvc;
using Mint.Infrastructure.Data;Controllers.Basic;
using Mint.Entity.AttributeManager;
using Mint.WebApi.Controllers.IServices;
namespace Mint.WebApi.Controllers.Controllers
{
    [Route("api/MES_Bom_Main")]
    [PermissionTable(Name = "MES_Bom_Main")]
    public partial class MES_Bom_MainController : ApiBaseController<IMES_Bom_MainService>
    {
        public MES_Bom_MainController(IMES_Bom_MainService service)
        : base(service)
        {
        }
    }
}

