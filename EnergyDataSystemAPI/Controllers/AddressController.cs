using AutoMapper;
using EnergyDataSystem;
using EnergyDataSystem.DTOs;
using EnergyDataSystem.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EnergyDataSystemAPI.Controllers;

[ApiController]
[Route("api/addresses")]
public class AddressController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IAddressRepository _addressRepository;
    
    public AddressController(ApplicationDbContext context, IMapper mapper, IAddressRepository addressRepository)
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
}