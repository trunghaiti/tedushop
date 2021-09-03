using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IVisistorStatistic : IRepository<VisistorStatistic>
    {

    }
    public class VisistorStatisticRepository : RepositoryBase<VisistorStatistic>, IVisistorStatistic
    {
        public VisistorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
