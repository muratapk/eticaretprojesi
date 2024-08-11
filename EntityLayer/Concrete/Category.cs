using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        virtual public List<Product>? Products { get; set; }
        //ürünlere birden fazla kategori atanabilir
        //? işareti boş olabilir
    }
}
