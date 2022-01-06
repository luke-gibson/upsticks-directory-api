using System.ComponentModel.DataAnnotations;

namespace upsticks_directory_api.Models
{
    public class EstateAgentAddressModel
    {
        [Required]
        public int EstateAgentAddressId { get; set; }
        [Required]
        public int EstateAgentId { get; set; }
        [Required]
        public int AddressId { get; set; }
    }
}
