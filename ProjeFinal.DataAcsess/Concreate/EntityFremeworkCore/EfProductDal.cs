using ProjeFinal.Core.DataAcsess.EntityFreameworkCore;
using ProjeFinal.DataAcsess.Abstract;
using ProjeFinal.Entity.ComplexTypes;
using ProjeFinal.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ProjeFinal.DataAcsess.Concreate.EntityFremeworkCore
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ProjeFinalDbContext>, IProductDal
    {
        public List<ProductCategoryComplexData> GetProductWithCategory()
        {
            using (var _context = new ProjeFinalDbContext())
            {
                var result = from p in _context.Products
                             join c in _context.Categories on p.CategoryId equals c.Id
                             select new ProductCategoryComplexData
                             {
                                 CategoryName = c.Name,
                                 Height = p.Height,
                                 ProductId = p.Id,
                                 ProductName = p.Name,
                                 Weight = p.Weight,
                                 Width = p.Width
                             };
                return result.ToList();
            }
        }
    }
}
