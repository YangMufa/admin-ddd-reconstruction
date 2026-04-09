using Mint.Sys.IRepositories;
using Mint.Core.BaseProvider;
using Mint.Core.Extensions.AutofacManager;
using Mint.Core.DbContext;
using Mint.Entity.DomainModels;

namespace Mint.Sys.Repositories
{
    public partial class Sys_LogRepository : RepositoryBase<Sys_Log>, ISys_LogRepository
    {
        public Sys_LogRepository(VOLContext dbContext)
        : base(dbContext)
        {

        }
        public static ISys_LogRepository GetService
        {
            get { return AutofacContainerModule.GetService<ISys_LogRepository>(); }
        }
    }
}

