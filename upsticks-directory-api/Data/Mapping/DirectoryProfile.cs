using AutoMapper;
using System.Collections.Generic;
using upsticks_directory_api.Data.Entities;
using upsticks_directory_api.Models;

namespace upsticks_directory_api.Data
{
    public class DirectoryProfile : Profile
    {
        public DirectoryProfile()
        {
            CreateMap<EstateAgent, EstateAgentModel>();
        }
    }
}
