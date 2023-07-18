using ProjeFinal.Core.DataAcsess;
using ProjeFinal.Entity.ComplexTypes;
using ProjeFinal.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeFinal.DataAcsess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductCategoryComplexData> GetProductWithCategory();
    }
}
