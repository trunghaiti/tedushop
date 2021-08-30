using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitory
{
    public interface ISystemConfigRepository : IReponsitory<SystemConfig>
    { 
    
    }
    public class SystemConfigRepository : RepositoryBase<SystemConfig> , ISystemConfigRepository
    {
        public SystemConfigRepository(DbFactory dbFactory) : base(dbFactory)
        { 
        
        }
    }
}
