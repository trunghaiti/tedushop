using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitory
{
    public interface IVisistorStatistic : IReponsitory<VisistorStatistic>
    {
    
    }
    public class VisistorStatisticRepository : RepositoryBase<VisistorStatistic> , IVisistorStatistic
    {
        public VisistorStatisticRepository(DbFactory dbFactory) : base(dbFactory)
        { 
        
        }
    }
}
