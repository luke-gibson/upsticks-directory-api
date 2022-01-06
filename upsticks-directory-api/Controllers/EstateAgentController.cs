using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using upsticks_directory_api.Data;
using upsticks_directory_api.Data.Entities;
using upsticks_directory_api.Models;

namespace upsticks_directory_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentController : ControllerBase
    {
        private readonly IEstateAgentRepository _estateAgentRepository;
        private readonly IMapper _mapper;

        public EstateAgentController(IEstateAgentRepository estateAgentRepository, IMapper mapper)
        {
            _estateAgentRepository = estateAgentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<EstateAgent>> GetEstateAgents()
        {            
            return await _estateAgentRepository.GetEstateAgents();
        }

        [HttpGet("{estateAgentId}")]
        public async Task<EstateAgent> GetEstateAgentById(int estateAgentId)
        {
            return await _estateAgentRepository.GetEstateAgentById(estateAgentId);
        }

        [HttpPost]
        public async Task<EstateAgent> AddEstateAgent([FromBody]EstateAgentModel estateAgent)
        {
            return await _estateAgentRepository.AddEstateAgent(estateAgent);
        }
    }
}
