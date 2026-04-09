using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mint.Core.BaseProvider;
using Mint.Entity.DomainModels;
using Mint.Core.Extensions.AutofacManager;
namespace Mint.Sys.IRepositories
{
    public partial interface ISys_LogRepository : IDependency,IRepository<Sys_Log>
    {
    }
}

