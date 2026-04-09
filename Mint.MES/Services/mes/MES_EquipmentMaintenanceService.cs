/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下MES_EquipmentMaintenanceService与IMES_EquipmentMaintenanceService中编写
 */
using Mint.MES.IRepositories;
using Mint.MES.IServices;
using Mint.Core.BaseProvider;
using Mint.Core.Extensions.AutofacManager;
using Mint.Entity.DomainModels;

namespace Mint.MES.Services
{
    public partial class MES_EquipmentMaintenanceService : ServiceBase<MES_EquipmentMaintenance, IMES_EquipmentMaintenanceRepository>
    , IMES_EquipmentMaintenanceService, IDependency
    {
    public static IMES_EquipmentMaintenanceService Instance
    {
      get { return AutofacContainerModule.GetService<IMES_EquipmentMaintenanceService>(); } }
    }
 }
