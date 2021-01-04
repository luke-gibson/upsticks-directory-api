using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace upsticks_directory_api.Models
{
    public class EstateAgentModel
    {
        public int estateAgentId { get; set; }
        public string estateAgentName { get; set; }
        public string estateAgentEmail { get; set; }
        public string estateAgentTelephone { get; set; }
        public virtual ICollection<AddressesModel> estateAgentAddresses { get; set; }
    }
}
