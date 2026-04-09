/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹Sys_UserRepository编写代码
 */
using Mint.Sys.IRepositories;
using Mint.Core.BaseProvider;
using Mint.Core.DbContext;
using Mint.Core.Extensions.AutofacManager;
using Mint.Entity.DomainModels;

namespace Mint.Sys.Repositories
{
    public partial class Sys_UserRepository : RepositoryBase<Sys_User>
    , ISys_UserRepository
    {
    public Sys_UserRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static ISys_UserRepository Instance
    {
    get {  return AutofacContainerModule.GetService<ISys_UserRepository>
        (); } }
        }
        }
