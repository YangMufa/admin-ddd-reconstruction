/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MES_EquipmentRepairController编写
 */
using Microsoft.AspNetCore.Mvc;
using Mint.Infrastructure.Data;Controllers.Basic;
using Mint.Entity.AttributeManager;
using Mint.WebApi.Controllers.IServices;
namespace Mint.WebApi.Controllers.Controllers
{
    [Route("api/MES_EquipmentRepair")]
    [PermissionTable(Name = "MES_EquipmentRepair")]
    public partial class MES_EquipmentRepairController : ApiBaseController<IMES_EquipmentRepairService>
    {
        public MES_EquipmentRepairController(IMES_EquipmentRepairService service)
        : base(service)
        {
        }
    }
}

