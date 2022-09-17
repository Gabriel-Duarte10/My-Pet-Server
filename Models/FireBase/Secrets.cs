using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Pet.Models.FireBase
{
   public sealed class Secrets
    {
        public string BucketName { get; set; }

        public FirebaseAuthenticationModel Authentication { get; set; }
    }
}