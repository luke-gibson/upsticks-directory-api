using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace upsticks_directory_api.Data.Entities
{
    public class Removals
    {
        [Key]
        public int companyId { get; set; }
        public string companyName { get; set; }
        public string companyEmail { get; set; }
        public string companyTelephone { get; set; }
    }
}
