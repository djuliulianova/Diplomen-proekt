using JewelryShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryShop.Abstraction
{
   public interface IBrandService
    {
        List<Brand> GetBrands();
        List<Product> GetProductsByBrand(int brandId);

    }
}
