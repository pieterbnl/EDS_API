using AutoMapper;
using EnergyDataSystem;
using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using EnergyDataSystem.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EnergyDataSystemAPI.Controllers;

[ApiController]
[Route("api/owners")]
public class OwnersController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IOwnerRepository _ownersRepository;
    
    public OwnersController(ApplicationDbContext context, IMapper mapper, IOwnerRepository ownersRepository)
    {
        this._context = context;
        this._mapper = mapper;
        this._ownersRepository = ownersRepository;
    }

    // GET api/owners
    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetOwners()
    {
        var owners = await _ownersRepository.GetOwnersAsync();        

        return Ok(_mapper.Map<List<OwnerDTO>>(owners));
    }


    // GET api/owners/3
    [HttpGet("{ownerId:int}")]
    public async Task<IActionResult> GetOwner([FromRoute] int ownerId)
    {
        var owner = await _ownersRepository.GetOwnerAsync(ownerId);

        if (owner == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(_mapper.Map<OwnerDTO>(owner));
        }
    }

    // POST api/owners
    [HttpPost]
    [Route("")]
    public async Task<IActionResult> CreateOwner([FromBody] OwnerCreationDTO ownerCreationDTO)
    {
        var newOwner = await _ownersRepository.CreateOwnerAsync(_mapper.Map<Owner>(ownerCreationDTO));
        
        return CreatedAtAction(
            nameof(GetOwner),
            new { ownerId = newOwner.Id },
            _mapper.Map<OwnerDTO>(newOwner));
    }

    // PUT api/owners/3
    [HttpPut]
    [Route("{ownerId:int}")]
    public async Task<IActionResult> UpdateOwner([FromRoute] int ownerId, [FromBody] OwnerCreationDTO ownerCreationDTO)
    {
        var updatedOwner = await _ownersRepository.UpdateOwnerAsync(ownerId, ownerCreationDTO);

        if (updatedOwner == null)
        {
            return NotFound();
        }
        else
        {
            return Ok();
        }
    }

    // DELETE api/owners/3
    [HttpDelete]
    [Route("{ownerId:int}")]
    public async Task<IActionResult> DeleteOwner([FromRoute] int ownerId)
    {
        var deletedOwner = await _ownersRepository.DeleteOwnerAsync(ownerId);

        if (deletedOwner == null)
        {
            return NotFound();
        }
        else
        {
            return Ok();
        }
    }

    // SOFT DELETE api/owners/softdelete/3
    /*    [HttpDelete]
        [Route("softdelete/{ownerId:int}")]
        public async Task<IActionResult> SoftDeleteOwner([FromRoute] int ownerId)
        {
            var softDeletedOwner = await _ownersRepository.SoftDeleteOwnerAsync(ownerId);

            if (softDeletedOwner == null)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        }*/
}