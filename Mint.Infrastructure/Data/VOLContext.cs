using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel;
using Microsoft.Extensions.Logging;
using SqlSugar;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using Mint.Infrastructure.Data;DBManager;
using Mint.Infrastructure.Data;DbSqlSugar;
using Mint.Infrastructure.Data;Extensions;
using Mint.Infrastructure.Data;Extensions.AutofacManager;
using Mint.Entity.SystemModels;

namespace Mint.Infrastructure.Data
{
    public class VOLContext : DbContext, IDependency
    {
        public VOLContext() : base()
        {
            base.SqlSugarClient = DbManger.Db;
        }
        public VOLContext(string configId) : base()
        {
            base.SqlSugarClient = DbManger.GetConnection(configId);
        }
    }
}
