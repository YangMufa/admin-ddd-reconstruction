using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mint.Infrastructure.Data;DBManager;

namespace Mint.Infrastructure.Data
{
    public abstract class DbContext
    {
        public virtual ISqlSugarClient SqlSugarClient { get; set; }

        public bool QueryTracking
        {
            set
            {
            }
        }
        public DbContext() : base() { }

        public virtual ISugarQueryable<TEntity> Set<TEntity>(bool filterDeleted = false) where TEntity : class
        {
            return this.SqlSugarClient.Set<TEntity>(filterDeleted);
        }

        public int SaveChanges()
        {
            return SqlSugarClient.SaveQueues();
        }
    }
}
