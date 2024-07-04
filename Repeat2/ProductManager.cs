using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat2
{
    internal class ProductManager
    {
        public void AddProduct(Product product)
        {
            Console.WriteLine($"Id-si {product.Id} , adi {product.Name} olan mehsul depoya elave olundu");
        }
        public void DeleteProduct()
        {
            Console.WriteLine("Mehsul siyahidan cixarildi");
        }
        public void UpdateProduct()
        {
            Console.WriteLine("mehsul tezesi ile yenilendi");
        }
    }
}
