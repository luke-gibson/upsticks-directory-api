﻿using System.ComponentModel.DataAnnotations;

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
    }
}
