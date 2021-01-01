using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using upsticks_directory_api.Data.Entities;

namespace upsticks_directory_api.Data
{
    public interface IRemovalsRepository
    {
        //General
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Removals
        Task<Removals[]> GetAllRemovalsAsync();
        Task<Removals[]> GetRemovalsByIdAsync(int companyId);
    }
}
