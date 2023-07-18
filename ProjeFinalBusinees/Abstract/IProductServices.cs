using ProjeFinal.Entity.ComplexTypes;
using ProjeFinal.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjeFinalBusinees.Abstract
{
    public interface IProductServices
    {
        Product Add(Product product);
        Task<Product> AddAsync(Product product);
        Product Update(Product product);
        Task<Product> UpdateAsync(Product product);
        void Delete(Product product);
        Product GetById(int id);
        Product GetByName(string name);
        List<Product> GetList();
        List<Product> GetListByCategoryId(int categoryId);
        List<ProductCategoryComplexData> GetProductWithCategory();

    }
}
