using ProjeFinal.Core.DataAcsess.EntityFreameworkCore;
using ProjeFinal.DataAcsess.Abstract;
using ProjeFinal.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeFinal.DataAcsess.Concreate.EntityFremeworkCore
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ProjeFinalDbContext>, ICategoryDal
    {
    }
}
