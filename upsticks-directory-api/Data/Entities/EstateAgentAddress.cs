using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace upsticks_directory_api.Data.Entities
{
    public class EstateAgentAddress
    {       
        [Required, Key]
        public int estateAgentAddressId { get; set; }

        [Required, ForeignKey("estateAgent")]
        public int estateAgentId { get; set; }
        public EstateAgent estateAgent { get; set; }

        [Required, ForeignKey("addresses")]
        public int addressId { get; set; }
        public Addresses addresses { get; set; }
    }
}
