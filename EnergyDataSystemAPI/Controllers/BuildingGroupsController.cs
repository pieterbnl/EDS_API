using AutoMapper;
using EnergyDataSystem;
using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using EnergyDataSystemAPI.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EnergyDataSystemAPI.Controllers;

[ApiController]
[Route("api/buildingroups")]
public class BuildingGroupsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IBuildingGroupRepository _buildingGroupRepository;
    
    public BuildingGroupsController(ApplicationDbContext context, IMapper mapper, IBuildingGroupRepository buildingGroupRepository)
    {
        this._context = context;
        this._mapper = mapper;
        this._buildingGroupRepository = buildingGroupRepository;
    }

    // GET api/buildingroups
    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetBuildingGroups()
    {
        var buildingroups = await _buildingGroupRepository.GetBuildingGroupsAsync();        

        return Ok(_mapper.Map<List<BuildingGroupDTO>>(buildingroups));
    }


    // GET api/buildingroups/3
    [HttpGet("{buildingGroupId:int}")]
    public async Task<IActionResult> GetBuildingGroup([FromRoute] int buildingGroupId)
    {
        var buildingGroup = await _buildingGroupRepository.GetBuildingGroupAsync(buildingGroupId);

        if (buildingGroup == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(_mapper.Map<BuildingGroupDTO>(buildingGroup));
        }
    }

    // POST api/buildingroups
    [HttpPost]
    [Route("")]
    public async Task<IActionResult> CreateBuildingGroup([FromBody] BuildingGroupCreationDTO buildingGroupCreationDTO)
    {
        var newBuildingGroup = await _buildingGroupRepository.CreateBuildingGroupAsync(_mapper.Map<BuildingGroup>(buildingGroupCreationDTO));
        
        return CreatedAtAction(
            nameof(GetBuildingGroup),
            new { buildingGroupId = newBuildingGroup.Id },
            _mapper.Map<BuildingGroupDTO>(newBuildingGroup));
    }

    // PUT api/buildingroups/3
    [HttpPut]
    [Route("{buildingGroupId:int}")]
    public async Task<IActionResult> UpdateBuildingGroup([FromRoute] int buildingGroupId, [FromBody] BuildingGroupCreationDTO buildingGroupCreationDTO)
    {
        var updatedBuildingGroup = await _buildingGroupRepository.UpdateBuildingGroupAsync(buildingGroupId, buildingGroupCreationDTO);

        if (updatedBuildingGroup == null)
        {
            return NotFound();
        }
        else
        {
            return Ok();
        }
    }

    // DELETE api/buildingroups/3
    [HttpDelete]
    [Route("{buildingGroupId:int}")]
    public async Task<IActionResult> DeleteBuildingGroup([FromRoute] int buildingGroupId)
    {
        var deletedBuildingGroup = await _buildingGroupRepository.DeleteBuildingGroupAsync(buildingGroupId);

        if (deletedBuildingGroup == null)
        {
            return NotFound();
        }
        else
        {
            return Ok();
        }
    }

    // SOFT DELETE api/buildingroups/softdelete/3
    /*    [HttpDelete]
        [Route("softdelete/{buildingGroupId:int}")]
        public async Task<IActionResult> SoftDeleteBuildingGroup([FromRoute] int buildingGroupId)
        {
            var softDeletedBuildingGroup = await _buildingGroupRepository.SoftDeleteBuildingGroupAsync(buildingGroupId);

            if (softDeletedBuildingGroup == null)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        }*/
}