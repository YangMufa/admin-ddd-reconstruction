/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MES_EquipmentMaintenanceController编写
 */
using Microsoft.AspNetCore.Mvc;
using Mint.Infrastructure.Data;Controllers.Basic;
using Mint.Entity.AttributeManager;
using Mint.WebApi.Controllers.IServices;
namespace Mint.WebApi.Controllers.Controllers
{
    [Route("api/MES_EquipmentMaintenance")]
    [PermissionTable(Name = "MES_EquipmentMaintenance")]
    public partial class MES_EquipmentMaintenanceController : ApiBaseController<IMES_EquipmentMaintenanceService>
    {
        public MES_EquipmentMaintenanceController(IMES_EquipmentMaintenanceService service)
        : base(service)
        {
        }
    }
}

