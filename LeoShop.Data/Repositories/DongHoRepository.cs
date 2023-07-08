using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeoShop.Data.Infrastructure;
using LeoShop.Data.Models;

namespace LeoShop.Data.Repositories
{
    public interface IDongHoRepository : IRepository<DongHo>
    {
    }
    public class DongHoRepository : RepositoryBase<DongHo>, IDongHoRepository
    {
        public DongHoRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
