using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitory
{
    public interface ITagRepository
    { 
    
    }
    
    public class TagRepository : RepositoryBase<Tag> , ITagRepository
    {
        public TagRepository(DbFactory dbFactory) : base(dbFactory)
        { 
        
        }
    }
}
