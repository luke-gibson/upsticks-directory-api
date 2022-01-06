using System.ComponentModel.DataAnnotations;

namespace upsticks_directory_api.Models
{
    public class AddressesModel
    {
        [Required]
        public int AddressId { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required]
        public string AddressTown { get; set; }
        [Required]
        public string AddressCounty { get; set; }
        [Required]
        public string AddressPostcode { get; set; }
        [Required]
        public string AddressEmail { get; set; }
        [Required]
        public string AddressTelephone { get; set; }
    }
}
