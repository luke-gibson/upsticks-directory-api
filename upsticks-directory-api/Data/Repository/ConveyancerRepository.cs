using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using upsticks_directory_api.Data.Entities;

namespace upsticks_directory_api.Data
{
    public class ConveyancerRepository : IConveyancerRepository
    {
        private readonly DirectoryContext _directoryContext;
        private readonly ILogger<DirectoryContext> _logger;

        public ConveyancerRepository(DirectoryContext directoryContext, ILogger<DirectoryContext> logger)
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

        public async Task<Conveyancer[]> GetAllConveyancersAsync()
        {
            _logger.LogInformation($"Getting all Conveyancers");

            IQueryable<Conveyancer> query = _directoryContext.Conveyancer;

            // OrderBy Id
            query = query.OrderByDescending(c => c.companyId);

            return await query.ToArrayAsync();
        }

        public async Task<Conveyancer[]> GetConveyancerByIdAsync(int companyId)
        {
            _logger.LogInformation($"Getting all Conveyancers with ID {companyId}");

            IQueryable<Conveyancer> query = _directoryContext.Conveyancer;

            // Add Query
            query = query
              .Where(x => x.companyId == companyId)
              .OrderByDescending(x => x.companyId);

            return await query.ToArrayAsync();
        }
    }
}
