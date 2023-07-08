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
        private WebBanDongHoContext dbContext;
        public WebBanDongHoContext Init()
        {
            return dbContext ?? (dbContext = new WebBanDongHoContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
