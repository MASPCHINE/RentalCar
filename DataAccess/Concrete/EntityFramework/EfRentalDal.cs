using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public Rental GetCarAvailable(Expression<Func<Rental, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Rental>().OrderByDescending(r => r.RentalId).FirstOrDefault(filter);
            }
        }
    }
}
