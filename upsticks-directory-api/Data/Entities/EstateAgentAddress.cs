using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace upsticks_directory_api.Data.Entities
{
    public class EstateAgentAddress
    {       
        [Required, Key]
        public int estateAgentAddressId { get; set; }

        [Required, ForeignKey("estateAgentId")]
        public int estateAgentId { get; set; }
        public EstateAgent estateAgent { get; set; }

        [Required, ForeignKey("addressId")]
        public int addressId { get; set; }     
        public virtual Addresses Address { get; set; }
    }
}
