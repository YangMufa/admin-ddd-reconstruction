/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下MES_Bom_DetailService与IMES_Bom_DetailService中编写
 */
using Mint.MES.IRepositories;
using Mint.MES.IServices;
using Mint.Core.BaseProvider;
using Mint.Core.Extensions.AutofacManager;
using Mint.Entity.DomainModels;

namespace Mint.MES.Services
{
    public partial class MES_Bom_DetailService : ServiceBase<MES_Bom_Detail, IMES_Bom_DetailRepository>
    , IMES_Bom_DetailService, IDependency
    {
    public static IMES_Bom_DetailService Instance
    {
      get { return AutofacContainerModule.GetService<IMES_Bom_DetailService>(); } }
    }
 }
