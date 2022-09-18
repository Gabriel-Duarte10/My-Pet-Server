using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Pet.Data.Dto
{
    public class SaleDTO
    {
        public int id { get; set; }
        public String name { get; set; }
        public String species { get; set; }
        public String genre { get; set; }
        public String breed { get; set; }
        public String size { get; set; }
        public Double price { get; set; }
        public int monthBirth { get; set; }
        public int yearBirth { get; set; }
        public String district { get; set; }
        public String description { get; set; }
    }
    public class SaleFilter
    {
        public String genre { get; set; }
        public String species { get; set; }
        public String breed { get; set; }
        public String size { get; set; }
        public int? ageMin { get; set; }
        public int? ageMax { get; set; }
        public Double? priceMin { get; set; }
        public Double? priceMax { get; set; }
        public String district { get; set; }
    }
}