using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using upsticks_directory_api.Data;
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

        [HttpGet("GetEstateAgent")]
        public async Task<ActionResult<EstateAgentModel[]>> GetEstateAgent(bool includeAddresses = false)
        {
            try
            {
                var results = await _estateAgentRepository.GetAllEstateAgentsAsync(includeAddresses);

                return _mapper.Map<EstateAgentModel[]>(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        //[HttpGet("GetEstateAgentById")]
        //public async Task<ActionResult<EstateAgentModel[]>> GetEstateAgentById(int companyId)
        //{
        //    try
        //    {
        //        var results = await _estateAgentRepository.GetEstateAgentByIdAsync(companyId);

        //        if (!results.Any())
        //        {
        //            return NotFound();
        //        }

        //        return _mapper.Map<EstateAgentModel[]>(results);
        //    }
        //    catch (Exception)
        //    {
        //        return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
        //    }
        //}
    }
}
