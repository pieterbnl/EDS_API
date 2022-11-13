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
    [Route("api/measurements")]
    public class MeasurementsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IMeasurementRepository _measurementRepository;

        public MeasurementsController(ApplicationDbContext context, IMapper mapper, IMeasurementRepository measurementRepository)
        {
            _context = context;
            _mapper = mapper;
            _measurementRepository = measurementRepository;
        }

        // GET: api/measurements
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetMeasurements()
        {
            var measurements = await _measurementRepository.GetMeasurementsAsync();

            return Ok(_mapper.Map<List<MeasurementDTO>>(measurements));
        }

        // GET api/measurements/3
        [HttpGet("{measurementId:int}")]
        public async Task<IActionResult> GetMeasurement([FromRoute] int measurementId)
        {
            var measurement = await _measurementRepository.GetMeasurementAsync(measurementId);

            if (measurement == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_mapper.Map<MeasurementDTO>(measurement));
            }
        }

        // POST api/measurements
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateMeasurement([FromBody] MeasurementCreationDTO measurementCreationDTO)
        {
            var newMeasurement = await _measurementRepository.CreateMeasurementAsync(_mapper.Map<Measurement>(measurementCreationDTO));

            return CreatedAtAction(
                nameof(GetMeasurement),
                new { measurementId = newMeasurement.Id },
                _mapper.Map<MeasurementDTO>(newMeasurement));
        }

        // PUT api/measurements/3
        [HttpPut]
        [Route("{measurementId:int}")]
        public async Task<IActionResult> UpdateMeasurement([FromRoute] int measurementId, [FromBody] MeasurementCreationDTO measurementCreationDTO)
        {
            var updatedMeasurement = await _measurementRepository.UpdateMeasurementAsync(measurementId, measurementCreationDTO);

            if (updatedMeasurement == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_mapper.Map<MeasurementDTO>(updatedMeasurement));
            }
        }

        // DELETE api/measurements/3
        [HttpDelete]
        [Route("{measurementId:int}")]
        public async Task<IActionResult> DeleteMeasurement([FromRoute] int measurementId)
        {
            var deletedMeasurement = await _measurementRepository.DeleteMeasurementAsync(measurementId);

            if (deletedMeasurement == null)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        }

        // SOFT DELETE api/measurements/softdelete/3
        /*    [HttpDelete]
            [Route("softdelete/{measurementId:int}")]
            public async Task<IActionResult> SoftDeleteMeasurement([FromRoute] int measurementId)
            {
                var softDeletedMeasurement = await _measurementRepository.SoftDeleteMeasurementAsync(measurementId);

                if (softDeletedMeasurement == null)
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
