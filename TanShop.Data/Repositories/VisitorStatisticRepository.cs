using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanShop.Data.Infrastructure;
using TanShop.Model.Models;

namespace TanShop.Data.Repositories
{
    public interface IVisitorStatisticRepository : IRespository<VisitorStatistic>
    {

    }
    public class VisitorStatisticRepository : RespositoryBase<VisitorStatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
