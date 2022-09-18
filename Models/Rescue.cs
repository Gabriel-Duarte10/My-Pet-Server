using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Pet.Models
{
    public class Rescue: BaseEntity
    {
        public String species { get; set; }
        public String size { get; set; }
        public String district { get; set; }
        public String road { get; set; }
        public String description { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
    }
}