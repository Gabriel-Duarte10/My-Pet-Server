using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Pet.Data.Requests
{
    public class AnnouncementRequest
    {
        public String nameAnno { get; set; }
        public String phoneAnno { get; set; }
        public String emailAnno { get; set; }
        public String districAnno { get; set; }
        public String description { get; set; }
    }
}