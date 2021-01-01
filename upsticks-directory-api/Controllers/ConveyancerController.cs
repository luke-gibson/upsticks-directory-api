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
    public class ConveyancerController : ControllerBase
    {
        private readonly IConveyancerRepository _conveyancerRepository;
        private readonly IMapper _mapper;

        public ConveyancerController(IConveyancerRepository conveyancerRepository, IMapper mapper)
        {
            _conveyancerRepository = conveyancerRepository;
            _mapper = mapper;
        }

        [HttpGet("GetConveyancer")]
        public async Task<ActionResult<ConveyancerModel[]>> GetConveyancer()
        {
            try
            {
                var results = await _conveyancerRepository.GetAllConveyancersAsync();

                return _mapper.Map<ConveyancerModel[]>(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("GetConveyancerById")]
        public async Task<ActionResult<ConveyancerModel[]>> GetConveyancerById(int companyId)
        {
            try
            {
                var results = await _conveyancerRepository.GetConveyancerByIdAsync(companyId);

                if (!results.Any())
                {
                    return NotFound();
                }

                return _mapper.Map<ConveyancerModel[]>(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
    }
}
