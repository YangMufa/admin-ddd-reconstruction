using Mint.Application.Services.IRepositories;
using Mint.Application.Services.IServices;
using Mint.Infrastructure.Data;BaseProvider;
using Mint.Infrastructure.Data;Extensions.AutofacManager;
using Mint.Entity.DomainModels;

namespace Mint.Application.Services
{
    public partial class Sys_MenuService : ServiceBase<Sys_Menu, ISys_MenuRepository>, ISys_MenuService, IDependency
    {
        public Sys_MenuService(ISys_MenuRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static ISys_MenuService Instance
        {
           get { return AutofacContainerModule.GetService<ISys_MenuService>(); }
        }
    }
}

