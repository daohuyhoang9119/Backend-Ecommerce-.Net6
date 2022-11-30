using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = "Iphone";
        public int Price { get; set; } = 22000;
        public int Discount { get; set; }
        public int Rating_Average { get; set; } = 5;
        public string Description { get; set; } = "Best option for u guy";
        public string Brand_Name { get; set; } = "Apple";
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}