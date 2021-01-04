using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace upsticks_directory_api.Data.Entities
{
    public class Addresses
    {        
        [Required, Key]
        public int addressId { get; set; }
        [Required]
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        [Required]
        public string addressTown { get; set; }
        [Required]
        public string addressCounty { get; set; }
        [Required]
        public string addressPostcode { get; set; }
        [Required]
        public string addressEmail { get; set; }
        [Required]
        public string addressTelephone { get; set; }
        
        public EstateAgentAddress estateAgentAddress { get; set; }
    }
}
