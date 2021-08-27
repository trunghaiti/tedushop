using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitory
{
    public interface IPostCategoryRepository
    { 
    
    }
    class PostCategoryRepository : RepositoryBase<PostCategory> , IPostCategoryRepository
    {
        public PostCategoryRepository(DbFactory dbFactory) : base(dbFactory)
        { 
        
        }
    }
}
