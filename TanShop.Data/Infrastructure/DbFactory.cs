using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        TanShopDbContext dbContext;

        public TanShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TanShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
