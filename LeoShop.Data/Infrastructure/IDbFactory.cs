using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeoShop.Data.Models;

namespace LeoShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        LeoShopContext Init();
    }
}
