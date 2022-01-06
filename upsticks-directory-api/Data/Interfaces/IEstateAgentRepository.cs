using System.Collections.Generic;
using System.Threading.Tasks;
using upsticks_directory_api.Data.Entities;
using upsticks_directory_api.Models;

namespace upsticks_directory_api.Data
{
    public interface IEstateAgentRepository
    {
        Task<List<EstateAgent>> GetEstateAgents();
        Task<EstateAgent> GetEstateAgentById(int estateAgentId);
        Task<EstateAgent> AddEstateAgent(EstateAgent estateAgent);
        //Task<EstateAgent> UpdateEstateAgent(EstateAgent estateAgent);
        //void DeleteEstateAgent(int estateAgentId);
    }
}
