using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace upsticks_directory_api.Models
{
    public class RemovalsModel
    {
        public int companyId { get; set; }
        public string companyName { get; set; }
        public string companyEmail { get; set; }
        public string companyTelephone { get; set; }
    }
}
