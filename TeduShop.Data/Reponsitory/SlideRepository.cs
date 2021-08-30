using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitory
{
    public interface ISlideRepository : IReponsitory<Slide>
    {
    
    }
    public class SlideRepository : RepositoryBase<Slide> , ISlideRepository
    {
        public SlideRepository(DbFactory dbFactory) : base(dbFactory)
        { 
        
        }
    }
}
