using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using upsticks_directory_api.Data.Entities;
using upsticks_directory_api.Models;

namespace upsticks_directory_api.Data
{
    public class DirectoryProfile : Profile
    {
        public DirectoryProfile()
        {
            this.CreateMap<EstateAgent, EstateAgentModel>();
            this.CreateMap<Conveyancer, ConveyancerModel>();
            this.CreateMap<Removals, RemovalsModel>();
        }
    }
}
