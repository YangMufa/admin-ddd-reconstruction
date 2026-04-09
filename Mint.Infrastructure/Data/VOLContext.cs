using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel;
using Microsoft.Extensions.Logging;
using SqlSugar;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using Mint.Core.DBManager;
using Mint.Core.DbSqlSugar;
using Mint.Core.Extensions;
using Mint.Core.Extensions.AutofacManager;
using Mint.Entity.SystemModels;

namespace Mint.Core.DbContext
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
