using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Pet.Models
{
    public class Announcement: BaseEntity
    {
        public String name { get; set; }
        public String phoneAnno { get; set; }
        public String emailAnno { get; set; }
        public String districAnno { get; set; }
        public String description { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
    }
}