using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitory
{
    public interface IPostTagRepository : IReponsitory<PostTag>
    {
    
    }
    public class PostTagRepository : RepositoryBase<PostTag> , IPostTagRepository
    {
        public PostTagRepository(DbFactory dbFactory) : base(dbFactory)
        { 
        
        }
    }
}
