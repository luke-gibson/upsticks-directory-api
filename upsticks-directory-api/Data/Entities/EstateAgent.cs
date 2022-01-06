using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace upsticks_directory_api.Data.Entities
{
    public class EstateAgent
    {
        [Key]
        public int EstateAgentId { get; set; }
        public string EstateAgentName { get; set; }
        public string EstateAgentEmail { get; set; }
        public string EstateAgentTelephone { get; set; }
    }
}
