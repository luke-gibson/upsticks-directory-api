using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using upsticks_directory_api.Data.Entities;

namespace upsticks_directory_api.Models
{
    public class EstateAgentAddressModel
    {
        [Required]
        public int estateAgentAddressId { get; set; }
        [Required]
        public int estateAgentId { get; set; }
        [Required]
        public int addressId { get; set; }

        public AddressesModel addresses { get; set; }
    }
}
