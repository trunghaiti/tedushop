using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitory
{
    public interface IPost 
    {
    
    }
    public class PostRepository : RepositoryBase<Post>, IPost
    {
        public PostRepository(DbFactory dbFactory) : base(dbFactory)
        { 
        
        }
    }
}
