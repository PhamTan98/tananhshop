using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanShop.Data.Infrastructure;
using TanShop.Model.Models;

namespace TanShop.Data.Repositories
{
    public interface ISupportOnlineRepository : IRespository<SupportOnline>
    {

    }
    public class SupportOnlineRepository : RespositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
