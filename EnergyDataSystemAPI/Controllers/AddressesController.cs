using AutoMapper;
using EnergyDataSystem;
using EnergyDataSystem.DTOs;
using EnergyDataSystem.Entities.Models;
using EnergyDataSystemAPI.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EnergyDataSystemAPI.Controllers;

[ApiController]
[Route("api/addresses")]
public class AddressesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IAddressRepository _addressRepository;
    
    public AddressesController(ApplicationDbContext context, IMapper mapper, IAddressRepository addressRepository)
    {
        this._context = context;
        this._mapper = mapper;
        this._addressRepository = addressRepository;
    }

    // GET api/addresses
    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetAddresses()
    {
        var addresses = await _addressRepository.GetAddressesAsync();        

        return Ok(_mapper.Map<List<AddressDTO>>(addresses));
    }


    // GET api/addresses/3
    [HttpGet("{addressId:int}")]
    public async Task<IActionResult> GetAddress([FromRoute] int addressId)
    {
        var address = await _addressRepository.GetAddressAsync(addressId);

        if (address == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(_mapper.Map<AddressDTO>(address));
        }
    }

    // POST api/addresses
    [HttpPost]
    [Route("")]
    public async Task<IActionResult> CreateAddress([FromBody] AddressCreationDTO addressCreationDTO)
    {
        var newAddress = await _addressRepository.CreateAddressAsync(_mapper.Map<Address>(addressCreationDTO));
        
        return CreatedAtAction(
            nameof(GetAddress),
            new { addressId = newAddress.Id },
            _mapper.Map<AddressDTO>(newAddress));
    }

    // PUT api/addresses/3
    [HttpPut]
    [Route("{addressId:int}")]
    public async Task<IActionResult> UpdateAddress([FromRoute] int addressId, [FromBody] AddressCreationDTO addressCreationDTO)
    {
        var updatedAddress = await _addressRepository.UpdateAddressAsync(addressId, addressCreationDTO);

        if (updatedAddress == null)
        {
            return NotFound();
        }
        else
        {
            return Ok();
        }
    }

    // DELETE api/addresses/3
    [HttpDelete]
    [Route("{addressId:int}")]
    public async Task<IActionResult> DeleteAddress([FromRoute] int addressId)
    {
        var deletedAddress = await _addressRepository.DeleteAddressAsync(addressId);

        if (deletedAddress == null)
        {
            return NotFound();
        }
        else
        {
            return Ok();
        }
    }

    // SOFT DELETE api/addresses/softdelete/3
/*    [HttpDelete]
    [Route("softdelete/{addressId:int}")]
    public async Task<IActionResult> SoftDeleteAddress([FromRoute] int addressId)
    {
        var softDeletedAddress = await _addressRepository.SoftDeleteAddressAsync(addressId);

        if (softDeletedAddress == null)
        {
            return NotFound();
        }
        else
        {
            return Ok();
        }
    }*/
}