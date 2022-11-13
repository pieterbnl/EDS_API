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
    [Route("api/buildings")]
    public class BuildingsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IBuildingRepository _buildingRepository;

        public BuildingsController(ApplicationDbContext context, IMapper mapper, IBuildingRepository buildingRepository)
        {
            _context = context;
            _mapper = mapper;
            _buildingRepository = buildingRepository;
        }

        // GET: api/buildings
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetBuildings()
        {
            var buildings = await _buildingRepository.GetBuildingsAsync();

            return Ok(_mapper.Map<List<BuildingDTO>>(buildings));
        }

        // GET api/buildings/3
        [HttpGet("{buildingId:int}")]
        public async Task<IActionResult> GetBuilding([FromRoute] int buildingId)
        {
            var building = await _buildingRepository.GetBuildingAsync(buildingId);

            if (building == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_mapper.Map<BuildingDTO>(building));
            }
        }

        // POST api/buildings
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateBuilding([FromBody] BuildingCreationDTO buildingCreationDTO)
        {
            var newBuilding = await _buildingRepository.CreateBuildingAsync(_mapper.Map<Building>(buildingCreationDTO));

            return CreatedAtAction(
                nameof(GetBuilding),
                new { buildingId = newBuilding.Id },
                _mapper.Map<BuildingDTO>(newBuilding));
        }

        // PUT api/buildings/3
        [HttpPut]
        [Route("{buildingId:int}")]
        public async Task<IActionResult> UpdateBuilding([FromRoute] int buildingId, [FromBody] BuildingCreationDTO buildingCreationDTO)
        {
            var updatedBuilding = await _buildingRepository.UpdateBuildingAsync(buildingId, buildingCreationDTO);

            if (updatedBuilding == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_mapper.Map<BuildingDTO>(updatedBuilding));
            }
        }

        // DELETE api/buildings/3
        [HttpDelete]
        [Route("{buildingId:int}")]
        public async Task<IActionResult> DeleteBuilding([FromRoute] int buildingId)
        {
            var deletedBuilding = await _buildingRepository.DeleteBuildingAsync(buildingId);

            if (deletedBuilding == null)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        }

        // SOFT DELETE api/buildings/softdelete/3
        /*    [HttpDelete]
            [Route("softdelete/{buildingId:int}")]
            public async Task<IActionResult> SoftDeleteBuilding([FromRoute] int buildingId)
            {
                var softDeletedBuilding = await _buildingRepository.SoftDeleteBuildingAsync(buildingId);

                if (softDeletedBuilding == null)
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
