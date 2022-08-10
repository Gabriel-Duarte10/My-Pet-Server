using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Pet.Data.Requests
{
    public class RescueRequest
    {
        public int id { get; set; }
        public String size { get; set; }
        public String district { get; set; }
        public String road { get; set; }
        public String description { get; set; }
    }
}