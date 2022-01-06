using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using upsticks_directory_api.Data.Entities;
using upsticks_directory_api.Models;

namespace upsticks_directory_api.Data
{
    public class EstateAgentRepository : IEstateAgentRepository
    {
        private readonly DirectoryContext _directoryContext;

        public EstateAgentRepository(DirectoryContext directoryContext)
        {
            _directoryContext = directoryContext;
        }

        public async Task<EstateAgent> AddEstateAgent(EstateAgent estateAgent)
        {
            var result = await _directoryContext.EstateAgent.AddAsync(estateAgent);
            await _directoryContext.SaveChangesAsync();
            return result.Entity;
        }       

        public async Task<EstateAgent> GetEstateAgentById(int estateAgentId)
        {
            return await _directoryContext.EstateAgent
                .Where(ea => ea.EstateAgentId == estateAgentId)
                .FirstOrDefaultAsync();
        }

        public async Task<List<EstateAgent>> GetEstateAgents()
         => await _directoryContext.EstateAgent.ToListAsync();

        //public async void DeleteEstateAgent(int estateAgentId)
        //{
        //    var result = await _directoryContext.EstateAgent
        //        .FirstOrDefaultAsync(e => e.EstateAgentId == estateAgentId);
        //    if (result != null)
        //    {
        //        _directoryContext.EstateAgent.Remove(result);
        //        await _directoryContext.SaveChangesAsync();
        //    }
        //}

        //public async Task<EstateAgent> UpdateEstateAgent(EstateAgent estateAgent)
        //{
        //    var result = await _directoryContext.EstateAgent
        //        .FirstOrDefaultAsync(ea => ea.EstateAgentId == estateAgent.EstateAgentId);

        //    if (result != null)
        //    {
        //        result.EstateAgentName = estateAgent.EstateAgentName;
        //        result.EstateAgentTelephone = estateAgent.EstateAgentTelephone;
        //        result.EstateAgentEmail = estateAgent.EstateAgentEmail;

        //        await _directoryContext.SaveChangesAsync();

        //        return result;
        //    }

        //    return null;
        //}
    }
}
