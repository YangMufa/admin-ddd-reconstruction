using Mint.Application.Services.IRepositories;
using Mint.Application.Services.IServices;
using Mint.Infrastructure.Data;BaseProvider;
using Mint.Infrastructure.Data;Extensions.AutofacManager;
using Mint.Entity.DomainModels;

namespace Mint.Application.Services
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

