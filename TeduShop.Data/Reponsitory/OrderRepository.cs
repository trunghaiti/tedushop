using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitory
{
    public interface IOrderRepository : IReponsitory<Order>
    { 
    
    }
    public class OrderRepository : RepositoryBase<Order> , IOrderRepository
    {
        public OrderRepository(DbFactory dbFactory) : base(dbFactory)
        { 
        
        }
    }
}
