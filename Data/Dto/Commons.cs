using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Pet.Data.Dto
{
    public class Commons
    {
        public class Pagination<T, Filter>
    {
        public int Page { get; set; }
        public int PerPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalItems { get; set; }
        public List<Filter>? Filters { get; set; }
        public List<T> Data { get; set; }
    }
    }
}