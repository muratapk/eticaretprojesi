using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public string ProductPicture {  get; set; } = string.Empty;
        public decimal? ProductPrice { get; set; }
        public decimal? ProductQuantity { get; set; }
        public decimal? ProductDiscount { get; set; }
        public int? CateogoryId {  get; set; }   
        virtual public Category? Category { get; set; }
        
        //her kategoriden bir adet eklenecek burada relationship 
        //bağlantı oluşturulacak
    }
}
