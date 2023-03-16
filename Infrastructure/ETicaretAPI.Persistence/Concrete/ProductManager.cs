using ETicaretAPI.Application.Abstract;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concrete
{
    
    public class ProductManager : IProductService
    {
        public List<Product> GetProducts()
        => new()
        { 
          new(){Id=Guid.NewGuid(), Name="Product 1", Price=200, Stock=5, CreatedDate=DateTime.Now},  //new product nesnesi oluşturmama gerek yok zaten başta product tipinde list tanımladık
          new(){Id=Guid.NewGuid(), Name="Product 2", Price=100, Stock=10, CreatedDate=DateTime.Now},
          new(){Id=Guid.NewGuid(), Name="Product 3", Price=400, Stock=25, CreatedDate=DateTime.Now},  //new product nesnesi oluşturmama gerek yok zaten başta product tipinde list tanımladık
          new(){Id=Guid.NewGuid(), Name="Product 4", Price=150, Stock=200, CreatedDate=DateTime.Now}
         }; //target type özelliğini kullanarak koleksiyon oluşturucam.
    }
}
