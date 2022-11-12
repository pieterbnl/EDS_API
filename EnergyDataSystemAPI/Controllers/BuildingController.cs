using AutoMapper;
using EnergyDataSystem;
using EnergyDataSystem.DTOs;
using EnergyDataSystem.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnergyDataSystemAPI.Controllers
{
    [ApiController]
    [Route("api/buildings")]
    public class BuildingController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IBuildingRepository _buildingRepository;

        public BuildingController(ApplicationDbContext context, IMapper mapper, IBuildingRepository buildingRepository)
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
        
    }
}
