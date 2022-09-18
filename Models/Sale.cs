using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Pet.Models
{
    public class Sale: BaseEntity
    {
        public String name { get; set; }
        public String genre { get; set; }
        public String species { get; set; }
        public String breed { get; set; }
        public String size { get; set; }
        public Double price { get; set; }
        public int monthBirth { get; set; }
        public int yearBirth { get; set; }
        public String district { get; set; }
        public String description { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
    }
}