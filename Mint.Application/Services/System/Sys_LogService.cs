using Mint.Sys.IRepositories;
using Mint.Sys.IServices;
using Mint.Core.BaseProvider;
using Mint.Core.Extensions.AutofacManager;
using Mint.Entity.DomainModels;

namespace Mint.Sys.Services
{
    public partial class Sys_LogService : ServiceBase<Sys_Log, ISys_LogRepository>, ISys_LogService, IDependency
    {
        public Sys_LogService(ISys_LogRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static ISys_LogService Instance
        {
           get { return AutofacContainerModule.GetService<ISys_LogService>(); }
        }
    }
}

