/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹MES_ProductionReportingRepository编写代码
 */
using Mint.MES.IRepositories;
using Mint.Core.BaseProvider;
using Mint.Core.DbContext;
using Mint.Core.Extensions.AutofacManager;
using Mint.Entity.DomainModels;

namespace Mint.MES.Repositories
{
    public partial class MES_ProductionReportingRepository : RepositoryBase<MES_ProductionReporting> , IMES_ProductionReportingRepository
    {
    public MES_ProductionReportingRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IMES_ProductionReportingRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IMES_ProductionReportingRepository>(); } }
    }
}
