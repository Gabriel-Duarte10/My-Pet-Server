using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Pet.Models
{
    public class User: BaseEntity
    {
        public String name { get; set; }
        public String email { get; set; }
        public String phone { get; set; }
        public String password { get; set; }
        public TypeLogin type { get; set; }
    }
    public enum TypeLogin
    {
        Google = 1,
        Facebook = 2,
        CreateUser = 3
    }
}