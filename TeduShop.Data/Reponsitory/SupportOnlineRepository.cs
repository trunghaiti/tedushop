using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitory
{
    public interface ISupportOnlineRepository
    { 
    
    }
    public class SupportOnlineRepository : RepositoryBase<SupportOnline> , ISupportOnlineRepository
    {
        public SupportOnlineRepository(DbFactory dbFactory) : base(dbFactory)
        { 
        
        }
    }
}
