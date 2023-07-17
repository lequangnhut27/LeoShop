using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeoShop.Data.Models;

namespace LeoShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private LeoShopContext dbContext;
        public LeoShopContext Init()
        {
            return dbContext ?? (dbContext = new LeoShopContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
