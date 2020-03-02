using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanShop.Data.Infrastructure;
using TanShop.Model.Models;

namespace TanShop.Data.Repositories
{
    public interface IOrderRepository : IRespository<Order>
    {

    }
    public class OrderRepository : RespositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
