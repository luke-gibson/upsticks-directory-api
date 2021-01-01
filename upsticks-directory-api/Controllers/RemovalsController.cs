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
    public class RemovalsController : ControllerBase
    {
        private readonly IRemovalsRepository _removalsRepository;
        private readonly IMapper _mapper;

        public RemovalsController(IRemovalsRepository removalsRepository, IMapper mapper)
        {
            _removalsRepository = removalsRepository;
            _mapper = mapper;
        }

        [HttpGet("GetRemovals")]
        public async Task<ActionResult<RemovalsModel[]>> GetRemovals()
        {
            try
            {
                var results = await _removalsRepository.GetAllRemovalsAsync();

                return _mapper.Map<RemovalsModel[]>(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("GetRemovalsById")]
        public async Task<ActionResult<RemovalsModel[]>> GetRemovalsById(int companyId)
        {
            try
            {
                var results = await _removalsRepository.GetRemovalsByIdAsync(companyId);

                if (!results.Any())
                {
                    return NotFound();
                }

                return _mapper.Map<RemovalsModel[]>(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
    }
}
