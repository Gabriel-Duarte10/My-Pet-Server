using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Pet.Models
{
    public class LostImage
    {
        public int idLost { get; set; }
        public byte[] image { get; set; }
    }
}