using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanShop.Data.Infrastructure;
using TanShop.Model.Models;

namespace TanShop.Data.Repositories
{
    public interface IProductRepository
    {

    }
    public class ProductRepository : RespositoryBase<Product>,IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
