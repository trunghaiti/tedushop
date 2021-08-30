using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;


namespace TeduShop.Data.Reponsitory
{
    public interface IMenuRepository : IReponsitory<Menu>
    { 
    
    }
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(DbFactory dbFactory) : base(dbFactory)
        { 
        
        }
    }
}
