using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
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
        private readonly ILogger<DirectoryContext> _logger;

        public EstateAgentRepository(DirectoryContext directoryContext, ILogger<DirectoryContext> logger)
        {
            _directoryContext = directoryContext;
            _logger = logger;
        }

        public void Add<T>(T entity) where T : class
        {
            _logger.LogInformation($"Adding an object of type {entity.GetType()} to the context.");
            _directoryContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _logger.LogInformation($"Removing an object of type {entity.GetType()} to the context.");
            _directoryContext.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            _logger.LogInformation($"Attempitng to save the changes in the context");

            // Only return success if at least one row was changed
            return (await _directoryContext.SaveChangesAsync()) > 0;
        }

        public async Task<EstateAgent[]> GetAllEstateAgentsAsync(bool includeAddresses = false)
        {
            _logger.LogInformation($"Getting all Estate Agents");

            IQueryable<EstateAgent> query = _directoryContext.EstateAgent;

            if (includeAddresses)
            {
                query = query
                    .Include(x => x.estateAgentAddresses)
                    .ThenInclude(y => y.addresses);
            }

            // OrderBy Id
            query = query.OrderByDescending(c => c.estateAgentId);

            return await query.ToArrayAsync();
        }

        public async Task<EstateAgent[]> GetEstateAgentByIdAsync(int estateAgentId)
        {
            _logger.LogInformation($"Getting all EstateAgents with ID {estateAgentId}");

            IQueryable<EstateAgent> query = _directoryContext.EstateAgent;

            // Add Query
            query = query
              .Where(x => x.estateAgentId == estateAgentId)
              .OrderByDescending(x => x.estateAgentId);

            return await query.ToArrayAsync();
        }
    }
}
