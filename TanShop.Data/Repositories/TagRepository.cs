using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanShop.Data.Infrastructure;
using TanShop.Model.Models;

namespace TanShop.Data.Repositories
{
    public interface ITagRepository : IRespository<Tag>
    {

    }

    public class TagRepository : RespositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
