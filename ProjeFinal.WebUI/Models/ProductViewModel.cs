using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjeFinal.Entity.ComplexTypes;
using ProjeFinal.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeFinal.WebUI.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductCategoryComplexData> Products { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public List<IFormFile> FormFiles { get; set; }
    }
}
