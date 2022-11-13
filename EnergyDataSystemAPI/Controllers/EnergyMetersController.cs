using AutoMapper;
using EnergyDataSystem;
using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using EnergyDataSystemAPI.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnergyDataSystemAPI.Controllers
{
    [ApiController]
    [Route("api/energymeters")]
    public class EnergyMetersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IEnergyMeterRepository _energyMeterRepository;

        public EnergyMetersController(ApplicationDbContext context, IMapper mapper, IEnergyMeterRepository energyMeterRepository)
        {
            _context = context;
            _mapper = mapper;
            _energyMeterRepository = energyMeterRepository;
        }

        // GET: api/energymeters
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetEnergyMeters()
        {
            var energyMeters = await _energyMeterRepository.GetEnergyMetersAsync();

            return Ok(_mapper.Map<List<EnergyMeterDTO>>(energyMeters));
        }

        // GET api/energymeters/3
        [HttpGet("{energyMeterId:int}")]
        public async Task<IActionResult> GetEnergyMeter([FromRoute] int energyMeterId)
        {
            var energyMeter = await _energyMeterRepository.GetEnergyMeterAsync(energyMeterId);

            if (energyMeter == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_mapper.Map<EnergyMeterDTO>(energyMeter));
            }
        }

        // POST api/energymeters
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateEnergyMeter([FromBody] EnergyMeterCreationDTO energyMeterCreationDTO)
        {
            var newEnergyMeter = await _energyMeterRepository.CreateEnergyMeterAsync(_mapper.Map<EnergyMeter>(energyMeterCreationDTO));

            return CreatedAtAction(
                nameof(GetEnergyMeter),
                new { energyMeterId = newEnergyMeter.Id },
                _mapper.Map<EnergyMeterDTO>(newEnergyMeter));
        }

        // PUT api/energyMeters/3
        [HttpPut]
        [Route("{energyMeterId:int}")]
        public async Task<IActionResult> UpdateBuilding([FromRoute] int energyMeterId, [FromBody] EnergyMeterCreationDTO energyMeterDTO)
        {
            var updatedEnergyMeter = await _energyMeterRepository.UpdateEnergyMeterAsync(energyMeterId, energyMeterDTO);

            if (updatedEnergyMeter == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_mapper.Map<EnergyMeterDTO>(updatedEnergyMeter));
            }
        }

        // DELETE api/energymeters/3
        [HttpDelete]
        [Route("{energyMeterId:int}")]
        public async Task<IActionResult> DeleteEnergyMeter([FromRoute] int energyMeterId)
        {
            var deletedEnergyMeter = await _energyMeterRepository.DeleteEnergyMeterAsync(energyMeterId);

            if (deletedEnergyMeter == null)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        }

        // SOFT DELETE api/energymeters/softdelete/3
        /*    [HttpDelete]
            [Route("softdelete/{energyMeterId:int}")]
            public async Task<IActionResult> SoftDeleteEnergyMeter([FromRoute] int energyMeterId)
            {
                var softDeletedEnergyMeter = await _energyMeterRepository.SoftDeleteEnergyMeterAsync(energyMeterId);

                if (softDeletedEnergyMeter == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok();
                }
            }*/
    }
}
