using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace upsticks_directory_api.Data.Entities
{
    public class EstateAgent
    {
        [Key]
        public int estateAgentId { get; set; }
        public string estateAgentName { get; set; }
        public string estateAgentEmail { get; set; }
        public string estateAgentTelephone { get; set; }
        public EstateAgentAddress estateAgentAddresses { get; set; }
        //public Addresses addresses { get; set; }               
    }
}
