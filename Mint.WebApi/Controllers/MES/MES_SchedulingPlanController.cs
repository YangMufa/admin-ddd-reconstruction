/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MES_SchedulingPlanController编写
 */
using Microsoft.AspNetCore.Mvc;
using Mint.Core.Controllers.Basic;
using Mint.Entity.AttributeManager;
using Mint.MES.IServices;
namespace Mint.MES.Controllers
{
    [Route("api/MES_SchedulingPlan")]
    [PermissionTable(Name = "MES_SchedulingPlan")]
    public partial class MES_SchedulingPlanController : ApiBaseController<IMES_SchedulingPlanService>
    {
        public MES_SchedulingPlanController(IMES_SchedulingPlanService service)
        : base(service)
        {
        }
    }
}

