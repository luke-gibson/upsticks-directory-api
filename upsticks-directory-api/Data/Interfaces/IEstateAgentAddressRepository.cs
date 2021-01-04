﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using upsticks_directory_api.Data.Entities;

namespace upsticks_directory_api.Data
{
    public interface IEstateAgentAddressRepository
    {
        //General
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Estate Agent
        Task<EstateAgentAddress[]> GetAllEstateAgentsAddressAsync();
        Task<EstateAgentAddress[]> GetEstateAgentAddressByIdAsync(int addressId);
    }
}