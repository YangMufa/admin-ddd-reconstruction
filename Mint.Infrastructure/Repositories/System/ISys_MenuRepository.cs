using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mint.Infrastructure.Data;BaseProvider;
using Mint.Entity.DomainModels;
using Mint.Infrastructure.Data;Extensions.AutofacManager;
namespace Mint.Infrastructure.Repositories.IRepositories
{
    public partial interface ISys_MenuRepository : IDependency,IRepository<Sys_Menu>
    {
    }
}

